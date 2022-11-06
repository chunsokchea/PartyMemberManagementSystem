using PartyMemberManagementSystem.GUI.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PartyMemberManagementSystem.GUI.Member
{
    public partial class FormFamilyE : Form
    {
        public int familyID;
        public string GroupNo;
        private int vid=0;
        Boolean edit = false;
        public FormFamilyE()
        {
            InitializeComponent();

            formatgridImage();
            //loadFamily();
        }

        private void loadVillagecbo()
        {
            var dtv = new DataTable();
            dtv = Cmd.ExecuteDataTable("SELECT * FROM tblVillage WHERE Active = true");
            cboVillage.DisplayMember = "VillageName";
            cboVillage.ValueMember = "VillageID";
            cboVillage.DataSource = dtv;
        }
        DataTable dtf = new DataTable();
        private void loadFamily()
        {            
            Cmd.Parameters["@fid"]=familyID;
            dtf = Cmd.ExecuteDataTable("SELECT * FROM tblFamily WHERE FamilyID=@fid AND Active=true");
            cboVillage.SelectedValue = (int) dtf.Rows[0]["VillageID"];
            txtFamilyBookNo.Text = (string) dtf.Rows[0]["FamilyBookNo"];
            txtGroupNo.Text = (string) dtf.Rows[0]["GroupNo"];
            txtAddress.Text=(string)dtf.Rows[0]["Address"];
            lblGroupNo.Text = (string)dtf.Rows[0]["GroupNo"]; ;
        }

        private void loadFmember2()
        {
            
                var dtm = new DataTable();
                Cmd.Parameters["@fid"] = familyID;
                var sql = @"SELECT m.ID,m.Name,s.SexName,m.Dob,r.RoleName,f.StatusName,m.CardID,m.CardIDNo,m.VoteRegister,vt.StationName,vtn.StationNoName,m.Photo
                            FROM tblMember m, tblRole r, tblFamilyStatus f, tblVoteStation vt, tblStationNo vtn, tblSex s
                            WHERE m.Active=true AND m.RoleID=r.RoleID AND m.StatusID=f.StatusID AND m.StationID=vt.StationID AND m.StationNoID=vtn.StationNoID
                            AND m.FamilyID=@fid AND m.SexID=s.SexID
                        ";
                dtm = Cmd.ExecuteDataTable(sql);

                for (var i = 0; i < dtm.Rows.Count; i++)
                {
                    var frm = new FormMemberData();

                    frm.memberID = (int)dtm.Rows[i]["ID"];
                    frm.villageID = (int) cboVillage.SelectedValue;
                    frm.groupNo = this.txtGroupNo.Text;
                    frm.familyBookNo = this.txtFamilyBookNo.Text;
                    frm.TopLevel = false;
                    frm.AutoScroll = true;
                    //frm.Dock = DockStyle.Top;
                    //frm.label1.Text = "From" + fn;
                    frm.Width = fpMember.Width-30;
                    var year = Convert.ToDateTime(dtm.Rows[i]["Dob"]);
                    var age=(int)(DateTime.Today.Year - year.Year);
                    frm.lblAge.Text = age.ToString();
                    frm.lblName.Text = dtm.Rows[i]["Name"].ToString();
                    frm.lblSex.Text = dtm.Rows[i]["SexName"].ToString();
                    frm.lblfStatus.Text = dtm.Rows[i]["StatusName"].ToString();
                    frm.lblCardID.Text = (Boolean)dtm.Rows[i]["CardID"] ? "មាន" : "គ្មាន";
                    frm.lblCardIdNo.Text = dtm.Rows[i]["CardIDNo"].ToString();
                    frm.lblCanVote.Text = (Boolean)dtm.Rows[i]["VoteRegister"] ? "បាន" : "មិន";
                    frm.lblVoteStation.Text = dtm.Rows[i]["StationName"].ToString();
                    frm.lblVoteStationNo.Text = dtm.Rows[i]["StationNoName"].ToString();

                    this.fpMember.Controls.Add(frm);

                    try
                    {
                        var fs = default(System.IO.FileStream);
                        fs = new System.IO.FileStream(Application.StartupPath + "\\photo\\" + dtm.Rows[i]["Photo"].ToString(), System.IO.FileMode.Open, System.IO.FileAccess.Read);
                        frm.pbPhoto.Image = System.Drawing.Image.FromStream(fs);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Image");
                        //throw;
                    }
                    

                    frm.Show(); 
                }               
           
                       
        }
        private void loadfMember()
        {
            var dtm = new DataTable();
            Cmd.Parameters["@fid"] = familyID;            
            dtm = Cmd.ExecuteDataTable("SELECT fm.*, m.Photo FROM qrFamilyMembers fm INNER JOIN tblMember m ON m.ID=fm.ID WHERE fm.FamilyID=@fid AND fm.Active=true");
            dgvFamilyMember.DataSource = dtm;
            for (var i = 0; i < dgvFamilyMember.Rows.Count; i++)
            {
                //dgvFamilyMember.Rows[i].Cells["Photo2"].Value = dgvFamilyMember.Rows[i].Cells["Photo"].Value;
                try
                {                    
                    var fs = default(System.IO.FileStream);
                    fs = new System.IO.FileStream(Application.StartupPath + "\\photo\\" + dgvFamilyMember.Rows[i].Cells["Photo"].Value, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    dgvFamilyMember.Rows[i].Cells["Photo2"].Value = System.Drawing.Image.FromStream(fs);
                    fs.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(familyID + " & GNo" + GroupNo + "  vid=" + dtf.Rows[0]["VillageID"]);
            //loadFamily();
            //cboVillage.SelectedValue = 2;
           
            var frm = new FormMemberNE2();
            frm.newEdit = true;
            //frm.memberID = (int)row.Cells["MemberID"].Value;
            frm.villageID = (int) cboVillage.SelectedValue;
            frm.txtGroupNo.Text = this.txtGroupNo.Text;
            frm.txtFamilyBookNo.Text = this.txtFamilyBookNo.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //int migrationInOut = 0;
                //if (frm.radioInNation.Checked)
                //{
                //    migrationInOut = 1;
                //}
                //else migrationInOut = 2;
                
                try
                {
                    //Bitmap img;
                    //img = new Bitmap(frm.lblImagePath.Text);                   

                    //Image img = frm.memberPhoto.Image;
                    //Int16 sexID = Convert.ToInt16(frm.cboSex.SelectedValue.ToString());
                    //string sexName = (sexID == 1) ? "ប្រុស" : "ស្រី";
                    //Int16 roleID = Convert.ToInt16(frm.cboRole.SelectedValue.ToString());
                    //string roleName;

                    //if (roleID == 1)
                    //{
                    //    roleName = "ប្រធានក្រុម";
                    //}
                    //else if (roleID == 2)
                    //{
                    //    roleName = "អនុប្រធានក្រុម";
                    //}
                    //else
                    //{
                    //    roleName = "សមាជិក";
                    //}
                    
                    //Boolean registerMember = frm.cbMember.Checked ? true : false;
                    //Boolean seen = frm.cbSeen.Checked ? true : false;
                    //Boolean migration = frm.radioIn.Checked ? false : true;
                    //Boolean peopleID = frm.cbPeopleID.Checked ? true : false;
                    //Boolean voteRegister = frm.cbVote.Checked ? true : false;
                    
                    //partyMember.Add(new Members(frm.txtName.Text, sexID, frm.dtpDob.Value, frm.txtjob.Text, registerMember, frm.txtMemberID.Text, seen, migration, migrationInOut, frm.txtOutAdr.Text, frm.txtAddress.Text, peopleID, frm.txtPeopleID.Text, frm.dtpDatein.Value, voteRegister, frm.txtVoteStation.Text, frm.txtVoteStationNo.Text, roleID, frm.txtdetail.Text, frm.lblImagePath.Text, frm.txtFamilyStatus.Text, sexName, roleName, (migrationInOut == 1) ? "ក្នុងស្រុក" : "ក្រៅស្រុក", img));

                    if (frm.newEdit==true)
                    {
                        Cmd.Parameters["@groupNo"] = txtGroupNo.Text.Trim();
                        Cmd.Parameters["@name"] = frm.txtName.Text.Trim();
                        Cmd.Parameters["@sex"] = frm.cboSex.SelectedValue;
                        Cmd.Parameters["@dob"] = frm.dtpDob.Value;
                        Cmd.Parameters["@job"] = frm.txtjob.Text.Trim();
                        Cmd.Parameters["@membercard"] = frm.cbMember.Checked ? true : false;
                        Cmd.Parameters["@membercardid"] = frm.txtMemberID.Text.Trim();
                        Cmd.Parameters["@seen"] = frm.cbSeen.Checked ? true : false;
                        Cmd.Parameters["@migration"] = frm.radioIn.Checked ? false : true;
                        Cmd.Parameters["@migrationout"] = frm.radioInNation.Checked ? 1 : 2;
                        Cmd.Parameters["@migrationdetail"] = frm.txtOutAdr.Text.Trim();
                        Cmd.Parameters["@address"] = frm.txtAddress.Text.Trim();
                        Cmd.Parameters["@peopleid"] = frm.cbPeopleID.Checked ? true : false;
                        Cmd.Parameters["@peopleidno"] = frm.txtPeopleID.Text.Trim();

                        if (frm.cbMember.Checked == true)
                        {
                            Cmd.Parameters["@datein"] = frm.dtpDatein.Value;
                        }
                        else
                        {
                            Cmd.Parameters["@datein"] = null;
                        }


                        Cmd.Parameters["@vote"] = frm.cbVote.Checked ? true : false;
                        Cmd.Parameters["@role"] = frm.cboRole.SelectedValue;
                        Cmd.Parameters["@detail"] = frm.txtdetail.Text.Trim();
                        Cmd.Parameters["@photo"] = frm.memberPhoto.Image != null ? frm.txtName.Text.Trim() + frm.dtpDob.Value.ToString("ddMMyyy") + ".jpg" : "";
                                               
                        Cmd.Parameters["@station"] = frm.cboVoteStation.SelectedValue;
                        Cmd.Parameters["@stationno"] = frm.cboVoteStationNo.SelectedValue;                        
                        
                        Cmd.Parameters["@VillageID"] = cboVillage.SelectedValue;
                        Cmd.Parameters["@familyStatus"] = frm.cboFamilyStatus.SelectedValue;
                        Cmd.Parameters["@familyID"] = familyID;
                        var sql = @"INSERT INTO tblMember
                                    ([GroupNo],[Name],[SexID],[Dob],[Job],[CardID],[CardIDNo],[CensusSeen],[Migration],[MigrationID],[MigrationDetail],[Address],
                                    [PeopleID],[PeopleIDNo],[DateIn],[VoteRegister],[RoleID],[Detail],[Photo],[StationID],[StationNoID],[VillageID],
                                    [StatusID],[FamilyID])
                                    VALUES(@groupNo,@name,@sex,@dob,@job,@membercard,@membercardid,@seen,@migration,@migrationout,@migrationdetail,@address,
                                    @peopleid,@peopleidno,@datein,@vote,@role,@detail,@photo,@station,@stationno,@VillageID,@familyStatus,@familyID)
                                ";
                        Cmd.ExecuteNonQuery(sql);
                        
                    } else
                    {

                    }

                    loadfMember();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //throw;
                }

                if (frm.lblImagePath.Text != "")
                {
                    try
                    {
                        frm.memberPhoto.Image.Save(Application.StartupPath + "\\photo\\" + frm.txtName.Text.Trim() + frm.dtpDob.Value.ToString("ddMMyyy") + ".jpg", ImageFormat.Jpeg);
                    }
                    catch (Exception ex)
                    {
                        //throw;
                    }

                }
                //dgvFamilyMember.Refresh();
            }
        }

        
        private void FormFamilyE_Load(object sender, EventArgs e)
        {
            loadVillagecbo();
            //cboVillage.SelectedValue = vid;
            loadFamily();
            //loadfMember();
            loadFmember2();
            
            //formatgridImage();
            
        }

        private void formatgridImage()
        {
            dgvFamilyMember.RowTemplate.Height = 120;
        }
        private void button1_Click(object sender, EventArgs e)
        {
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
            Cmd.Parameters["@GroupNo"] = txtGroupNo.Text.Trim();
            Cmd.Parameters["@FamilyBookNo"] = txtFamilyBookNo.Text.Trim();
            Cmd.Parameters["@VillageID"] = cboVillage.SelectedValue;
            Cmd.Parameters["@adr"] = txtAddress.Text.Trim();
            Cmd.Parameters["@fid"] = familyID;
            Cmd.ExecuteNonQuery("UPDATE tblFamily SET GroupNo=@GroupNo, FamilyBookNo=@FamilyBookNo, VillageID=@VillageID, Address=@adr WHERE FamilyID=@fid");

            Cmd.Parameters["@GroupNo"] = txtGroupNo.Text.Trim();
            Cmd.Parameters["@fid"] = familyID;
            Cmd.ExecuteNonQuery("UPDATE tblMember SET GroupNo=@GroupNo WHERE FamilyID=@fid");
            MessageBox.Show("កែប្រែទិន្ន័យបានសម្រេច!");
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            var row = default(DataGridViewRow);
            row = dgvFamilyMember.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }
            
            //FormFamilyE frm = new FormFamilyE();
           // frm.familyID = (int)row.Cells["FamilyID"].Value;            

            var frm = new FormMemberNE2();
            frm.memberID = (int)row.Cells["MemberID"].Value;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Cmd.Parameters["@VillageID"] = cboVillage.SelectedValue;
                Cmd.Parameters["@groupNo"] = txtGroupNo.Text;
                Cmd.Parameters["@name"] = frm.txtName.Text.Trim();
                Cmd.Parameters["@sex"] = frm.cboSex.SelectedValue;
                Cmd.Parameters["@dob"] = frm.dtpDob.Value;
                Cmd.Parameters["@job"] = frm.txtjob.Text.Trim();
                Cmd.Parameters["@membercard"] = frm.cbMember.Checked ? true : false;
                Cmd.Parameters["@membercardid"] = frm.txtMemberID.Text.Trim();
                Cmd.Parameters["@seen"] = frm.cbSeen.Checked ? true : false;
                Cmd.Parameters["@migration"] = frm.radioIn.Checked ? false : true;
                Cmd.Parameters["@migrationout"] = frm.radioInNation.Checked ? 1 : 2;
                Cmd.Parameters["@migrationdetail"] = frm.txtOutAdr.Text.Trim();
                Cmd.Parameters["@address"] = frm.txtAddress.Text.Trim();
                Cmd.Parameters["@peopleid"] = frm.cbPeopleID.Checked ? true : false;
                Cmd.Parameters["@peopleidno"] = frm.txtPeopleID.Text.Trim();
                Cmd.Parameters["@datein"] = frm.dtpDatein.Value;
                Cmd.Parameters["@vote"] = frm.cbVote.Checked ? true : false;
                Cmd.Parameters["@role"] = frm.cboRole.SelectedValue;
                Cmd.Parameters["@detail"] = frm.txtdetail.Text.Trim();
                Cmd.Parameters["@photo"] = frm.memberPhoto.Image != null ? frm.txtName.Text.Trim() + frm.dtpDob.Value.ToString("ddMMyyy") + ".jpg" : frm.dtm.Rows[0]["Photo"].ToString();
                Cmd.Parameters["@station"] = frm.cboVoteStation.SelectedValue;
                Cmd.Parameters["@stationno"] = frm.cboVoteStationNo.SelectedValue;
                Cmd.Parameters["@familyStatus"] = frm.cboFamilyStatus.SelectedValue;                
                Cmd.Parameters["@id"] = frm.memberID;
                
                var sql = @"UPDATE tblMember                                    
                                   SET VillageID=@VillageID, GroupNo=@groupNo, [Name]=@name, SexID=@sex, [Dob]=@dob, [Job]=@job, 
                                        CardID=@membercard, CardIDNo=@membercardid, CensusSeen=@seen, Migration=@migration,
                                        MigrationID=@migrationout, MigrationDetail=@migrationdetail, [Address]=@address, PeopleID=@peopleid,
                                        PeopleIDNo=@peopleidno, DateIn=@datein, VoteRegister=@vote, RoleID=@role, Detail=@detail, Photo=@photo,
                                        StationID=@station, StationNoID=@stationno, StatusID=@familyStatus
                                        WHERE [ID]=@id
                                 ";
                Cmd.ExecuteNonQuery(sql);

                if (frm.lblImagePath.Text != "")
                {
                    try
                    {
                        frm.memberPhoto.Image.Save(Application.StartupPath + "\\photo\\" + frm.txtName.Text.Trim() + frm.dtpDob.Value.ToString("ddMMyyy") + ".jpg", ImageFormat.Jpeg);
                    }
                    catch (Exception ex)
                    {
                        //throw;
                    }

                }

                MessageBox.Show("UPDATE SUCCESS!");

                loadfMember();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var row = default(DataGridViewRow);
            row = dgvFamilyMember.SelectedRows[0];
            if (row.Cells[1].Value == System.DBNull.Value)
            {
                return;
            }

            Cmd.Parameters["@mid"] = row.Cells["MemberID"].Value;
            Cmd.ExecuteNonQuery("UPDATE tblMember SET Active=false WHERE ID=@mid");
            //MessageBox.Show(row.Cells["MemberID"].Value+"");
            MessageBox.Show("លុបទិន្ន័យបានសម្រេច!");
            loadfMember();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //loadFmember2();
            var dtm = new DataTable();
            Cmd.Parameters["@fid"] = familyID;
            var sql = @"SELECT tblMember.Name, tblSex.SexName, tblMember.Dob, tblRole.RoleName, tblFamilyStatus.StatusName, tblMember.CardID, tblMember.CardIDNo, tblMember.VoteRegister, tblVoteStation.StationName, tblStationNo.StationNoName, tblMember.Active, tblMember.Photo
                            FROM ((((tblMember INNER JOIN tblRole ON tblMember.RoleId = tblRole.RoleID) INNER JOIN tblFamilyStatus ON tblMember.StatusID = tblFamilyStatus.StatusID) INNER JOIN tblVoteStation ON tblMember.StationID = tblVoteStation.StationID) INNER JOIN tblStationNo ON tblMember.StationNoID = tblStationNo.StationNoID) INNER JOIN tblSex ON tblMember.SexID = tblSex.SexID
                            WHERE tblMember.FamilyID=@fid ;
                        ";
            dtm = Cmd.ExecuteDataTable(sql);
            MessageBox.Show(familyID+":"+ dtm.Rows.Count);
        }
    }
}
