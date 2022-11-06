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
    public partial class FormFamily : Form
    {

        DataTable dtm = new DataTable();

        public FormFamily()
        {
            InitializeComponent();

            //loadMember();
            loadFamily();
            //loadVillageCount();
            loadCountFamily();
            this.btnAdd.Enabled = App.IsAuthorized(Permissions.List_Member_add);
            this.btnUpdate.Enabled = App.IsAuthorized(Permissions.List_Member_Edit);
            this.btnDelete.Enabled = App.IsAuthorized(Permissions.List_Member_Delete);            
            loadTotalCount();
            loadVillageCbo();
            btnUpdate.Click += dgvList_DoubleClick;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FormFamilyN();
            if (frm.ShowDialog() == DialogResult.OK)
            {
               loadFamily();
                //loadMember();
               dgvList.Refresh();
            }
            //frm.ShowDialog();
           // frm.Show();
            //frm.MdiParent=FormMain;
        }

        private void loadFamily()
        {
            var dt = new DataTable();
            dt = Cmd.ExecuteDataTable("SELECT f.*, v.VillageName FROM tblFamily f INNER JOIN tblVillage v ON f.VillageID=v.VillageID WHERE f.Active=true");
            dgvList.DataSource = dt;
        }
        private void loadMember()
        {

            var dtm = new DataTable();
            dtm = Cmd.ExecuteDataTable("SELECT f.* FROM qrFamilyMembers f WHERE f.fActive = true AND (RoleId) = (SELECT MIN(m.RoleId) FROM tblMember m WHERE m.FamilyID=f.FamilyID AND m.Active=true)");
            dgvList.DataSource = dtm;
            //"SELECT * FROM qrMemberInfor WHERE Active = true"
        }

        //private void loadVillageCount()
        //{
        //    string sql = "SELECT * FROM qrCountByVillage";
        //    DataTable dtvc = new DataTable();
        //    dtvc = Cmd.ExecuteDataTable(sql);
        //    dataGridView1.DataSource = dtvc;

        //}

        private void loadCountFamily()
        {
            var sql = "SELECT v.VillageName, (SELECT COUNT(*) FROM tblFamily f WHERE f.VillageID=v.VillageID) AS TotalM FROM tblVillage v WHERE Active = true";
            var dtvc = new DataTable();
            dtvc = Cmd.ExecuteDataTable(sql);
            dataGridView1.DataSource = dtvc;
        }

        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            var row = default(DataGridViewRow);
            row = dgvList.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }
            //FormMemberNE frm = new FormMemberNE();
            //frm.memberid = (int)row.Cells["MemberId"].Value;
            //frm.newEdit = false;
            if (App.IsAuthorized(Permissions.List_Member_Edit) == true)
            {
                try
                {
                    var frm = new FormFamilyE();
                    frm.familyID = (int)row.Cells["FamilyID"].Value;
                    //frm.txtGroupNo.Text = (string)row.Cells["GroupNo"].Value;
                    //frm.txtFamilyBookNo.Text = (string)row.Cells["FamilyBookNo"].Value;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        this.txtsearch.Clear();
                        //loadMember();
                        loadFamily();
                    }
                }
                catch (Exception)
                {
                    
                    throw;
                }                
            }
            else MessageBox.Show("You don't have permission to edit this!");
            
        }
        //"SELECT * FROM qrFamilyMembers WHERE Active = true"
        private void loadTotalCount()
        {
            var dt = new DataTable();
            dt = Cmd.ExecuteDataTable("SELECT * FROM qrCountTotal");
            lblhaveID.Text = dt.Rows[0]["HaveID"].ToString() + "នាក់";
            lblNoId.Text = dt.Rows[0]["NoID"].ToString() + "នាក់";
            lblOutInNation.Text = dt.Rows[0]["MigrationIn"].ToString() + "នាក់";
            lblOutOutNation.Text = dt.Rows[0]["MigrationOut"].ToString() + "នាក់";
            lblTotal.Text = dt.Rows[0]["Total"].ToString() + "នាក់";
            lblWoman.Text = dt.Rows[0]["Woman"].ToString() + "នាក់";
        }

        private void cboall_CheckedChanged(object sender, EventArgs e)
        {
            if (cboall.Checked)
            {
                cboVillage.Visible = false;
                cboCondition.Visible = false;
            }
            else
            {
                cboVillage.Visible = true;
                cboCondition.Visible = true;
            }
        }

        private void loadVillageCbo()
        {
            var sql = "SELECT * FROM tblVillage where active=true";
            var dtv = new DataTable();
            dtv = Cmd.ExecuteDataTable(sql);
            cboVillage.DisplayMember = "VillageName";
            cboVillage.ValueMember = "VillageID";
            cboVillage.DataSource = dtv;

        }
        private void loadConditionCbo()
        {
            var sql = "SELECT * FROM tblGroup";
            var dtv = new DataTable();
            dtv = Cmd.ExecuteDataTable(sql);
            cboCondition.DisplayMember = "GroupName";
            cboCondition.ValueMember = "GroupID";
            cboCondition.DataSource = dtv;

        }

        private void cboCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsearch.Text = "";
            if (cboall.Checked == true)
            {
                return;
            }
            if (cboCondition.SelectedIndex == 0)
            {
                Cmd.Parameters["@VillageID"] = cboVillage.SelectedValue;
                var sql = "SELECT * FROM qrMemberInfor WHERE Active = true AND PeopleID=True AND VillageID=@VillageID";
                dtm = Cmd.ExecuteDataTable(sql);
                dgvList.DataSource = dtm;

            }
            else if (cboCondition.SelectedIndex == 1)
            {
                Cmd.Parameters["@VillageID"] = cboVillage.SelectedValue;
                var sql = "SELECT * FROM qrMemberInfor WHERE Active = true AND PeopleID=False AND VillageID=@VillageID";
                dtm = Cmd.ExecuteDataTable(sql);
                dgvList.DataSource = dtm;
            }
            else if (cboCondition.SelectedIndex == 2)
            {
                Cmd.Parameters["@VillageID"] = cboVillage.SelectedValue;
                var sql = "SELECT * FROM qrMemberInfor WHERE Active = true AND Migration=True AND MigrationID=1 AND VillageID=@VillageID";
                dtm = Cmd.ExecuteDataTable(sql);
                dgvList.DataSource = dtm;
            }
            else
            {
                Cmd.Parameters["@VillageID"] = cboVillage.SelectedValue;
                var sql = "SELECT * FROM qrMemberInfor WHERE Active = true AND Migration=True AND MigrationID=2 AND VillageID=@VillageID";
                dtm = Cmd.ExecuteDataTable(sql);
                dgvList.DataSource = dtm;
            }
        }

        private void loadFamilyFilter()
        {

            if (radioFamilyNo.Checked)
            {
                Cmd.Parameters["@search"] = "%" + txtsearch.Text + "%";
                //DataTable dt = new DataTable();
                dtm = Cmd.ExecuteDataTable("SELECT f.*, v.VillageName FROM tblFamily f INNER JOIN tblVillage v ON f.VillageID=v.VillageID WHERE f.Active=true AND f.FamilyBookNo LIKE @search");
                dgvList.DataSource = dtm;
            }
            else if (radioVillage.Checked)
            {
                Cmd.Parameters["@search"] = "%" + txtsearch.Text + "%";
                dtm = Cmd.ExecuteDataTable("SELECT f.*, v.VillageName FROM tblFamily f INNER JOIN tblVillage v ON f.VillageID=v.VillageID WHERE f.Active=true AND v.VillageName LIKE @search");
                dgvList.DataSource = dtm;
            }
            else if (radioGroup.Checked)
            {
                Cmd.Parameters["@search"] = "%" + txtsearch.Text + "%";
                dtm = Cmd.ExecuteDataTable("SELECT f.*, v.VillageName FROM tblFamily f INNER JOIN tblVillage v ON f.VillageID=v.VillageID WHERE f.Active=true AND f.GroupNo LIKE @search");
                dgvList.DataSource = dtm;
            }
            
            cboall.Checked = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //FormFamilyE frm = new FormFamilyE();
            //frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var row = default(DataGridViewRow);
            row = dgvList.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }

            cmd.Parameters["@fid"] = row.Cells["FamilyID"].Value;
            cmd.ExecuteNonQuery("UPDATE tblFamily SET Active=false WHERE FamilyID=@fid");
            cmd.Parameters["@fid"] = row.Cells["FamilyID"].Value;
            cmd.ExecuteNonQuery("UPDATE tblMember SET Active=false WHERE FamilyID=@fid");
            MessageBox.Show("លុបទិន្ន័យបានសម្រេច!");
            //loadMember();
            loadFamily();
            dgvList.Refresh();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            loadFamilyFilter();
        }

    }
}
