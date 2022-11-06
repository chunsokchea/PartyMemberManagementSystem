using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PartyMemberManagementSystem.Report
{
    public partial class ReportList : Form
    {
        public ReportList()
        {
            InitializeComponent();
        }

        private void ReportList_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT m.*,s.SexName,g.GroupName from tblMember m , tblSex s , tblGroup g
                            WHERE s.SexID=m.SexID 
                            AND g.GroupID=m.GroupID";
            DataTable dt = new DataTable();
            dt = Cmd.ExecuteDataTable(sql);
            
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(dataset);
            dataset.Value = dt;
            reportViewer1.LocalReport.Refresh();
            
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.FullPage;
                        
            this.reportViewer1.RefreshReport();
            
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT m.*,s.SexName,g.GroupName from tblMember m , tblSex s , tblGroup g
                            WHERE s.SexID=m.SexID 
                            AND g.GroupID=m.GroupID
                            AND m.Active=true
                            AND m.VoteRegister=True";
            DataTable dt = new DataTable();
            dt = Cmd.ExecuteDataTable(sql);

            //ReportDataSource reportDataSource = new ReportDataSource("dataSourceName", GetData());


            List<ReportParameter> lstReportParameters = new List<ReportParameter>();
            //ps.Add(new ReportParameter("GID", textBox1.Text));
            ReportParameter objReportParameter = new ReportParameter("GID", textBox1.Text);
            lstReportParameters.Add(objReportParameter);
            reportViewer1.LocalReport.SetParameters(lstReportParameters);
            //reportViewer1.LocalReport.ReportPath = Application.StartupPath + "\\report\\List2.rdl";
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(dataset);
            dataset.Value = dt;
            reportViewer1.LocalReport.Refresh();
           // reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",dt));
           // reportViewer1.LocalReport.ReportEmbeddedResource = "PartyMemberManagementSystem.Report.List2.rdlc";

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.FullPage;
            
            reportViewer1.RefreshReport();
        }
    }
}
