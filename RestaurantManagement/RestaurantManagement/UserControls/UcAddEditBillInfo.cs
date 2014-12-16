using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Service.BLL;
using Windows.Support;
using ComponentFactory.Krypton.Toolkit;
using Service.DTO;
using Windows.Reports;
using Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Windows.Utilities;
using CrystalDecisions.CrystalReports.Engine;
using System.Drawing.Printing;
using CrystalDecisions.Shared;

namespace Windows.UserControls
{
    public partial class UcAddEditBillInfo : UserControl
    {
        List<Service.DTO.MenuItem> listMenuItem;
        List<Service.DTO.ChargeConfiguration> listChargeConfiguration;

        DateTime sdate;

        private int _billId = 0;

        public UcAddEditBillInfo()
        {
            InitializeComponent();
        }

        public UcAddEditBillInfo(int id)
        {
            InitializeComponent();
            _billId = id;
            //cmbMenuItem.Focus();
            txtMenuCode.Focus();
        }

        private void UcAddEditBillInfo_Load(object sender, EventArgs e)
        {
            
            FillCombo();

            LoadSystemDate();

            if (_billId > 0)
            {
                loadBillDataById();
                //cmbMenuItem.Focus();
                txtMenuCode.Focus();
            }
        }

        private void LoadSystemDate()
        {
            sdate = new BllDayCloseDetails().GetSystemDate();
            dtpBillDate.Value = sdate;
        }

        private void FillCombo()
        {
            listMenuItem = new BllMenuItem().GetAll();
            FormLoader.LoadDataSource<Service.DTO.MenuItem>(cmbMenuItem, listMenuItem, "MenuItemName", "MenuItemId");

            cmbMenuItem.Text = "";
            txtPrice.Text = "";



            List<Service.DTO.TableDetails> listTable = new BllTableDetails().GetAll();
            FormLoader.LoadDataSource<Service.DTO.TableDetails>(cmbTableNo, listTable, "TableCode", "TableId");

            if (_billId == 0)
            {
                cmbTableNo.Text = "";
            }


            List<Service.DTO.ServiceType> listService = new BllServiceType().GetAll();
            FormLoader.LoadDataSource<Service.DTO.ServiceType>(cmbServiceType, listService, "ServiceTypeName", "ServiceTypeId");

            List<Service.DTO.Waiters> listWaiters = new BllWaiters().GetAll();
            FormLoader.LoadDataSource<Service.DTO.Waiters>(cmbWaiter, listWaiters, "WaiterCode", "WaiterId");

            List<Service.DTO.PaymentType> listPaymentType = new BllPaymentType().GetAll();
            FormLoader.LoadDataSource<Service.DTO.PaymentType>(cmbPaymentType, listPaymentType, "PaymentTypeName", "PaymentTypeId");

            //cmbPaymentType.Text = "";

            txtSubTotal.Text = "0";

            listChargeConfiguration = new BllChargeConfiguration().GetAll();
            setChargeValues();
        }

        private void setChargeValues()
        {
            txtDiscountPer.Text = listChargeConfiguration[0].DiscountPercent.ToString();
            txtServiceChargePer.Text = listChargeConfiguration[0].ServiceChargePercent.ToString();
            txtTaxPer.Text = listChargeConfiguration[0].VatPercent.ToString();
        }

        private void cmbMenuItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = Convert.ToInt32(cmbMenuItem.SelectedValue.ToString());
            }
            catch
            {
                id = new BllMenuItem().GetMinimumMenuItemId();
            }
            finally
            {
                var MenuItem = new Service.BLL.BllMenuItem().GetById(id);

                txtPrice.Text = MenuItem.Price.ToString();
            }
        }

        private void txtSaleQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double val1 = 0;
                double val2 = 0;
                double.TryParse(txtPrice.Text, out val1);
                double.TryParse(txtSaleQty.Text, out val2);
                val1 = Math.Round(val1, 2);
                val2 = Math.Round(val2, 2);
                double I = (val1 * val2);
                I = Math.Round(I, 2);
                txtTotalAmount.Text = I.ToString();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTableNo.Text == "")
                {
                    KryptonMessageBox.Show("Please select Table", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbMenuItem.Text == "")
                {
                    KryptonMessageBox.Show("Please select product name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtSaleQty.Text == "")
                {
                    KryptonMessageBox.Show("Please enter quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSaleQty.Focus();
                    return;
                }
                int SaleQty = Convert.ToInt32(txtSaleQty.Text);
                if (SaleQty == 0)
                {
                    KryptonMessageBox.Show("no. of quantity can not be zero", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSaleQty.Focus();
                    return;
                }

                if (txtKotNo.Text.Trim() == "")
                {
                    KryptonMessageBox.Show("Please enter KOT No.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKotNo.Focus();
                    return;
                }

                int parsedValue;
                if (!int.TryParse(txtPax.Text, out parsedValue))
                {
                    KryptonMessageBox.Show("Please enter valid PAX.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPax.Focus();
                    return;
                }

                btnRemove.Enabled = false;
                //cmbMenuItem.Focus();
                txtMenuCode.Focus();

                if (ListView1.Items.Count == 0)
                {

                    ListViewItem lst = new ListViewItem();
                    lst.SubItems.Add(cmbMenuItem.SelectedValue.ToString());
                    lst.SubItems.Add(cmbMenuItem.Text);
                    lst.SubItems.Add(txtPrice.Text);
                    lst.SubItems.Add(txtSaleQty.Text);
                    lst.SubItems.Add(txtTotalAmount.Text);
                    ListView1.Items.Add(lst);
                    txtSubTotal.Text = subtot().ToString();

                    Calculate();

                    BillInfo billInfo = createBillInfoObject();

                    _billId = new BllBillInfo().InsertOrUpdate(billInfo);

                    txtBillNo.Text = "B" + _billId.ToString();

                    BillDetails billDetails = new BillDetails();
                    billDetails.BillId = _billId;
                    billDetails.MenuItemId = Convert.ToInt32(cmbMenuItem.SelectedValue.ToString());
                    billDetails.Quantity = Convert.ToInt32(txtSaleQty.Text);
                    billDetails.UnitPrice = Convert.ToDecimal(txtPrice.Text);
                    billDetails.IsDiscountAvailable = false;
                    billDetails.TotalPrice = Convert.ToDecimal(txtTotalAmount.Text);
                    billDetails.ReceivedBy = BaseObject.User_ID;
                    billDetails.IsDeleted = false;

                    new BllTempBillDetails().InsertOrUpdate(billDetails);



                    cmbMenuItem.Text = "";
                    txtPrice.Text = "";
                    txtSaleQty.Text = "";
                    txtTotalAmount.Text = "";

                    return;
                }

                for (int j = 0; j <= ListView1.Items.Count - 1; j++)
                {
                    if (ListView1.Items[j].SubItems[1].Text == cmbMenuItem.SelectedValue.ToString())
                    {
                        ListView1.Items[j].SubItems[1].Text = cmbMenuItem.SelectedValue.ToString();
                        ListView1.Items[j].SubItems[2].Text = cmbMenuItem.Text;
                        ListView1.Items[j].SubItems[3].Text = txtPrice.Text;
                        ListView1.Items[j].SubItems[4].Text = (Convert.ToInt32(ListView1.Items[j].SubItems[4].Text) + Convert.ToInt32(txtSaleQty.Text)).ToString();
                        ListView1.Items[j].SubItems[5].Text = (Convert.ToDecimal(ListView1.Items[j].SubItems[5].Text) + Convert.ToDecimal(txtTotalAmount.Text)).ToString();
                        txtSubTotal.Text = subtot().ToString();
                        Calculate();


                        BillDetails billDetails = new BillDetails();
                        billDetails.BillId = _billId;
                        billDetails.MenuItemId = Convert.ToInt32(cmbMenuItem.SelectedValue.ToString());
                        billDetails.Quantity = Convert.ToInt32(ListView1.Items[j].SubItems[4].Text);
                        billDetails.UnitPrice = Convert.ToDecimal(ListView1.Items[j].SubItems[3].Text);
                        billDetails.IsDiscountAvailable = false;
                        billDetails.TotalPrice = Convert.ToDecimal(ListView1.Items[j].SubItems[5].Text);
                        billDetails.ReceivedBy = BaseObject.User_ID;
                        billDetails.IsDeleted = false;

                        new BllTempBillDetails().InsertOrUpdate(billDetails);

                        BillInfo billInfo = createBillInfoObject();

                        new BllBillInfo().InsertOrUpdate(billInfo);


                        cmbMenuItem.Text = "";
                        txtPrice.Text = "";
                        txtSaleQty.Text = "";
                        txtTotalAmount.Text = "";
                        return;

                    }
                }

                ListViewItem lst1 = new ListViewItem();

                lst1.SubItems.Add(cmbMenuItem.SelectedValue.ToString());
                lst1.SubItems.Add(cmbMenuItem.Text);
                lst1.SubItems.Add(txtPrice.Text);
                lst1.SubItems.Add(txtSaleQty.Text);
                lst1.SubItems.Add(txtTotalAmount.Text);
                ListView1.Items.Add(lst1);
                txtSubTotal.Text = subtot().ToString();
                Calculate();

                BillDetails billDetails2 = new BillDetails();
                billDetails2.BillId = _billId;
                billDetails2.MenuItemId = Convert.ToInt32(cmbMenuItem.SelectedValue.ToString());
                billDetails2.Quantity = Convert.ToInt32(txtSaleQty.Text);
                billDetails2.UnitPrice = Convert.ToDecimal(txtPrice.Text);
                billDetails2.IsDiscountAvailable = false;
                billDetails2.TotalPrice = Convert.ToDecimal(txtTotalAmount.Text);
                billDetails2.ReceivedBy = BaseObject.User_ID;
                billDetails2.IsDeleted = false;

                new BllTempBillDetails().InsertOrUpdate(billDetails2);

                BillInfo billInfo2 = createBillInfoObject();

                new BllBillInfo().InsertOrUpdate(billInfo2);

                cmbMenuItem.Text = "";
                txtPrice.Text = "";
                txtSaleQty.Text = "";
                txtTotalAmount.Text = "";
                return;
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private BillInfo createBillInfoObject()
        {
            BillInfo obj = new BillInfo();
            if (_billId > 0)
            {
                obj.BillNo = txtBillNo.Text;
            }
            obj.SubTotal = Convert.ToDecimal(txtSubTotal.Text);

            obj.BillId = _billId;
            obj.GrandTotal = Convert.ToDecimal(txtGrandTotal.Text);
            obj.BillDate = Convert.ToDateTime(dtpBillDate.Value);
            obj.PaymentType = 1;
            obj.TableNo = 1;
            obj.BillStatus = "open";
            obj.EntryDatetime = DateTime.Now;
            obj.ReceivedBy = BaseObject.User_ID;
            obj.Remarks = txtRemarks.Text;

            obj.ServiceTypeId = Convert.ToInt32(cmbServiceType.SelectedValue);
            obj.WaiterId = Convert.ToInt32(cmbWaiter.SelectedValue);
            obj.TableId = Convert.ToInt32(cmbTableNo.SelectedValue);
            obj.KotNo = txtKotNo.Text;

            obj.DiscountPercent = Convert.ToInt32(txtDiscountPer.Text);
            obj.DiscountAmount = Convert.ToDecimal(txtDiscountAmount.Text);
            obj.VatPercent = Convert.ToInt32(txtTaxPer.Text);
            obj.VatAmount = Convert.ToDecimal(txtTaxAmt.Text);
            obj.ServiceChargePercent = Convert.ToInt32(txtServiceChargePer.Text);
            obj.ServiceChargeAmount = Convert.ToDecimal(txtServiceChargeAmount.Text);

            obj.Pax = Convert.ToInt32(txtPax.Text);
            obj.CustomerName = txtCustomerName.Text;

            return obj;
        }

        private double subtot()
        {
            int i = 0;
            int j = 0;
            double k = 0;
            i = 0;
            j = 0;
            k = 0;


            try
            {

                j = ListView1.Items.Count;
                for (i = 0; i <= j - 1; i++)
                {
                    k = k + Convert.ToDouble(ListView1.Items[i].SubItems[5].Text);
                    k = Math.Round(k, 2);
                }

            }

            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return k;

        }

        private void Calculate()
        {

            try
            {
                double valSubTotal = Convert.ToDouble(txtSubTotal.Text);
                double valVatAmount = 0;
                //double val2 = 0;
                double valDiscountAmount = 0;
                double valServiceChargeAmount = 0;
                double valGrandTotal = 0;
                double valCashAmount = 0;

                if (txtDiscountPer.Text != "")
                {
                    valDiscountAmount = Convert.ToDouble((valSubTotal * Convert.ToDouble(txtDiscountPer.Text) / 100));
                    valDiscountAmount = Math.Round(valDiscountAmount, 2);
                    txtDiscountAmount.Text = valDiscountAmount.ToString();
                }

                if (txtServiceChargePer.Text != "")
                {
                    valServiceChargeAmount = Convert.ToDouble(((valSubTotal - valDiscountAmount) * Convert.ToDouble(txtServiceChargePer.Text) / 100));
                    valServiceChargeAmount = Math.Round(valServiceChargeAmount, 2);
                    txtServiceChargeAmount.Text = valServiceChargeAmount.ToString();

                }

                if (txtTaxPer.Text != "")
                {
                    valVatAmount = Convert.ToDouble(((valSubTotal + valServiceChargeAmount - valDiscountAmount) * Convert.ToDouble(txtTaxPer.Text) / 100));
                    valVatAmount = Math.Round(valVatAmount, 2);
                    txtTaxAmt.Text = valVatAmount.ToString();

                }

                

                double.TryParse(txtSubTotal.Text, out valSubTotal);
                double.TryParse(txtDiscountAmount.Text, out valDiscountAmount);
                double.TryParse(txtTaxAmt.Text, out valVatAmount);
                double.TryParse(txtServiceChargeAmount.Text, out valServiceChargeAmount);
               
                double.TryParse(txtGrandTotal.Text, out valGrandTotal);
                double.TryParse(txtCash.Text, out valCashAmount);
                valVatAmount = Math.Round(valVatAmount, 2);
                valSubTotal = Math.Round(valSubTotal, 2);
                valDiscountAmount = Math.Round(valDiscountAmount, 2);
                valGrandTotal = valSubTotal + valVatAmount + valServiceChargeAmount - valDiscountAmount;
                valGrandTotal = Math.Round(valGrandTotal, 0);
                txtGrandTotal.Text = valGrandTotal.ToString();
                double I = (valCashAmount - valGrandTotal);
                I = Math.Round(I, 2);
                txtChange.Text = I.ToString();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListView1.Items.Count == 0)
                {
                    KryptonMessageBox.Show("No items to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ListView1.Items.Count == 1)
                {
                    KryptonMessageBox.Show("You can not remove single item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int itmCnt = 0;
                    int i = 0;
                    int t = 0;


                    BillDetails billDetails = new BillDetails();
                    billDetails.BillId = _billId;
                    billDetails.MenuItemId = Convert.ToInt32(ListView1.FocusedItem.SubItems[1].Text);
                    billDetails.Quantity = Convert.ToInt32(ListView1.FocusedItem.SubItems[4].Text);
                    billDetails.UnitPrice = Convert.ToDecimal(ListView1.FocusedItem.SubItems[3].Text);
                    billDetails.IsDiscountAvailable = false;
                    billDetails.TotalPrice = Convert.ToDecimal(ListView1.FocusedItem.SubItems[5].Text);
                    billDetails.ReceivedBy = BaseObject.User_ID;
                    billDetails.IsDeleted = false;

                    new BllTempBillDetails().DeleteData(billDetails);

                    ListView1.FocusedItem.Remove();

                    itmCnt = ListView1.Items.Count;
                    t = 1;

                    for (i = 1; i <= itmCnt + 1; i++)
                    {
                        //Dim lst1 As New ListViewItem(i)
                        //ListView1.Items(i).SubItems(0).Text = t
                        t = t + 1;

                    }
                    txtSubTotal.Text = subtot().ToString();
                    Calculate();

                    BillInfo billInfo = createBillInfoObject();

                    new BllBillInfo().InsertOrUpdate(billInfo);
                }

                btnRemove.Enabled = false;
                if (ListView1.Items.Count == 0)
                {
                    txtSubTotal.Text = "";
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTaxPer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTaxPer.Text))
                {
                    txtTaxAmt.Text = "";
                    txtGrandTotal.Text = "";
                    return;
                }
                Calculate();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDiscountPer_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscountPer.Text))
            {
                txtDiscountAmount.Text = "";
                txtGrandTotal.Text = "";
                return;
            }
            Calculate();
        }

        private void txtServiceChargePer_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServiceChargePer.Text))
            {
                txtServiceChargePer.Text = "";
                txtGrandTotal.Text = "";
                return;
            }
            Calculate();
        }

        private void cmbTableNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reset();

            int tableId = 0;

            try
            {
                tableId = Convert.ToInt32(cmbTableNo.SelectedValue);

            }
            catch
            {
                //tableId = 1;
                return;
            }

            _billId = new BllBillInfo().GetOpenBillIdByTableId(tableId);

            if (_billId == 0)
            {
                Reset();
            }
            else
            {
                Reset();
                loadBillDataById();
                //cmbMenuItem.Focus();
                txtMenuCode.Focus();
            }
        }

        private void loadBillDataById()
        {
            BillInfo _billInfo = new BllBillInfo().GetById(_billId);

            txtBillNo.Text = "B" + _billId;
            cmbWaiter.SelectedValue = _billInfo.WaiterId;
            cmbServiceType.SelectedValue = _billInfo.ServiceTypeId;
            cmbTableNo.SelectedValue = _billInfo.TableId;
            txtKotNo.Text = _billInfo.KotNo;
            cmbPaymentType.SelectedValue = _billInfo.ServiceTypeId;

            

            List<BillDetails> listBillDetails = new BllTempBillDetails().GetBillDetailsListByBillId(_billId);

            ListView1.Items.Clear();

            for (int i = 0; i < listBillDetails.Count; i++)
            {
                ListViewItem lst = new ListViewItem();
                lst.SubItems.Add(listBillDetails[i].MenuItemId.ToString());
                lst.SubItems.Add(listBillDetails[i].MenuItemName.ToString());
                lst.SubItems.Add(listBillDetails[i].UnitPrice.ToString());
                lst.SubItems.Add(listBillDetails[i].Quantity.ToString());
                lst.SubItems.Add(listBillDetails[i].TotalPrice.ToString());
                ListView1.Items.Add(lst);
                txtSubTotal.Text = subtot().ToString();
                Calculate();
            }

            //setChargeValues();
            txtDiscountPer.Text = _billInfo.DiscountPercent.ToString();
            txtServiceChargePer.Text = _billInfo.ServiceChargePercent.ToString();
            txtTaxPer.Text = _billInfo.VatPercent.ToString();

            //cmbMenuItem.Focus();
            txtMenuCode.Focus();
        }

        private void Reset()
        {
            txtBillNo.Text = "";
            dtpBillDate.Text = sdate.Date.ToString();

            txtPrice.Text = "";

            txtSaleQty.Text = "";
            txtTotalAmount.Text = "";
            ListView1.Items.Clear();
            txtDiscountAmount.Text = "";
            //txtDiscountPer.Text = "";
            
            txtSubTotal.Text = "";
            //txtTaxPer.Text = "";
            txtTaxAmt.Text = "";
            txtServiceChargeAmount.Text = "";

            txtGrandTotal.Text = "";
            txtCash.Text = "";
            txtChange.Text = "";
            txtRemarks.Text = "";
            
            btnSave.Enabled = false;
            //Delete.Enabled = false;
            //btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
            btnPrintInvoice.Enabled = true;
            
            ListView1.Enabled = true;

            cmbWaiter.SelectedValue = 1;
            cmbPaymentType.SelectedValue = 1;

            cmbTableNo.Text = "";

            txtKotNo.Text = "";
            cmbServiceType.SelectedValue = 1;
            cmbMenuItem.Text = "";

            txtPax.Text = "0";
            txtCustomerName.Text = "";

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_billId == 0)
            {
                KryptonMessageBox.Show("Please select Menu item", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
 
            }

            if (ListView1.Items.Count == 0)
            {
                KryptonMessageBox.Show("Please select Menu item", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtDiscountPer.Text == "")
            {
                KryptonMessageBox.Show("Please insert Discount Percent", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiscountPer.Focus();
                return;
            }

            if (txtTaxPer.Text == "")
            {
                KryptonMessageBox.Show("Please insert Vat Percent", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaxPer.Focus();
                return;
            }

            if (txtServiceChargePer.Text == "")
            {
                KryptonMessageBox.Show("Please insert Service charge Percent", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceChargePer.Focus();
                return;
            }

            int paymenttypeid = Convert.ToInt32(cmbPaymentType.SelectedValue);

            if (paymenttypeid == 4 || paymenttypeid == 5)
            {
                if (txtRemarks.Text.Trim() == "")
                {
                    KryptonMessageBox.Show("Please insert Remarks for Void/Complementary payment", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRemarks.Focus();
                    return;
 
                }
            }

            int disPer = Convert.ToInt32(txtDiscountPer.Text);
            if (disPer > 0)
            {
                if (txtRemarks.Text.Trim() == "")
                {
                    KryptonMessageBox.Show("Please insert Remarks for Discount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRemarks.Focus();
                    return;

                }
            }

            string msg = "You choose " + cmbPaymentType.Text.Trim() + " payment type.\n" + Messages.SaveConfirmation;
            DialogResult dr = KryptonMessageBox.Show(msg, Text, MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                BillInfo _billInfo = createBillInfoObject();
                _billInfo.BillId = _billId;
                _billInfo.BillNo = "B" + _billId;

                _billInfo.PaymentTypeId = paymenttypeid;
                _billInfo.IsClosed = true;

                for (int j = 0; j <= ListView1.Items.Count - 1; j++)
                {
                    BillDetails billDetails = new BillDetails();
                    billDetails.BillId = _billId;
                    billDetails.MenuItemId = Convert.ToInt32(cmbMenuItem.SelectedValue.ToString());
                    billDetails.Quantity = Convert.ToInt32(ListView1.Items[j].SubItems[4].Text);
                    billDetails.UnitPrice = Convert.ToDecimal(ListView1.Items[j].SubItems[3].Text);
                    billDetails.IsDiscountAvailable = false;
                    billDetails.TotalPrice = Convert.ToDecimal(ListView1.Items[j].SubItems[5].Text);
                    billDetails.ReceivedBy = BaseObject.User_ID;

                    new BllBillDetails().InsertOrUpdate(billDetails);
                }

                new BllBillInfo().InsertOrUpdate(_billInfo);

                btnSave.Enabled = false;
                btnPrintInvoice.Enabled = true;

                KryptonMessageBox.Show("Successfully completed", "Bill Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Reset();
            }
        }

        private void cmbTableNo_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (_billId > 0)
            {
                BillInfo _billInfo = createBillInfoObject();
                _billInfo.BillId = _billId;
                _billInfo.BillNo = "B" + _billId;

                new BllBillInfo().InsertOrUpdate(_billInfo);
            }



            /*ReportInvoice rpt = new ReportInvoice();

            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rpt.Database.Tables)
            {
                SetTableLogin(tbCurrent);
            }

            rpt.SetParameterValue("@billid", _billId);
            
            FormReport frm = new FormReport();
            frm.Text = "Invoice";
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.Visible = true;*/


            ReportDocument reportDocument = new ReportDocument();
            string filePath = String.Format("{0}\\Invoice.rpt", System.Configuration.ConfigurationManager.AppSettings["ReportFolderPath"]);

            reportDocument.Load(filePath);



            reportDocument.Refresh();
            reportDocument.SetParameterValue("@billid", _billId);
            reportDocument.SetParameterValue("@billid", _billId, reportDocument.Subreports[0].Name.ToString());


            FormReport frm = new FormReport();
            frm.Text = "Invoice";
            frm.crystalReportViewer1.ReportSource = reportDocument;
            frm.Visible = true;

            btnSave.Enabled = true;
        }

        private void SetTableLogin(CrystalDecisions.CrystalReports.Engine.Table table)
        {
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent = table.LogOnInfo;

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            var builder = new SqlConnectionStringBuilder(connectionString);
            //var dataSource = builder.DataSource;

            tliCurrent.ConnectionInfo.UserID = builder.UserID;  //"sa";
            tliCurrent.ConnectionInfo.Password = builder.Password;  //"aziz123";
            tliCurrent.ConnectionInfo.DatabaseName = builder.InitialCatalog;    //"Restaurant_DB"; //Database is not needed for Oracle & MS Access
            tliCurrent.ConnectionInfo.ServerName = builder.DataSource;  //"NIMBLE\\SQL2K8";
            table.ApplyLogOnInfo(tliCurrent);
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                btnRemove.Enabled = false;
                if (ListView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            btnUpdate.Enabled = true;

            cmbMenuItem.SelectedValue = Convert.ToInt32(ListView1.FocusedItem.SubItems[1].Text);
            txtPrice.Text = ListView1.FocusedItem.SubItems[3].Text;
            txtSaleQty.Text = ListView1.FocusedItem.SubItems[4].Text;
            cmbMenuItem.Text = ListView1.FocusedItem.SubItems[2].Text;

            cmbMenuItem.Enabled = false;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                btnUpdate.Enabled = false;
                cmbMenuItem.Enabled = true;

                BillDetails billDetails = new BillDetails();
                billDetails.BillId = _billId;
                billDetails.MenuItemId = Convert.ToInt32(ListView1.FocusedItem.SubItems[1].Text);
                billDetails.Quantity = Convert.ToInt32(txtSaleQty.Text);
                billDetails.UnitPrice = Convert.ToDecimal(ListView1.FocusedItem.SubItems[3].Text);
                billDetails.IsDiscountAvailable = false;
                billDetails.TotalPrice = Convert.ToDecimal(txtTotalAmount.Text);
                billDetails.ReceivedBy = BaseObject.User_ID;
                billDetails.IsDeleted = false;

                new BllTempBillDetails().InsertOrUpdate(billDetails);

                for (int j = 0; j <= ListView1.Items.Count - 1; j++)
                {
                    if (ListView1.Items[j].SubItems[1].Text == ListView1.FocusedItem.SubItems[1].Text)
                    {
                        ListView1.Items[j].SubItems[3].Text = txtPrice.Text;
                        ListView1.Items[j].SubItems[4].Text = txtSaleQty.Text;
                        ListView1.Items[j].SubItems[5].Text = txtTotalAmount.Text;
                        txtSubTotal.Text = subtot().ToString();
                        Calculate();

                        BillInfo billInfo = createBillInfoObject();

                        new BllBillInfo().InsertOrUpdate(billInfo);

                        cmbMenuItem.Text = "";
                        txtPrice.Text = "";
                        txtSaleQty.Text = "";
                        txtTotalAmount.Text = "";

                        //cmbMenuItem.Focus();
                        txtMenuCode.Focus();
                        return;

                    }

                }

                
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMenuCode_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtMenuCode_Leave(object sender, EventArgs e)
        {
            if (txtMenuCode.Text != "")
            {
                int i = new BllMenuItem().GetMenuItemIdByMenuCode(txtMenuCode.Text.Trim());
                if (i == 0)
                {
                    KryptonMessageBox.Show("Please provide valid Menu Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMenuCode.Focus();
                    return;
                }

                if ((int)cmbMenuItem.SelectedValue == i)
                {
                    cmbMenuItem.SelectedIndex = 1;
                }

                cmbMenuItem.SelectedValue = i;
            }
        }
    }
}
