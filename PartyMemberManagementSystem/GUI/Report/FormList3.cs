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
    public partial class FormList3 : Form
    {
        public int groupid;
        public int villageID;
        public FormList3()
        {
            InitializeComponent();
        }

        private void FormList3_Load(object sender, EventArgs e)
        {
            Cmd.Parameters["@VillageID"] = villageID;
            string sql = @"SELECT m.*,s.SexName, v.VillageName from tblMember m , tblSex s, tblVillage v
                            WHERE s.SexID=m.SexID AND v.VillageID=m.VillageID                       
                            AND m.Active=true                                                                                    
                            AND m.VillageID=@VillageID                            
                            ";

            DataTable dt = new DataTable();
            dt = Cmd.ExecuteDataTable(sql);

            List<ReportParameter> lstReportParameters = new List<ReportParameter>();            
            ReportParameter objReportParameter = new ReportParameter("GID", groupid+"");
            lstReportParameters.Add(objReportParameter);
            reportViewer1.LocalReport.SetParameters(lstReportParameters);
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(dataset);
            dataset.Value = dt;
            reportViewer1.LocalReport.Refresh();
            // reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",dt));
            // reportViewer1.LocalReport.ReportEmbeddedResource = "PartyMemberManagementSystem.Report.List3.rdlc";

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.FullPage;

            reportViewer1.RefreshReport();
        }
    }
}
