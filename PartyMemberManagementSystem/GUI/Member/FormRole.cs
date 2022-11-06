using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SecurityP;

namespace PartyMemberManagementSystem.GUI.Member
{
    public partial class FormRole : Form
    {
        public FormRole()
        {
            InitializeComponent();
            loadRole();
            btnUpdate.Click += dgvList_DoubleClick;
        }

        private void loadRole()
        {
            
            string sql = "SELECT * FROM tblRole";
            DataTable dtr = new DataTable();
            dtr = Cmd.ExecuteDataTable(sql);
            dgvList.DataSource = dtr;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormRoleNE frm = new FormRoleNE();
            frm.newEdit = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.txtsearch.Clear();
                loadRole();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = default(DataGridViewRow);
            row = dgvList.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }
            FormRoleNE frm = new FormRoleNE();
            frm.txtRoleName.Text = (string)row.Cells["roleName"].Value;
            frm.txtDetail.Text = (string)row.Cells["detail"].Value;
            int id = (int)row.Cells["roleID"].Value;
            frm.roleid = id;
            frm.newEdit = false;            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.txtsearch.Clear();
                loadRole();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = default(DataGridViewRow);
            row = dgvList.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }
            if (MessageBox.Show("YOU REAL WANT TO DELETE (" + row.Cells["RoleName"].Value + ")!", "DELETE Role", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Cmd.Parameters["@RoleId"] = row.Cells["roleID"].Value;
                    Cmd.ExecuteNonQuery("UPDATE tblRole SET [Active]=false WHERE RoleID=@RoleId");
                    MessageBox.Show("DELETE SUCCESS!");
                }
                catch
                {
                    MessageBox.Show("DELETE FAIL!");
                }
                //MessageBox.Show("ABC");
                loadRole();
            }
            
        }

        private void FormRole_Load(object sender, EventArgs e)
        {
            this.btnAdd.Enabled = App.IsAuthorized(Permissions.Manage_Role_add);
            this.btnUpdate.Enabled = App.IsAuthorized(Permissions.Manage_Role_Edit);
            this.btnDelete.Enabled = App.IsAuthorized(Permissions.Manage_Role_Delete);
        }
    }
}
