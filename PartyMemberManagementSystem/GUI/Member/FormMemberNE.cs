using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace PartyMemberManagementSystem.GUI.Member
{
    public partial class FormMemberNE : Form
    {
        public Boolean newEdit = true;
        DataTable dtm = new DataTable();
        public int memberid;
        public FormMemberNE()
        {
            InitializeComponent();
            loadSex();
            loadRole();
            //loadVillage();
            cboRole.SelectedValue = 3;
        }
        private void loadVillage()
        {
            var sql = "SELECT * FROM tblVillage where active=true";
            var dtv = new DataTable();
            dtv = Cmd.ExecuteDataTable(sql);
            cboVillage.DisplayMember = "VillageName";
            cboVillage.ValueMember = "VillageID";
            cboVillage.DataSource = dtv;
        }
        //private void loadGroupByVillage()
        //{
        //    Cmd.Parameters["@villageid"]=cboVillage.SelectedValue;
        //    string sql = "SELECT * FROM tblGroup WHERE VillageID=@villageid";
        //    DataTable dtg = new DataTable();
        //    dtg = Cmd.ExecuteDataTable(sql);
        //    cboGroup.DisplayMember = "GroupName";
        //    cboGroup.ValueMember = "GroupID";
        //    cboGroup.DataSource = dtg; 
        //}
        private void loadRole()
        {
            var dtr = new DataTable();
            dtr = Cmd.ExecuteDataTable("Select * from tblRole where active=true");
            cboRole.DisplayMember = "RoleName";
            cboRole.ValueMember = "RoleId";
            cboRole.DataSource = dtr;
        }
        private void loadSex()
        {
            var dts = new DataTable();
            dts = Cmd.ExecuteDataTable("Select * from tblSex");
            cboSex.DisplayMember = "SexName";
            cboSex.ValueMember = "SexId";
            cboSex.DataSource = dts;
        }

        private void radioOut_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxOut.Visible = true;
            groupBox1.Width = 622;
        }

        private void radioIn_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxOut.Visible = false;
            groupBox1.Width = 280;
        }

        private void btnphoto_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                this.memberPhoto.Image = System.Drawing.Image.FromFile(ofd.FileName);
                //pic = 1;
                //PictureBox2.Visible = false;
                //PictureBox1.Visible = true;
                lblImagePath.Text = ofd.FileName;
            }
        }

        private void loadMember()
        {
            Cmd.Parameters["@memberid"]=memberid;
            var sql = "SELECT * FROM tblMember WHERE ID=@memberid";
            dtm = Cmd.ExecuteDataTable(sql);     
            txtName.Text = dtm.Rows[0]["Name"].ToString();
            cboSex.SelectedValue=(int)dtm.Rows[0]["SexID"];
            dtpDob.Value = (DateTime)dtm.Rows[0]["Dob"];
            txtjob.Text = dtm.Rows[0]["Job"].ToString();
            //dtm.Rows[0]["MemberCardID"] = true ? cbMember.Checked=true : cbMember.Checked = false;
            cbMember.Checked = (Boolean)dtm.Rows[0]["CardID"];
            txtMemberID.Text = dtm.Rows[0]["CardIDNo"].ToString();
            cbSeen.Checked = (Boolean)dtm.Rows[0]["CensusSeen"];
            if ((Boolean)dtm.Rows[0]["Migration"] == true)
            {
                radioOut.Checked = true;
            }
            else
            {
                radioIn.Checked=true;
            }
            if ((int)dtm.Rows[0]["MigrationID"] == 2)
            {
                radioOutNation.Checked = true;
                
            }
            else
            {
                radioInNation.Checked = true;
            }
            //Cmd.Parameters["@groupNo"] = dtm.Rows[0]["GroupNo"];
            //cboVillage.SelectedValue = Cmd.ExecuteScalar("SELECT v.villageid FROM tblVillage v  WHERE v.GroupNo=@groupNo");
            cboVillage.SelectedValue = dtm.Rows[0]["VillageID"];
            txtGroupNo.Text = dtm.Rows[0]["GroupNo"].ToString();
            cboRole.SelectedValue = dtm.Rows[0]["RoleID"];
            //dtm.Rows[0]["Migration"] = true ? radioOut.Checked : radioOut.Checked=false;
            //dtm.Rows[0]["MigrationID"] = true ? radioInNation.Checked = true : radioInNation.Checked = false;
            txtOutAdr.Text = dtm.Rows[0]["MigrationDetail"].ToString();
            txtAddress.Text = dtm.Rows[0]["Address"].ToString();
            cbPeopleID.Checked = (Boolean)dtm.Rows[0]["PeopleID"];
            txtPeopleID.Text = dtm.Rows[0]["PeopleIDNo"].ToString();
            dtpDatein.Value = (DateTime)dtm.Rows[0]["DateIn"];
            cbVote.Checked = (Boolean)dtm.Rows[0]["VoteRegister"];
            txtdetail.Text = dtm.Rows[0]["Detail"].ToString();
            txtVoteStation.Text = dtm.Rows[0]["VoteStation"].ToString();
            txtVoteStationNo.Text = dtm.Rows[0]["VoteStationNo"].ToString();
            try
            {                
                var fs = default(System.IO.FileStream);                
                fs = new System.IO.FileStream(Application.StartupPath + "\\PHOTO\\" + dtm.Rows[0]["PHOTO"].ToString(), System.IO.FileMode.Open, System.IO.FileAccess.Read);
                memberPhoto.Image = System.Drawing.Image.FromStream(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Photo!"); 
            }
            

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
            else if (txtjob.Text.Trim()=="")
            {
                MessageBox.Show("Job cannot be empty!");
                txtjob.Focus();
                return true;
            }
            else if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Address cannot be empty!");
                txtAddress.Focus();
                return true;
            }
            else
            {
                return false;
            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (newEdit == true)
                {
                    //MessageBox.Show("Add");
                    if (validation() == true)
                    {
                        return;
                    }
                    //string fpphoto = txtName.Text.Trim() + ".bmp";
                    Cmd.Parameters["@groupNo"]=txtGroupNo.Text.Trim();
                    Cmd.Parameters["@name"]=txtName.Text.Trim();
                    Cmd.Parameters["@sex"]=cboSex.SelectedValue;
                    Cmd.Parameters["@dob"]=dtpDob.Value;
                    Cmd.Parameters["@job"]=txtjob.Text.Trim();
                    Cmd.Parameters["@membercard"] = cbMember.Checked ? true : false;
                    Cmd.Parameters["@membercardid"] = txtMemberID.Text.Trim();
                    Cmd.Parameters["@seen"] = cbSeen.Checked ? true : false;
                    Cmd.Parameters["@migration"] = radioIn.Checked ? false : true;
                    Cmd.Parameters["@migrationout"] = radioInNation.Checked ? 1 : 2;
                    Cmd.Parameters["@migrationdetail"]=txtOutAdr.Text.Trim();
                    Cmd.Parameters["@address"]=txtAddress.Text.Trim();
                    Cmd.Parameters["@peopleid"] = cbPeopleID.Checked ? true : false;
                    Cmd.Parameters["@peopleidno"] = txtPeopleID.Text.Trim();

                    if (cbMember.Checked == true)
                    {
                        Cmd.Parameters["@datein"] =  dtpDatein.Value;
                    }
                    else
                    {
                        Cmd.Parameters["@datein"] = null;
                    }
                    
                    
                    Cmd.Parameters["@vote"] = cbVote.Checked ? true : false;
                    Cmd.Parameters["@role"]=cboRole.SelectedValue;
                    Cmd.Parameters["@detail"] = txtdetail.Text.Trim();
                    Cmd.Parameters["@photo"] =  memberPhoto.Image != null ? txtName.Text.Trim() + dtpDob.Value.ToString("ddMMyyy") + ".jpg" : "";
                    Cmd.Parameters["@station"]=txtVoteStation.Text;
                    Cmd.Parameters["@stationno"]=txtVoteStationNo.Text;
                    Cmd.Parameters["@VillageID"]=cboVillage.SelectedValue;
                    var sql= @"INSERT INTO tblMember
                                    ([GroupNo],[Name],[SexID],[Dob],[Job],[CardID],[CardIDNo],[CensusSeen],[Migration],[MigrationID],[MigrationDetail],[Address],[PeopleID],[PeopleIDNo],[DateIn],[VoteRegister],[RoleID],[Detail],[Photo],[VoteStation],[VoteStationNo],[VillageID])
                                    VALUES(@groupNo,@name,@sex,@dob,@job,@membercard,@membercardid,@seen,@migration,@migrationout,@migrationdetail,@address,@peopleid,@peopleidno,@datein,@vote,@role,@detail,@photo,@station,@stationno,@VillageID)
                                ";
                    Cmd.ExecuteNonQuery(sql);
                    //Boolean A = radioIn.Checked ? true : false;
                    //MessageBox.Show("Add" + cbVote.CheckState);
                    MessageBox.Show("INSERT SUCCESS!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (validation() == true)
                    {
                        return;
                    }
                    Cmd.Parameters["@VillageID"]=cboVillage.SelectedValue;
                    Cmd.Parameters["@groupNo"] = txtGroupNo.Text;
                    Cmd.Parameters["@name"] = txtName.Text.Trim();
                    Cmd.Parameters["@sex"] = cboSex.SelectedValue;
                    Cmd.Parameters["@dob"] = dtpDob.Value;
                    Cmd.Parameters["@job"] = txtjob.Text.Trim();
                    Cmd.Parameters["@membercard"] = cbMember.Checked ? true : false;
                    Cmd.Parameters["@membercardid"] = txtMemberID.Text.Trim();
                    Cmd.Parameters["@seen"] = cbSeen.Checked ? true : false;
                    Cmd.Parameters["@migration"] = radioIn.Checked ? false : true;
                    Cmd.Parameters["@migrationout"] = radioInNation.Checked ? 1 : 2;
                    Cmd.Parameters["@migrationdetail"] = txtOutAdr.Text.Trim();
                    Cmd.Parameters["@address"] = txtAddress.Text.Trim();
                    Cmd.Parameters["@peopleid"] = cbPeopleID.Checked ? true : false;
                    Cmd.Parameters["@peopleidno"] = txtPeopleID.Text.Trim();
                    Cmd.Parameters["@datein"] = dtpDatein.Value;
                    Cmd.Parameters["@vote"] = cbVote.Checked ? true : false;
                    Cmd.Parameters["@role"] = cboRole.SelectedValue;
                    Cmd.Parameters["@detail"] = txtdetail.Text.Trim();
                    Cmd.Parameters["@photo"] = memberPhoto.Image != null ? txtName.Text.Trim() + dtpDob.Value.ToString("ddMMyyy") + ".jpg" : dtm.Rows[0]["Photo"].ToString();
                    Cmd.Parameters["@station"] = txtVoteStation.Text;
                    Cmd.Parameters["@stationno"] = txtVoteStationNo.Text;
                    Cmd.Parameters["@id"] = memberid;
                    var sql = @"UPDATE tblMember                                    
                                   SET VillageID=@VillageID, GroupNo=@groupNo, [Name]=@name, SexID=@sex, [Dob]=@dob, [Job]=@job, 
                                        CardID=@membercard, CardIDNo=@membercardid, CensusSeen=@seen, Migration=@migration,
                                        MigrationID=@migrationout, MigrationDetail=@migrationdetail, [Address]=@address, PeopleID=@peopleid,
                                        PeopleIDNo=@peopleidno, DateIn=@datein, VoteRegister=@vote, RoleID=@role, Detail=@detail, Photo=@photo,
                                        VoteStation=@station, VoteStationNo=@stationno
                                        WHERE [ID]=@id
                                 ";
                    Cmd.ExecuteNonQuery(sql);
                    MessageBox.Show("UPDATE SUCCESS!");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return;
            }
            if (lblImagePath.Text != "") {
                try
                {                   
                    memberPhoto.Image.Save(Application.StartupPath + "\\photo\\" + txtName.Text.Trim() + dtpDob.Value.ToString("ddMMyyy") + ".jpg", ImageFormat.Jpeg);
                }
                catch (Exception ex)
                {
                    //throw;
                }
                
            }
            this.Close();
        }

        private void cboVillage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loadGroupByVillage();
        }

        private void FormMemberNE_Load(object sender, EventArgs e)
        {
            loadVillage();
            if (newEdit != true)
            {
                loadMember();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //loadMember();
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
                //dtpDatein.Enabled = false;
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

        private void memberPhoto_Click(object sender, EventArgs e)
        {

        }

        private void txtdetail_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioInNation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioOutNation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbSeen_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
