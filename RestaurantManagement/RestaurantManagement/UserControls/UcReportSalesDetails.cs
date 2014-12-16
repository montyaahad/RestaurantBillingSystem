using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Windows.UserControls
{
    public partial class UcReportSalesDetails : UserControl
    {
        public UcReportSalesDetails()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            string filePath = String.Format("{0}\\SalesDetails.rpt", System.Configuration.ConfigurationManager.AppSettings["ReportFolderPath"]);
            
            reportDocument.Load(filePath);

            

            reportDocument.Refresh();
            reportDocument.SetParameterValue("@startdate", dtpStartDate.Value.Date);
            reportDocument.SetParameterValue("@enddate", dtpEndDate.Value.Date);

            reportDocument.SetParameterValue("@startdate", dtpStartDate.Value.Date, reportDocument.Subreports[0].Name.ToString());
            reportDocument.SetParameterValue("@enddate", dtpEndDate.Value.Date, reportDocument.Subreports[0].Name.ToString());


            FormReport frm = new FormReport();
            frm.Text = "Sales Report";
            frm.crystalReportViewer1.ReportSource = reportDocument;
            frm.Visible = true;
        }
    }
}
