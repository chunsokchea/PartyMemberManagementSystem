using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PartyMemberManagementSystem.GUI.Member;
using PartyMemberManagementSystem.Entity;
using System.Collections;

namespace PartyMemberManagementSystem.GUI.Member
{
    
    public partial class FormMemberNE2 : Form
    {
        public Boolean newEdit=false;
        public int memberID;
        public DataTable dtm;
        public int villageID;
        public FormMemberNE2()
        {
            InitializeComponent();
            //loadVillage();
            loadRole();
            loadSex();
            loadVillage();
            loadFamilyStatus();
            loadStation();
        }

        private void loadData()
        {
            
            try
            {
                Cmd.Parameters["@id"] = memberID;
                dtm = Cmd.ExecuteDataTable("SELECT * FROM tblMember WHERE Active=true AND [ID]=@id");

                txtName.Text = dtm.Rows[0]["Name"].ToString();
                cboSex.SelectedValue = dtm.Rows[0]["SexID"];
                dtpDob.Value = (DateTime)dtm.Rows[0]["Dob"];
                txtjob.Text = dtm.Rows[0]["Job"].ToString();
                cbMember.Checked = (Boolean)dtm.Rows[0]["CardID"];
                txtMemberID.Text = dtm.Rows[0]["CardIDNo"].ToString();
                cbSeen.Checked = (Boolean)dtm.Rows[0]["CensusSeen"];
                if ((Boolean)dtm.Rows[0]["Migration"] == true)
                {
                    radioOut.Checked = true;
                }
                else
                {
                    radioIn.Checked = true;
                }
                if ((int)dtm.Rows[0]["MigrationID"] == 2)
                {
                    radioOutNation.Checked = true;
                }
                else
                {
                    radioInNation.Checked = true;
                }
                txtOutAdr.Text = dtm.Rows[0]["MigrationDetail"].ToString();
                txtAddress.Text = dtm.Rows[0]["Address"].ToString();
                cbPeopleID.Checked = (Boolean)dtm.Rows[0]["PeopleID"];
                txtPeopleID.Text = dtm.Rows[0]["PeopleIDNo"].ToString();
                
                if (cbMember.Checked)
                {
                    dtpDatein.Value = (DateTime)dtm.Rows[0]["DateIn"];
                }                
                cbVote.Checked = (Boolean)dtm.Rows[0]["VoteRegister"];
                //txtVoteStation.Text = dtm.Rows[0]["VoteStation"].ToString();
                cboVoteStation.SelectedValue = dtm.Rows[0]["StationID"];
                //txtVoteStationNo.Text = dtm.Rows[0]["VoteStationNo"].ToString();
                cboVoteStationNo.SelectedValue = dtm.Rows[0]["StationNoID"];
                cboRole.SelectedValue = (int) dtm.Rows[0]["RoleId"];
                txtdetail.Text = dtm.Rows[0]["Detail"].ToString();
                //txtFamilyStatus.Text= dtm.Rows[0]["FamilyStatus"].ToString();
                cboFamilyStatus.SelectedValue = dtm.Rows[0]["StatusID"].ToString();

                try
                {                    
                    System.IO.FileStream fs = default(System.IO.FileStream);                    
                    fs = new System.IO.FileStream(Application.StartupPath + "\\photo\\" + dtm.Rows[0]["Photo"].ToString(), System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    memberPhoto.Image = System.Drawing.Image.FromStream(fs);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Photo!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
            
        }

        private void loadVillage()
        {
            string sql = "SELECT * FROM tblVillage where active=true";
            DataTable dtv = new DataTable();
            dtv = Cmd.ExecuteDataTable(sql);
            cboVillage.DisplayMember = "VillageName";
            cboVillage.ValueMember = "VillageID";
            cboVillage.DataSource = dtv;
        }

        private void btnphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                this.memberPhoto.Image = System.Drawing.Image.FromFile(ofd.FileName);                
                lblImagePath.Text = ofd.FileName;
            }
        }

        private void cbPeopleID_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPeopleID.Checked == false)
            {
                txtPeopleID.Enabled = false;
                txtPeopleID.Clear();
            }
            else
            {
                txtPeopleID.Enabled = true;
            }
        }

        private void cbMember_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMember.Checked == false)
            {
                txtMemberID.Enabled = false;
                txtMemberID.Clear();               
                dtpDatein.Visible = false;
            }
            else
            {
                txtMemberID.Enabled = true;
                dtpDatein.Visible = true;
            }
        }

        private void cbVote_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVote.Checked == true)
            {
                gbVoteInfo.Visible = true;
            }
            else
            {
                gbVoteInfo.Visible = false;
            }
        }

        private void radioIn_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxOut.Visible = false;
            //groupBox1.Width = 280;
        }

        private void radioOut_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxOut.Visible = true;
            //groupBox1.Width = 622;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            //FormFamilyNE.memberList.Add(new Members("name", 1, DateTime.Today, "Job", true, "CardIDNo", true, true, 1, "MigrationDetail", "Address", true, "IDNO", DateTime.Today, true, "VoteStation", "VoteStationNo", 1, "Detail", "PhotoPath", "FamilyStatus", 1));
            if (validation() == true)
            {
                return;
            }           
            
            DialogResult = DialogResult.OK;
        }
        private void loadRole()
        {
            DataTable dtr = new DataTable();
            dtr = Cmd.ExecuteDataTable("Select * from tblRole where active=true");
            cboRole.DisplayMember = "RoleName";
            cboRole.ValueMember = "RoleId";
            cboRole.DataSource = dtr;
        }
        private void loadSex()
        {
            DataTable dts = new DataTable();
            dts = Cmd.ExecuteDataTable("Select * from tblSex");
            cboSex.DisplayMember = "SexName";
            cboSex.ValueMember = "SexId";
            cboSex.DataSource = dts;
        }
        private Boolean validation()
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Name cannot be empty!");
                txtName.Focus();
                //
                return true;
            }
            else if (txtjob.Text.Trim() == "")
            {
                MessageBox.Show("Job cannot be empty!");
                txtjob.Focus();
                return true;
            }
            //else if (txtAddress.Text.Trim() == "")
            //{
            //    MessageBox.Show("Address cannot be empty!");
            //    txtAddress.Focus();
            //    return true;
            //}
            //else if(txtFamilyStatus.Text.Trim() =="")
            //{
            //    MessageBox.Show("This Field cannot be empty!");
            //    txtFamilyStatus.Focus();
            //    return true;
            //}
            //else if (txtPartyFamilyNo.Text.Trim() == "")
            //{
            //    MessageBox.Show("This Field cannot be empty!");
            //    txtPartyFamilyNo.Focus();
            //    return true;
            //}
            else
            {
                return false;
            }

        }

        private void loadFamilyStatus()
        {
            DataTable dt = new DataTable();
            dt = Cmd.ExecuteDataTable("SELECT StatusID, StatusName FROM tblFamilyStatus WHERE Active=true");
            cboFamilyStatus.ValueMember = "StatusID";
            cboFamilyStatus.DisplayMember = "StatusName";
            cboFamilyStatus.DataSource = dt;
        }

        private void loadStation()
        {
            DataTable dt = new DataTable();
            dt = Cmd.ExecuteDataTable("SELECT StationID, StationName FROM tblVoteStation WHERE Active=true");
            cboVoteStation.ValueMember = "StationID";
            cboVoteStation.DisplayMember = "StationName";
            cboVoteStation.DataSource = dt;
        }

        private void loadStationNo(int sId)
        {
            DataTable dtsn = new DataTable();
            Cmd.Parameters["@sId"] = sId;
            dtsn = Cmd.ExecuteDataTable("SELECT StationNoID, StationNoName FROM tblStationNo WHERE Active=true AND StationID=@sId");
            cboVoteStationNo.ValueMember = "StationNoID";
            cboVoteStationNo.DisplayMember = "StationNoName";
            cboVoteStationNo.DataSource = dtsn;
        }
        private void FormMemberNE2_Load(object sender, EventArgs e)
        {
            if (newEdit == false)
            {
                loadData();
            }
            else cboVillage.SelectedValue = villageID;
        }

        private void cboVoteStation_SelectedIndexChanged(object sender, EventArgs e)
        {

            //loadStationNo(1);
            if (cboVoteStation.Items.Count>0)
            {
                loadStationNo((int)cboVoteStation.SelectedValue);
            }
            //(int)cboVoteStation.SelectedValue
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cboVoteStationNo.Text);
        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {
            lblAge.Text = CalculateAge(dtpDob.Value.Date).ToString();
        }
        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }  
    }
}
