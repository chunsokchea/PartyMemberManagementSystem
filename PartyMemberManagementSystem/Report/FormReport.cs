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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.FullPage;
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        void viewReport()
        {
            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable();
            //Microsoft.Reporting.WinForms.ReportDataSource RpDs1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            //string SQL = "select * from tb_course";
            //MySqlDataAdapter da = new MySqlDataAdapter(SQL, con);

            //da.Fill(ds, "tb_course");
            //dt = ds.Tables(0);
            //ReportViewer1.Reset();
            //ReportViewer1.LocalReport.DataSources.Clear();
            //RpDs1.Name = "DataSet1";
            //RpDs1.Value = dt;
            //ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            //ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\\Report1.rdlc";
            //ReportViewer1.LocalReport.DataSources.Clear();
            //ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)));

            //ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            //ReportViewer1.RefreshReport();
        }
    }
}
