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

namespace Windows.UserControls
{
    public partial class UcReportItemWiseSales : UserControl
    {
        public UcReportItemWiseSales()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            string filePath = String.Format("{0}\\ItemWiseSales.rpt", System.Configuration.ConfigurationManager.AppSettings["ReportFolderPath"]);

            reportDocument.Load(filePath);



            reportDocument.Refresh();
            reportDocument.SetParameterValue("@StartDate", dtpStartDate.Value.Date);
            reportDocument.SetParameterValue("@EndDate", dtpEndDate.Value.Date);
            reportDocument.SetParameterValue("@paymenttype", cmbPaymentType.Text);

            reportDocument.SetParameterValue("@StartDate", dtpStartDate.Value.Date, reportDocument.Subreports[0].Name.ToString());
            reportDocument.SetParameterValue("@EndDate", dtpEndDate.Value.Date, reportDocument.Subreports[0].Name.ToString());
            reportDocument.SetParameterValue("@paymenttype", cmbPaymentType.Text, reportDocument.Subreports[0].Name.ToString());


            FormReport frm = new FormReport();
            frm.Text = "Item Wise Sales Report";
            frm.crystalReportViewer1.ReportSource = reportDocument;
            frm.Visible = true;
        }
    }
}
