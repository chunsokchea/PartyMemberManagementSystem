using PartyMemberManagementSystem.GUI.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PartyMemberManagementSystem.GUI.Security
{
    public partial class FormMemberData : Form
    {
        public int memberID;
        public int familyID;
        public int villageID;
        public string groupNo;
        public string familyBookNo;
        public FormMemberData()
        {
            InitializeComponent();
            //groupBox1.Click += FormMemberData_Click;
            //lblName.Click += FormMemberData_Click;
           // pbPhoto.Click += FormMemberData_Click;            
            //lblCanVote.Click += FormMemberData_Click;
            //lblAge.Click += FormMemberData_Click;
            //lblCardID.Click += FormMemberData_Click;
            //lblCardIdNo.Click += FormMemberData_Click;
            //lblfStatus.Click += FormMemberData_Click;
            //lblName.Click += FormMemberData_Click;
            //lblRole.Click += FormMemberData_Click;
            //lblSex.Click += FormMemberData_Click;
            //lblsss.Click += FormMemberData_Click;
            //lblVoteStation.Click += FormMemberData_Click;
            //lblVoteStationNo.Click += FormMemberData_Click;
            //label10.Click += FormMemberData_Click;
            //label11.Click += FormMemberData_Click;
            //label12.Click += FormMemberData_Click;
            //label13.Click += FormMemberData_Click;
            //label17.Click += FormMemberData_Click;
            //label2.Click += FormMemberData_Click;
            //label3.Click += FormMemberData_Click;
            //label4.Click += FormMemberData_Click;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("ID "+memberID);
        }

        private void FormMemberData_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("ID " + familyID+" Member :" + memberID);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormMemberNE2 frm = new FormMemberNE2();
            frm.memberID = memberID;
            frm.txtGroupNo.Text = groupNo;
            frm.txtFamilyBookNo.Text = familyBookNo;
            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Cmd.Parameters["@VillageID"] = villageID;
                Cmd.Parameters["@groupNo"] = groupNo;
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

                string sql = @"UPDATE tblMember                                    
                                   SET VillageID=@VillageID, GroupNo=@groupNo, [Name]=@name, SexID=@sex, [Dob]=@dob, [Job]=@job, 
                                        CardID=@membercard, CardIDNo=@membercardid, CensusSeen=@seen, Migration=@migration,
                                        MigrationID=@migrationout, MigrationDetail=@migrationdetail, [Address]=@address, PeopleID=@peopleid,
                                        PeopleIDNo=@peopleidno, DateIn=@datein, VoteRegister=@vote, RoleID=@role, Detail=@detail, Photo=@photo,
                                        StationID=@station, StationNoID=@stationno, StatusID=@familyStatus
                                        WHERE [ID]=@id
                                 ";
                Cmd.ExecuteNonQuery(sql);

                //if (frm.lblImagePath.Text != "")
                //{
                    try
                    {
                        frm.memberPhoto.Image.Save(Application.StartupPath + "\\photo\\" + frm.txtName.Text.Trim() + frm.dtpDob.Value.ToString("ddMMyyy") + ".jpg", ImageFormat.Jpeg);
                    }
                    catch (Exception ex)
                    {
                        //throw;
                    }

                //}

                MessageBox.Show("UPDATE SUCCESS!");

                //loadfMember();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(groupNo + "");
        }
    }
}
