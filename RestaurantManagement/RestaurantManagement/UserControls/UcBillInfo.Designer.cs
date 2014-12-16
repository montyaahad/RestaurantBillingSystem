namespace Windows.UserControls
{
    partial class UcBillInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBillInfo));
            this.TableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KotNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VatAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnBack)).BeginInit();
            this.pnBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnBottom)).BeginInit();
            this.pnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnTop)).BeginInit();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bd)).BeginInit();
            this.SuspendLayout();
            // 
            // BtClose
            // 
            this.BtClose.Values.Text = "Close";
            // 
            // BtDelete
            // 
            this.BtDelete.Location = new System.Drawing.Point(143, 6);
            this.BtDelete.Values.Text = "Delete";
            this.BtDelete.Visible = false;
            // 
            // BtEdit
            // 
            this.BtEdit.Location = new System.Drawing.Point(469, 6);
            this.BtEdit.Values.Text = "Edit";
            // 
            // BtNew
            // 
            this.BtNew.Location = new System.Drawing.Point(373, 6);
            this.BtNew.Values.Text = "New";
            // 
            // LblDetails
            // 
            this.LblDetails.Values.Text = "Description";
            // 
            // LblTitle
            // 
            this.LblTitle.Size = new System.Drawing.Size(48, 29);
            this.LblTitle.Values.Text = "Bills";
            // 
            // Dgv
            // 
            this.Dgv.AutoGenerateColumns = false;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableId,
            this.BillNo,
            this.KotNo,
            this.SubTotal,
            this.DiscountAmount,
            this.VatAmount,
            this.GrandTotal});
            this.Dgv.DataSource = this.Bd;
            // 
            // PbPicture
            // 
            this.PbPicture.Image = ((System.Drawing.Image)(resources.GetObject("PbPicture.Image")));
            this.PbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // TableId
            // 
            this.TableId.DataPropertyName = "TableId";
            this.TableId.HeaderText = "Table";
            this.TableId.Name = "TableId";
            // 
            // BillNo
            // 
            this.BillNo.DataPropertyName = "BillNo";
            this.BillNo.HeaderText = "Bill No";
            this.BillNo.Name = "BillNo";
            // 
            // KotNo
            // 
            this.KotNo.DataPropertyName = "KotNo";
            this.KotNo.HeaderText = "KOT";
            this.KotNo.Name = "KotNo";
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.DataPropertyName = "DiscountAmount";
            this.DiscountAmount.HeaderText = "Discount";
            this.DiscountAmount.Name = "DiscountAmount";
            // 
            // VatAmount
            // 
            this.VatAmount.DataPropertyName = "VatAmount";
            this.VatAmount.HeaderText = "VAT";
            this.VatAmount.Name = "VatAmount";
            // 
            // GrandTotal
            // 
            this.GrandTotal.DataPropertyName = "GrandTotal";
            this.GrandTotal.HeaderText = "Gramd Total";
            this.GrandTotal.Name = "GrandTotal";
            // 
            // UcBillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UcBillInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pnBack)).EndInit();
            this.pnBack.ResumeLayout(false);
            this.pnBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnBottom)).EndInit();
            this.pnBottom.ResumeLayout(false);
            this.pnBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnTop)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn TableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KotNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn VatAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrandTotal;


    }
}
