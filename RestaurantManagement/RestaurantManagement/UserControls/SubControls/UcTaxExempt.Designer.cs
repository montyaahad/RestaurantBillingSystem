namespace Windows.UserControls.SubControls
{
    partial class UcTaxExempt
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
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.TbService = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TbVAT = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TbLuxury = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.CbService = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.CbVAT = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.CbLuxury = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonWrapLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonWrapLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.TbRate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TbTax = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TbNetRate = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.TbTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonWrapLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionOverlap = 1D;
            this.kryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonBorderEdge1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonWrapLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonWrapLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonWrapLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.TbTotal);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonWrapLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.TbNetRate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.TbService);
            this.kryptonGroupBox1.Panel.Controls.Add(this.TbTax);
            this.kryptonGroupBox1.Panel.Controls.Add(this.TbVAT);
            this.kryptonGroupBox1.Panel.Controls.Add(this.TbRate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.TbLuxury);
            this.kryptonGroupBox1.Panel.Controls.Add(this.CbService);
            this.kryptonGroupBox1.Panel.Controls.Add(this.CbVAT);
            this.kryptonGroupBox1.Panel.Controls.Add(this.CbLuxury);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(366, 288);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Text = "Tax Exempt";
            this.kryptonGroupBox1.Values.Heading = "Tax Exempt";
            // 
            // TbService
            // 
            this.TbService.Location = new System.Drawing.Point(68, 55);
            this.TbService.Name = "TbService";
            this.TbService.Size = new System.Drawing.Size(51, 20);
            this.TbService.TabIndex = 4;
            // 
            // TbVAT
            // 
            this.TbVAT.Location = new System.Drawing.Point(68, 29);
            this.TbVAT.Name = "TbVAT";
            this.TbVAT.Size = new System.Drawing.Size(51, 20);
            this.TbVAT.TabIndex = 4;
            // 
            // TbLuxury
            // 
            this.TbLuxury.Location = new System.Drawing.Point(68, 3);
            this.TbLuxury.Name = "TbLuxury";
            this.TbLuxury.Size = new System.Drawing.Size(51, 20);
            this.TbLuxury.TabIndex = 4;
            // 
            // CbService
            // 
            this.CbService.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.CbService.Location = new System.Drawing.Point(3, 55);
            this.CbService.Name = "CbService";
            this.CbService.Size = new System.Drawing.Size(62, 20);
            this.CbService.TabIndex = 3;
            this.CbService.Text = "Service";
            this.CbService.Values.Text = "Service";
            // 
            // CbVAT
            // 
            this.CbVAT.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.CbVAT.Location = new System.Drawing.Point(3, 29);
            this.CbVAT.Name = "CbVAT";
            this.CbVAT.Size = new System.Drawing.Size(46, 20);
            this.CbVAT.TabIndex = 3;
            this.CbVAT.Text = "VAT";
            this.CbVAT.Values.Text = "VAT";
            // 
            // CbLuxury
            // 
            this.CbLuxury.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.CbLuxury.Location = new System.Drawing.Point(3, 3);
            this.CbLuxury.Name = "CbLuxury";
            this.CbLuxury.Size = new System.Drawing.Size(59, 20);
            this.CbLuxury.TabIndex = 3;
            this.CbLuxury.Text = "Luxury";
            this.CbLuxury.Values.Text = "Luxury";
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(141, 8);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(30, 15);
            this.kryptonWrapLabel1.Text = "Rate";
            // 
            // kryptonWrapLabel2
            // 
            this.kryptonWrapLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel2.Location = new System.Drawing.Point(141, 34);
            this.kryptonWrapLabel2.Name = "kryptonWrapLabel2";
            this.kryptonWrapLabel2.Size = new System.Drawing.Size(25, 15);
            this.kryptonWrapLabel2.Text = "Tax";
            // 
            // kryptonWrapLabel3
            // 
            this.kryptonWrapLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel3.Location = new System.Drawing.Point(141, 60);
            this.kryptonWrapLabel3.Name = "kryptonWrapLabel3";
            this.kryptonWrapLabel3.Size = new System.Drawing.Size(52, 15);
            this.kryptonWrapLabel3.Text = "Net Rate";
            // 
            // TbRate
            // 
            this.TbRate.Location = new System.Drawing.Point(198, 3);
            this.TbRate.Name = "TbRate";
            this.TbRate.Size = new System.Drawing.Size(51, 20);
            this.TbRate.TabIndex = 4;
            // 
            // TbTax
            // 
            this.TbTax.Location = new System.Drawing.Point(198, 29);
            this.TbTax.Name = "TbTax";
            this.TbTax.Size = new System.Drawing.Size(51, 20);
            this.TbTax.TabIndex = 4;
            // 
            // TbNetRate
            // 
            this.TbNetRate.Location = new System.Drawing.Point(198, 55);
            this.TbNetRate.Name = "TbNetRate";
            this.TbNetRate.Size = new System.Drawing.Size(51, 20);
            this.TbNetRate.TabIndex = 4;
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(127, 81);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(127, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // TbTotal
            // 
            this.TbTotal.Location = new System.Drawing.Point(198, 89);
            this.TbTotal.Name = "TbTotal";
            this.TbTotal.Size = new System.Drawing.Size(51, 20);
            this.TbTotal.TabIndex = 4;
            // 
            // kryptonWrapLabel4
            // 
            this.kryptonWrapLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel4.Location = new System.Drawing.Point(141, 89);
            this.kryptonWrapLabel4.Name = "kryptonWrapLabel4";
            this.kryptonWrapLabel4.Size = new System.Drawing.Size(34, 15);
            this.kryptonWrapLabel4.Text = "Total";
            // 
            // UcTaxExempt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonGroupBox1);
            this.Name = "UcTaxExempt";
            this.Size = new System.Drawing.Size(366, 288);
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox CbService;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox CbVAT;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox CbLuxury;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TbTotal;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TbNetRate;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TbTax;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TbRate;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TbService;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TbVAT;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TbLuxury;
    }
}
