using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PartyMemberManagementSystem.GUI.Report
{
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
        }

        private void loadVillageCbo()
        {
            var sql = "SELECT * FROM tblVillage";
            var dtv = new DataTable();
            dtv = Cmd.ExecuteDataTable(sql);
            cboVillage.DisplayMember = "VillageName";
            cboVillage.ValueMember = "VillageID";
            cboVillage.DataSource = dtv;

        }
        private void loadGroupCbo()
        {
            Cmd.Parameters["@villageid"]=cboVillage.SelectedValue;
            var sql = "SELECT [FamilyID],[GroupNo] FROM tblFamily WHERE VillageID=@villageid";
            var dtv = new DataTable();
            dtv = Cmd.ExecuteDataTable(sql);
            cboGroup.DisplayMember = "GroupNo";
            cboGroup.ValueMember = "FamilyID";
            cboGroup.DataSource = dtv;

        }
        private void loadDataTable1()
        {
            Cmd.Parameters["@groupNo"] = cboGroup.SelectedValue;
            Cmd.Parameters["@VillageID"] = cboVillage.SelectedValue;
            var sql = @"SELECT m.Name,m.Job,s.SexName from tblMember m , tblSex s
                        WHERE s.SexID=m.SexID                        
                        AND m.Active=true
                        AND m.VoteRegister=False
                        AND m.FamilyID=@groupNo
                        AND m.VillageID=@VillageID
                        AND Year(m.Dob)<= 2000
                        AND Month(m.Dob)<=7
                        AND Day(m.Dob)<=30
                        ";
            var dt = new DataTable();
            dt = Cmd.ExecuteDataTable(sql);
            dgvList1.DataSource = dt;
        }
        private void loadDataTable2()
        {
            Cmd.Parameters["@groupNo"] = cboGroup.SelectedValue;
            Cmd.Parameters["@VillageID"]=cboVillage.SelectedValue;
            var sql = @"SELECT m.Name,m.Job,s.SexName from tblMember m , tblSex s
                        WHERE s.SexID=m.SexID                        
                        AND m.Active=true
                        AND m.VoteRegister=True
                        AND m.FamilyID=@groupNo
                        AND m.VillageID=@VillageID
                        AND Year(m.Dob)<= 2000
                        AND Month(m.Dob)<=7
                        AND Day(m.Dob)<=30
                        ";
            var dt = new DataTable();
            dt = Cmd.ExecuteDataTable(sql);
            dgvList2.DataSource = dt;
        }
        private void loadDataTable3()
        {
            Cmd.Parameters["@groupNo"] = cboGroup.SelectedValue;
            Cmd.Parameters["@VillageID"] = cboVillage.SelectedValue;
            var sql = @"SELECT m.Name,m.Job,s.SexName from tblMember m , tblSex s
                        WHERE s.SexID=m.SexID                         
                        AND m.Active=true                        
                        AND m.FamilyID=@groupNo   
                        AND m.VillageID=@VillageID                     
                        ";
            var dt = new DataTable();
            dt = Cmd.ExecuteDataTable(sql);
            dgvList3.DataSource = dt;
        }
        private void FormList_Load(object sender, EventArgs e)
        {
            loadVillageCbo();
            loadGroupCbo();
            //loadDataTable2();
            //loadDataTable1();
            //loadDataTable3();
        }

        private void cboVillage_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGroupCbo();
        }

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataTable2();
            loadDataTable1();
            loadDataTable3();
        }

        private void btnList3_Click(object sender, EventArgs e)
        {
            var frm = new FormList3();
            frm.groupid = (int)cboGroup.SelectedValue;
            frm.villageID = (int)cboVillage.SelectedValue;
            frm.ShowDialog();            
        }

        private void btnlist1_Click(object sender, EventArgs e)
        {
            var frm = new FormList1();
            frm.groupid = (int)cboGroup.SelectedValue;
            frm.villageID = (int)cboVillage.SelectedValue;
            frm.ShowDialog();  
        }

        private void btnlist2_Click(object sender, EventArgs e)
        {
            var frm = new FormList2();
            frm.groupid = (int)cboGroup.SelectedValue;
            frm.villageID = (int)cboVillage.SelectedValue;
            frm.ShowDialog();  
        }
    }
}
