namespace Windows.UserControls
{
    partial class UcAddEditMenuCategory
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
            this.TbName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PnTop)).BeginInit();
            this.PnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnBottom)).BeginInit();
            this.PnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnBack)).BeginInit();
            this.PnBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtClose
            // 
            this.BtClose.TabIndex = 1;
            this.BtClose.Values.Text = "Close";
            // 
            // BtSave
            // 
            this.BtSave.TabIndex = 0;
            this.BtSave.Values.Text = "Save";
            // 
            // PnBottom
            // 
            this.PnBottom.TabIndex = 2;
            // 
            // PnBack
            // 
            this.PnBack.Controls.Add(this.TbName);
            this.PnBack.Controls.Add(this.kryptonLabel1);
            this.PnBack.TabIndex = 1;
            this.PnBack.Controls.SetChildIndex(this.kryptonLabel1, 0);
            this.PnBack.Controls.SetChildIndex(this.TbName, 0);
            // 
            // LblHeader
            // 
            this.LblHeader.Size = new System.Drawing.Size(147, 29);
            this.LblHeader.Values.Text = "Menu Category";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(104, 34);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Name";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(215, 34);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(195, 20);
            this.TbName.TabIndex = 1;
            // 
            // UcAddEditMenuCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UcAddEditMenuCategory";
            ((System.ComponentModel.ISupportInitialize)(this.PnTop)).EndInit();
            this.PnTop.ResumeLayout(false);
            this.PnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnBottom)).EndInit();
            this.PnBottom.ResumeLayout(false);
            this.PnBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnBack)).EndInit();
            this.PnBack.ResumeLayout(false);
            this.PnBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TbName;
    }
}
