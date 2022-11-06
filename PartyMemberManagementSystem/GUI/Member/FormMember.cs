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
    public partial class FormMember : Form
    {
        DataTable dtm = new DataTable();
        public FormMember()
        {
            InitializeComponent();
            loadMember();
            loadVillageCount();
            btnUpdate.Click += dgvList_DoubleClick;
            
        }

        private void loadMember()
        {

            var dtm = new DataTable();
            dtm = Cmd.ExecuteDataTable("SELECT * FROM qrMemberInfor WHERE Active = true");
            dgvList.DataSource = dtm;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            loaMemberFilter();
        }

        private void loaMemberFilter()
        {
            
            if (radioName.Checked)
            {
                Cmd.Parameters["@search"] = "%" + txtsearch.Text + "%";
                dtm = Cmd.ExecuteDataTable("SELECT * FROM qrMemberInfor WHERE [Name] LIKE @search AND Active = true ");
                dgvList.DataSource = dtm;
            }
            else if (radioVillage.Checked)
            {
                Cmd.Parameters["@search"] = "%" + txtsearch.Text + "%";
                dtm = Cmd.ExecuteDataTable("SELECT * FROM qrMemberInfor WHERE [VillageName] LIKE @search AND Active = true ");
                dgvList.DataSource = dtm;
            }
            else if (radioGroup.Checked)
            {
                Cmd.Parameters["@search"] = "%" + txtsearch.Text + "%";
                dtm = Cmd.ExecuteDataTable("SELECT * FROM qrMemberInfor WHERE [GroupNo] LIKE @search AND Active = true ");
                dgvList.DataSource = dtm;
            }
            else if (radioRole.Checked)
            {
                Cmd.Parameters["@search"] = "%" + txtsearch.Text + "%";
                dtm = Cmd.ExecuteDataTable("SELECT * FROM qrMemberInfor WHERE [Role] LIKE @search AND Active = true ");
                dgvList.DataSource = dtm;
            }
            else if (radioAge.Checked)
            {
                Cmd.Parameters["@search"] = "%" + txtsearch.Text + "%";
                dtm = Cmd.ExecuteDataTable("SELECT * FROM qrMemberInfor WHERE [Age] LIKE @search AND Active = true ");
                dgvList.DataSource = dtm;
            }
            cboall.Checked = true;
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

        private void FormMember_Load(object sender, EventArgs e)
        {
            //btnDelete.Click += dgvList_DoubleClick;
            this.btnAdd.Enabled = App.IsAuthorized(Permissions.List_Member_add);
            this.btnUpdate.Enabled = App.IsAuthorized(Permissions.List_Member_Edit);
            this.btnDelete.Enabled = App.IsAuthorized(Permissions.List_Member_Delete);
            loadTotalCount();
            loadVillageCbo();
            //cboCondition.SelectedIndex = 0;
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
        private void loadGroupCbo()
        {
            var sql = "SELECT * FROM tblGroup";
            var dtv = new DataTable();
            dtv = Cmd.ExecuteDataTable(sql);
            cboCondition.DisplayMember = "GroupName";
            cboCondition.ValueMember = "GroupID";
            cboCondition.DataSource = dtv;

        }

        private void loadVillageCount()
        {
            var sql = "SELECT * FROM qrCountByVillage";
            var dtvc = new DataTable();     
            dtvc=Cmd.ExecuteDataTable(sql);
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
            var frm = new FormMemberNE();
            frm.memberid = (int)row.Cells["MemberId"].Value;
            frm.newEdit = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.txtsearch.Clear();
                loadMember();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var row = default(DataGridViewRow);
            row = dgvList.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }
            //MessageBox.Show(row.Cells["MemberId"].Value+"");
            if (MessageBox.Show("YOU REAL WANT TO DELETE (" + row.Cells["MemberName"].Value + ")!","DELETE MEMBER",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Cmd.Parameters["@id"] = row.Cells["MemberId"].Value;
                    var sql = "UPDATE tblMember SET Active=FALSE WHERE ID=@id";
                    Cmd.ExecuteNonQuery(sql);
                    MessageBox.Show("DELETE SUCCESS!");
                }
                catch
                {
                    MessageBox.Show("DELETE FAIL!");
                }
                //MessageBox.Show("ABC");
                loadMember();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FormMemberNE();
            frm.newEdit = true;
            frm.ShowDialog();

        }

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

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsearch.Text = "";
            if (cboall.Checked==true)
            {
                return;
            }
            if (cboCondition.SelectedIndex==0)
            {
                Cmd.Parameters["@VillageID"]=cboVillage.SelectedValue;
                var sql = "SELECT * FROM qrMemberInfor WHERE Active = true AND PeopleID=True AND VillageID=@VillageID";
                dtm = Cmd.ExecuteDataTable(sql);
                dgvList.DataSource = dtm;

            }else if (cboCondition.SelectedIndex==1)
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
            } else 
            {
                Cmd.Parameters["@VillageID"] = cboVillage.SelectedValue;
                var sql = "SELECT * FROM qrMemberInfor WHERE Active = true AND Migration=True AND MigrationID=2 AND VillageID=@VillageID";
                dtm = Cmd.ExecuteDataTable(sql);
                dgvList.DataSource = dtm;
            }
        }
    }
}
