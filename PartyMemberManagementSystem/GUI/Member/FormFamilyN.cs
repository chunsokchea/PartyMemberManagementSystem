using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using PartyMemberManagementSystem.Entity;
using System.IO;
using System.Drawing.Imaging;

namespace PartyMemberManagementSystem.GUI.Member
{
    public partial class FormFamilyN : Form
    {
       // ArrayList memberList = new ArrayList();
        public int villageId;
        List<Members> partyMember = new List<Members>();
        List<Members> emptypartyMember = new List<Members>();
        public FormFamilyN()
        {
            InitializeComponent();
            loadVillage();
            formatgridImage();
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

        private void dgvFamilyMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        //private ArrayList GetMember()
        //{
           
        //    memberList.Add(new Members("name", 1, DateTime.Today, "Job", true, "CardIDNo", true, true, 1, "MigrationDetail", "Address", true, "IDNO", DateTime.Today, true, "VoteStation", "VoteStationNo", 1, "Detail", "PhotoPath", "FamilyStatus", 1));
        //    return memberList;
        //}

        //private ArrayList GetMember2()
        //{

        //    memberList.Add(new Members("name", 1, DateTime.Today, "Job", true, "CardIDNo", true, true, 1, "MigrationDetail", "Address", true, "IDNO", DateTime.Today, true, "VoteStation", "VoteStationNo", 1, "Detail", "PhotoPath", "FamilyStatus", 1));
        //    return memberList;
        //}

        public static string sexName;
        public static string roleName;
        private void btnNewMember_Click(object sender, EventArgs e)
        {                   
            var frm = new FormMemberNE2();
            frm.newEdit = true;
            frm.villageID = (int) cboVillage.SelectedValue;
            frm.txtGroupNo.Text = this.txtGroupNo.Text;
            frm.txtFamilyBookNo.Text = this.txtFamilyBookNo.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var migrationInOut = 0;
                if (frm.radioInNation.Checked)
                {
                    migrationInOut = 1;
                }
                else migrationInOut = 2;

                //MemoryStream ms = new MemoryStream();
                //frm.memberPhoto.Image.Save(ms, frm.memberPhoto.Image.RawFormat);
                //byte[] img = ms.ToArray();
                //pictureBox1.Image = frm.memberPhoto.Image;
                //migrationInOut = frm.radioInNation.Checked ? 1 : 2;
                //memberList.Add(new Members("name", 1, DateTime.Today, "Job", true, "CardIDNo", true, true, 1, "MigrationDetail", "Address", true, "IDNO", DateTime.Today, true, "VoteStation", "VoteStationNo", 1, "Detail", "PhotoPath", "FamilyStatus"));
                
                try
                {
                    //Bitmap img;
                    //img = new Bitmap(frm.lblImagePath.Text);                   
                    
                    var img = frm.memberPhoto.Image;
                    var sexID =  (int)frm.cboSex.SelectedValue;
                    var sexName = (sexID == 1) ? "ប្រុស" : "ស្រី";
                    var roleID = (int)frm.cboRole.SelectedValue;
                    string roleName;

                    var voteStationID = (int)frm.cboVoteStation.SelectedValue;
                    var voteStation = frm.cboVoteStation.Text;

                    var voteStationNoID = (int)frm.cboVoteStationNo.SelectedValue;
                    var voteStationNo = frm.cboVoteStationNo.Text;

                    var familyStatusID = (int)frm.cboFamilyStatus.SelectedValue;
                    var familyStatus = frm.cboFamilyStatus.Text;

                    //if (frm.cbVote.Checked == true)
                    //{
                    //    voteStationID = (int)frm.cboVoteStation.SelectedValue;
                    //    voteStation = frm.cboVoteStation.Text;
                    //    voteStationNoID = (int)frm.cboVoteStationNo.SelectedValue;
                    //    voteStationNo = frm.cboVoteStationNo.Text;
                    //    familyStatusID = (int)frm.cboFamilyStatus.SelectedValue;
                    //    familyStatus = frm.cboFamilyStatus.Text;
                    //}
                    //else
                    //{
                    //    voteStationID = null;
                    //    voteStation = frm.cboVoteStation.Text;
                    //    voteStationNoID = (int)frm.cboVoteStationNo.SelectedValue;
                    //    voteStationNo = frm.cboVoteStationNo.Text;
                    //    familyStatusID = (int)frm.cboFamilyStatus.SelectedValue;
                    //    familyStatus = frm.cboFamilyStatus.Text;
                    //}

                    if (roleID==1)
                    {
                        roleName = "ប្រធានក្រុម";
                    } else if(roleID==2)
                    {
                        roleName = "អនុប្រធានក្រុម";
                    }else{
                        roleName = "សមាជិក";
                    }
                    var registerMember = frm.cbMember.Checked ? true : false;
                    var seen = frm.cbSeen.Checked ? true : false;
                    var migration = frm.radioIn.Checked ? false : true;
                    var peopleID = frm.cbPeopleID.Checked ? true : false;
                    var voteRegister = frm.cbVote.Checked ? true : false;
                    //memberList.Add(new Members("name", 1, DateTime.Today, "Job", true, "CardIDNo", true, true, 1, "MigrationDetail", "Address", true, "IDNO", DateTime.Today, true, "VoteStation", "VoteStationNo", 1, "Detail", "PhotoPath", "FamilyStatus", "", "", ""));
                    //partyMember.Add(new Members(frm.txtName.Text, 1, frm.dtpDob.Value, frm.txtjob.Text, true, frm.txtMemberID.Text, true, true, 1, frm.txtOutAdr.Text, frm.txtAddress.Text, true, frm.txtPeopleID.Text, frm.dtpDatein.Value, true, frm.txtVoteStation.Text, frm.txtVoteStationNo.Text, 2, frm.txtdetail.Text, frm.lblImagePath.Text, "", "", "", ""));
                    partyMember.Add(new Members(frm.txtName.Text, sexID, frm.dtpDob.Value, frm.txtjob.Text, registerMember, frm.txtMemberID.Text, seen, migration, migrationInOut, frm.txtOutAdr.Text, frm.txtAddress.Text, peopleID, frm.txtPeopleID.Text, frm.dtpDatein.Value, voteRegister, voteStationID, voteStationNoID, roleID, frm.txtdetail.Text, frm.lblImagePath.Text, familyStatusID, sexName, roleName, (migrationInOut == 1) ? "ក្នុងស្រុក" : "ក្រៅស្រុក", img, voteStation, voteStationNo, familyStatus));
                    loadDataMember();
                    for (var i=0; i<dgvFamilyMember.Rows.Count; i++)
                    {
                        dgvFamilyMember.Rows[i].Cells["Age"].Value=CalculateAge((DateTime)dgvFamilyMember.Rows[i].Cells["Dob"].Value);
                    }
                    //MessageBox.Show(familyStatusID+" : "+ familyStatus);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //throw;
                }
                
                
                dgvFamilyMember.Refresh();
            }
           
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            var age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }  

        private void formatgridImage()
        {
            //DataGridViewImageColumn photoColumn = new DataGridViewImageColumn();
            //photoColumn.DataPropertyName = "Photo";
            //photoColumn.Width = 200;
            //photoColumn.HeaderText = "Image";
            //photoColumn.ReadOnly = true;
            //photoColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            //dgvFamilyMember.Columns.Add(photoColumn);             
            dgvFamilyMember.RowTemplate.Height=120;
        }
        private void loadDataMember()
        {
            //while (dgvFamilyMember.RowCount > 1)
            //{
            //    dgvFamilyMember.Rows.RemoveAt(0);
            //}
            //dgvFamilyMember.DataSource = null;            
            
            try
            {
                //dgvFamilyMember.DataSource = null;
                dgvFamilyMember.DataSource = emptypartyMember;
                //dgvFamilyMember.Rows.Clear();
                //dgvFamilyMember.Refresh();

                dgvFamilyMember.DataSource = partyMember;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()+"");
                //throw;
                //dgvFamilyMember.DataSource = emptypartyMember;
            }
            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {           
           // Members mem = new Members();
            //memberList.Add(mem.Name="Boomer",mem.Sex="Male",mem.Dob=DateTime.Now);
            //MessageBox.Show(memberList[0]+"");
           // dataGridView1.DataSource = memberList; 
            //MessageBox.Show(""+partyMember.Count);
            //MessageBox.Show(roleName);
            //MessageBox.Show(sexName);
            if(dgvFamilyMember.Rows.Count==0)
            {
                MessageBox.Show("សូមបញ្ចូលសមាជិកគ្រួសារ!!");
                btnNewMember_Click(sender,e);
                return;
            }
            if (cboVillage.ValueMember.Count() == 0)
            {
                MessageBox.Show("សូមបញ្ចូលភូមិសិន!");
                var frm = new FormVillage();
                frm.Show();
                //frm.MdiParent = FormMain();
                loadVillage();
                return;
            }
            if (txtGroupNo.Text.Trim() == "")
            {
                MessageBox.Show("ក្រុមបក្សមិនអាចទទេបានទេ!");
                txtGroupNo.Focus();
                return;
            }

            if (txtFamilyBookNo.Text.Trim() == "")
            {
                MessageBox.Show("លេខសៀវភៅគ្រួសារបក្សមិនអាចទទេបានទេ!");
                txtFamilyBookNo.Focus();
                return;
            }

            Cmd.Begin();

            try
            {

                Cmd.Parameters["@GroupNo"] = txtGroupNo.Text.Trim();
                Cmd.Parameters["@FamilyBookNo"] = txtFamilyBookNo.Text.Trim();
                Cmd.Parameters["@VillageID"] = (int) cboVillage.SelectedValue;
                Cmd.Parameters["@adr"] = txtAddress.Text.Trim();
                Cmd.ExecuteNonQuery("INSERT INTO tblFamily (GroupNo, FamilyBookNo, VillageID,Address, Active) VALUES(@GroupNo, @FamilyBookNo, @VillageID,@adr, true)");
                var familyID =(int) Cmd.ExecuteScalar("SELECT FamilyID FROM tblFamily ORDER BY FamilyID DESC");
                for (var i = 0; i < partyMember.Count; i++)
                {

                    Cmd.Parameters["@groupNo"] = txtGroupNo.Text.Trim();
                    Cmd.Parameters["@name"] = partyMember[i].Name;
                    Cmd.Parameters["@sex"] = partyMember[i].Sex;
                    Cmd.Parameters["@dob"] = partyMember[i].Dob.Date;
                    Cmd.Parameters["@job"] = partyMember[i].Job;
                    Cmd.Parameters["@membercard"] = partyMember[i].CardID;
                    Cmd.Parameters["@membercardid"] = partyMember[i].CardIDNo;
                    Cmd.Parameters["@seen"] = partyMember[i].SencusSeen;
                    Cmd.Parameters["@migration"] = partyMember[i].Migration;
                    Cmd.Parameters["@migrationout"] = partyMember[i].MigrationID;
                    Cmd.Parameters["@migrationdetail"] = partyMember[i].MigrationDetail;
                    Cmd.Parameters["@address"] = partyMember[i].Address;
                    Cmd.Parameters["@peopleid"] = partyMember[i].PeopleID;
                    Cmd.Parameters["@peopleidno"] = partyMember[i].PeopleIDNo;

                    //if (partyMember[i].DateIn.Date!=DateTime.Now.Date)
                    //{
                    //    Cmd.Parameters["@datein"] = partyMember[i].DateIn;
                    //}
                    //else
                    //{
                    //    Cmd.Parameters["@datein"] = null;
                    //}

                    Cmd.Parameters["@datein"] = partyMember[i].DateIn.Date;

                    Cmd.Parameters["@vote"] = partyMember[i].VoteRegister;
                    Cmd.Parameters["@role"] = partyMember[i].RoleID;
                    Cmd.Parameters["@detail"] = partyMember[i].Detail;
                    Cmd.Parameters["@photo"] = partyMember[i].Name + partyMember[i].Dob.ToString("ddMMyyy") + ".jpg";
                    Cmd.Parameters["@station"] = partyMember[i].VoteStation;
                    Cmd.Parameters["@stationno"] = partyMember[i].VoteStationNo;                    
                    
                    //Cmd.Parameters["@station"] = null;
                    //Cmd.Parameters["@stationno"] = null;

                    Cmd.Parameters["@VillageID"] = (int)cboVillage.SelectedValue;
                    Cmd.Parameters["@familyStatus"] = partyMember[i].FamilyStatus;
                    Cmd.Parameters["@familyID"] = familyID;
                    var sql = @"INSERT INTO tblMember
                                    ([GroupNo],[Name],[SexID],[Dob],[Job],[CardID],[CardIDNo],[CensusSeen],[Migration],[MigrationID],[MigrationDetail],[Address],
                                    [PeopleID],[PeopleIDNo],[DateIn],[VoteRegister],[RoleID],[Detail],[Photo],[StationID],[StationNoID],[VillageID],
                                    [StatusID],[FamilyID])

                                    VALUES(@groupNo,@name,@sex,@dob,@job,@membercard,@membercardid,@seen,@migration,@migrationout,@migrationdetail,@address,
                                    @peopleid,@peopleidno,@datein,@vote,@role,@detail,@photo,@station,@stationno,@VillageID,@familyStatus,@familyID)
                                ";
//                    string sql2 = @"INSERT INTO tblMember
//                                    ([GroupNo],[Name],[SexID],[Dob],[Job],[CardID],[CardIDNo],[CensusSeen],[Migration],[MigrationID],[MigrationDetail],[Address],
//                                    [PeopleID],[PeopleIDNo],[DateIn],[VoteRegister],[RoleID],[Detail],[Photo],[StationID],[StationNoID],[VillageID],
//                                    [StatusID],[FamilyID])
//
//                                    VALUES(@groupNo,@name,@sex,@dob,@job,@membercard,@membercardid,@seen,@migration,@migrationout,@migrationdetail,@address,
//                                                        @peopleid,@peopleidno,@datein,@vote,@role,@detail,@photo,@station,@stationno,@VillageID,@familyStatus,@familyID)
//                                ";
                    Cmd.ExecuteNonQuery(sql);
                    partyMember[i].Photo.Save(Application.StartupPath + "\\photo\\" + partyMember[i].Name + partyMember[i].Dob.ToString("ddMMyyy") + ".jpg", ImageFormat.Jpeg);
                }
                MessageBox.Show("បញ្ចូលទិន្ន័យបានសម្រេច!");
                Cmd.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                Cmd.Rollback();
                //MessageBox.Show("Error!");
                //return;
               // throw;
            }

            this.DialogResult = DialogResult.OK;
            //this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(partyMember.Count()+"");
            MessageBox.Show(partyMember[0].FamilyStatusName);
        }
    }
}
