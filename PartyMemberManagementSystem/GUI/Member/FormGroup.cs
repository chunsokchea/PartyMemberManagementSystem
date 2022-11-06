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
    public partial class FormGroup : Form
    {
        public FormGroup()
        {
            InitializeComponent();
            UI.FormatDataGrid(dgvList);
            loadGroup();
            loadVillageCbo();
            btnUpdate.Click += dgvList_DoubleClick;
        }

        private void loadGroup()
        {
            DataTable dtg = new DataTable();

            if (cboall.Checked == true)
            {
                Cmd.Parameters["@search"] = "%" + txtsearch.Text + "%";
                dtg = Cmd.ExecuteDataTable("SELECT * FROM tblGroup WHERE GroupName like @search AND Active=TRUE");
            }
            else
            {
                Cmd.Parameters["@search"] = "%" + txtsearch.Text + "%";
                Cmd.Parameters["@villageid"] = cboVillage.SelectedValue;
                dtg = Cmd.ExecuteDataTable("SELECT * FROM tblGroup WHERE GroupName like @search AND VillageID = @villageid AND Active=TRUE");
            }
            dgvList.DataSource = dtg;
        }

        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = default(DataGridViewRow);
            row = dgvList.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }
            FormGroupNE frm = new FormGroupNE();
            frm.txtGroupName.Text = (string)row.Cells["groupName"].Value;
            frm.txtDetail.Text = (string)row.Cells["Detail"].Value;
            int id = (int)row.Cells["groupID"].Value;
            frm.groupId = id;
            frm.villageId = (int)row.Cells["villageID"].Value;
            frm.newEdit = false;            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.txtsearch.Clear();
                loadGroup();
            }
        }

        private void loadVillageCbo()
        {
            string sql = "SELECT * FROM tblVillage";
            DataTable dtv = new DataTable();
            dtv = Cmd.ExecuteDataTable(sql);
            cboVillage.DisplayMember = "VillageName";
            cboVillage.ValueMember = "VillageID";
            cboVillage.DataSource = dtv;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormGroupNE frm = new FormGroupNE();
            frm.newEdit = true;
            if (cboall.Checked == false)
            {
                frm.villageId = (int)cboVillage.SelectedValue;
                frm.cboVillage.SelectedValue = (int)cboVillage.SelectedValue;
                frm.cboVillage.Enabled = false;
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.txtsearch.Clear();
                loadGroup();
            }
        }

        private void cboVillage_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboall.Checked == false)
            {
                txtsearch.Clear();
                loadGroup();
            }
            
        }

        private void cboall_CheckedChanged(object sender, EventArgs e)
        {
            if (cboall.Checked == false)
            {
                txtsearch.Clear();
                loadGroup();
                cboVillage.Visible = true;
            }
            else
            {
                loadGroup();
                cboVillage.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = default(DataGridViewRow);
            row = dgvList.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }
            if (MessageBox.Show("YOU REAL WANT TO DELETE (" + row.Cells["GroupName"].Value + ")!", "DELETE GROUP", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int id = (int)row.Cells["groupID"].Value;
                    Cmd.Parameters["@groupid"] = id;
                    Cmd.ExecuteNonQuery("UPDATE tblGroup SET Active=FALSE WHERE GroupID=@groupid");
                    loadGroup();
                    MessageBox.Show("DELETE SUCCESS!");
                }
                catch
                {
                    MessageBox.Show("DELETE FAIL!");
                }
                //MessageBox.Show("ABC");
                //loadGroup();
            }
            
        }

        private void FormGroup_Load(object sender, EventArgs e)
        {
            
            this.btnAdd.Enabled = App.IsAuthorized(Permissions.Manage_Group_Add);
            this.btnUpdate.Enabled = App.IsAuthorized(Permissions.Manage_Group_Edit);
            this.btnDelete.Enabled = App.IsAuthorized(Permissions.Manage_Group_Delete);
        }
    }
}
