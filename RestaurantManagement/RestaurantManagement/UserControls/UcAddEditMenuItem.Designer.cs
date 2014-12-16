namespace Windows.UserControls
{
    partial class UcAddEditMenuItem
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.TbName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TbCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TbPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TbDescription = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.CmbCategory = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbFoorOrBeverage = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PnTop)).BeginInit();
            this.PnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnBottom)).BeginInit();
            this.PnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnBack)).BeginInit();
            this.PnBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFoorOrBeverage)).BeginInit();
            this.SuspendLayout();
            // 
            // BtClose
            // 
            this.BtClose.Location = new System.Drawing.Point(477, 11);
            this.BtClose.TabIndex = 1;
            this.BtClose.Values.Text = "Close";
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(381, 11);
            this.BtSave.TabIndex = 0;
            this.BtSave.Values.Text = "Save";
            // 
            // PnTop
            // 
            this.PnTop.Size = new System.Drawing.Size(582, 40);
            // 
            // PnBottom
            // 
            this.PnBottom.Location = new System.Drawing.Point(0, 345);
            this.PnBottom.Size = new System.Drawing.Size(582, 52);
            // 
            // PnBack
            // 
            this.PnBack.Controls.Add(this.cmbFoorOrBeverage);
            this.PnBack.Controls.Add(this.kryptonLabel6);
            this.PnBack.Controls.Add(this.CmbCategory);
            this.PnBack.Controls.Add(this.TbDescription);
            this.PnBack.Controls.Add(this.TbPrice);
            this.PnBack.Controls.Add(this.TbCode);
            this.PnBack.Controls.Add(this.TbName);
            this.PnBack.Controls.Add(this.kryptonLabel5);
            this.PnBack.Controls.Add(this.kryptonLabel4);
            this.PnBack.Controls.Add(this.kryptonLabel3);
            this.PnBack.Controls.Add(this.kryptonLabel2);
            this.PnBack.Controls.Add(this.kryptonLabel1);
            this.PnBack.Size = new System.Drawing.Size(582, 305);
            this.PnBack.TabIndex = 0;
            this.PnBack.Controls.SetChildIndex(this.kryptonLabel1, 0);
            this.PnBack.Controls.SetChildIndex(this.kryptonLabel2, 0);
            this.PnBack.Controls.SetChildIndex(this.kryptonLabel3, 0);
            this.PnBack.Controls.SetChildIndex(this.kryptonLabel4, 0);
            this.PnBack.Controls.SetChildIndex(this.kryptonLabel5, 0);
            this.PnBack.Controls.SetChildIndex(this.TbName, 0);
            this.PnBack.Controls.SetChildIndex(this.TbCode, 0);
            this.PnBack.Controls.SetChildIndex(this.TbPrice, 0);
            this.PnBack.Controls.SetChildIndex(this.TbDescription, 0);
            this.PnBack.Controls.SetChildIndex(this.CmbCategory, 0);
            this.PnBack.Controls.SetChildIndex(this.kryptonLabel6, 0);
            this.PnBack.Controls.SetChildIndex(this.cmbFoorOrBeverage, 0);
            // 
            // LblHeader
            // 
            this.LblHeader.Size = new System.Drawing.Size(108, 29);
            this.LblHeader.Values.Text = "Menu Item";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(81, 33);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Name";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(81, 73);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(39, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Code";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(81, 117);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(37, 20);
            this.kryptonLabel3.TabIndex = 3;
            this.kryptonLabel3.Values.Text = "Price";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(81, 162);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "Category";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(81, 231);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel5.TabIndex = 3;
            this.kryptonLabel5.Values.Text = "Description";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(201, 33);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(256, 20);
            this.TbName.TabIndex = 0;
            // 
            // TbCode
            // 
            this.TbCode.Location = new System.Drawing.Point(201, 73);
            this.TbCode.Name = "TbCode";
            this.TbCode.Size = new System.Drawing.Size(256, 20);
            this.TbCode.TabIndex = 1;
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(201, 117);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(256, 20);
            this.TbPrice.TabIndex = 2;
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(201, 237);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(256, 54);
            this.TbDescription.TabIndex = 5;
            // 
            // CmbCategory
            // 
            this.CmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbCategory.DropDownWidth = 121;
            this.CmbCategory.Location = new System.Drawing.Point(201, 161);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(256, 21);
            this.CmbCategory.TabIndex = 3;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(81, 200);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(93, 20);
            this.kryptonLabel6.TabIndex = 5;
            this.kryptonLabel6.Values.Text = "Food/Beverage";
            // 
            // cmbFoorOrBeverage
            // 
            this.cmbFoorOrBeverage.DropDownWidth = 256;
            this.cmbFoorOrBeverage.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
            this.cmbFoorOrBeverage.Location = new System.Drawing.Point(201, 198);
            this.cmbFoorOrBeverage.Name = "cmbFoorOrBeverage";
            this.cmbFoorOrBeverage.Size = new System.Drawing.Size(256, 21);
            this.cmbFoorOrBeverage.TabIndex = 4;
            this.cmbFoorOrBeverage.Text = "Food";
            // 
            // UcAddEditMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UcAddEditMenuItem";
            this.Size = new System.Drawing.Size(582, 397);
            ((System.ComponentModel.ISupportInitialize)(this.PnTop)).EndInit();
            this.PnTop.ResumeLayout(false);
            this.PnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnBottom)).EndInit();
            this.PnBottom.ResumeLayout(false);
            this.PnBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnBack)).EndInit();
            this.PnBack.ResumeLayout(false);
            this.PnBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFoorOrBeverage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TbDescription;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TbPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TbCode;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TbName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CmbCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbFoorOrBeverage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
    }
}
