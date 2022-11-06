using SecurityP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PartyMemberManagementSystem.GUI.Member
{
    public partial class FormFamilyStatus : Form
    {
        public FormFamilyStatus()
        {
            InitializeComponent();

            this.btnAdd.Enabled = App.IsAuthorized(Permissions.List_Member_add);
            this.btnUpdate.Enabled = App.IsAuthorized(Permissions.List_Member_Edit);
            this.btnDelete.Enabled = App.IsAuthorized(Permissions.List_Member_Delete);

            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormFamilyStatusNE frm = new FormFamilyStatusNE();
            if (frm.ShowDialog() == DialogResult.OK) 
            {
                Cmd.Parameters["@name"] = frm.txtStatusName.Text.Trim();
                Cmd.Parameters["@detail"] = frm.txtDetail.Text.Trim();
                Cmd.ExecuteNonQuery("INSERT INTO tblFamilyStatus (StatusName, Detail, Active) VALUES(@name, @detail, true)");
            }

            MessageBox.Show("បញ្ចូលទិន្នន័យបានសម្រេច!");
            loadData();
        }

        private void loadData()
        {
            DataTable dt = new DataTable();
            dt = Cmd.ExecuteDataTable("SELECT StatusID, StatusName, Detail FROM tblFamilyStatus WHERE Active=true");
            dgvList.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = default(DataGridViewRow);
            row = dgvList.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }

            FormFamilyStatusNE frm = new FormFamilyStatusNE();
            frm.txtStatusName.Text=row.Cells["StatusName"].Value.ToString();
            frm.txtDetail.Text = row.Cells["Detail"].Value.ToString();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Cmd.Parameters["@name"] = frm.txtStatusName.Text.Trim();
                Cmd.Parameters["@detail"] = frm.txtDetail.Text.Trim();
                Cmd.Parameters["@sId"]=row.Cells["StatusID"].Value;
                Cmd.ExecuteNonQuery("UPDATE tblFamilyStatus SET StatusName=@name, Detail=@detail WHERE StatusID=@sId");
            }

            MessageBox.Show("កែប្រែទិន្ន័យបានជោគជ័យ!");
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = default(DataGridViewRow);
            row = dgvList.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }
            Cmd.Parameters["@id"] = row.Cells["StatusID"].Value;
            Cmd.ExecuteNonQuery("UPDATE tblFamilyStatus SET Active=False WHERE StatusID=@id");
            MessageBox.Show("លុបទិន្នន័យបានជោគជ័យ!");
            loadData();
        }
    }
}
