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
    public partial class FormList1 : Form
    {
        public int villageID;
        public int groupid;
        public FormList1()
        {
            InitializeComponent();
        }

        private void FormList1_Load(object sender, EventArgs e)
        {
            Cmd.Parameters["@VillageID"]=villageID;
            Cmd.Parameters["@groupNo"]=groupid;
            var sql = @"SELECT m.*,s.SexName, v.VillageName, Year(m.Dob) from tblMember m , tblSex s, tblVillage v
                            WHERE s.SexID=m.SexID AND v.VillageID=m.VillageID                       
                            AND m.Active=true
                            AND m.VoteRegister=False                                                        
                            AND m.VillageID=@VillageID                            
                            AND Year(m.Dob)<= 2000
                            AND Month(m.Dob)<=7
                            AND Day(m.Dob)<=30
                            ";
            var dt = new DataTable();
            dt = Cmd.ExecuteDataTable(sql);

            var lstReportParameters = new List<ReportParameter>();
            var objReportParameter = new ReportParameter("GID", groupid + "");
            lstReportParameters.Add(objReportParameter);
            reportViewer1.LocalReport.SetParameters(lstReportParameters);
            reportViewer1.LocalReport.DataSources.Clear();

            var dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(dataset);
            dataset.Value = dt;
            reportViewer1.LocalReport.Refresh();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.FullPage;

            reportViewer1.RefreshReport();

            //MessageBox.Show(groupid+" / " + villageID + " / " + dt.Rows[0]["Name"]);
            this.reportViewer1.RefreshReport();
        }
    }
}
