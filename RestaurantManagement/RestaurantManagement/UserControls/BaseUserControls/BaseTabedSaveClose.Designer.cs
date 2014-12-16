namespace Windows.UserControls
{
    partial class BaseTabedSaveClose
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
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.PnTop)).BeginInit();
            this.PnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnBottom)).BeginInit();
            this.PnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnBack)).BeginInit();
            this.PnBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtClose
            // 
            this.BtClose.Location = new System.Drawing.Point(752, 9);
            this.BtClose.Values.Text = "Close";
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(641, 9);
            this.BtSave.Values.Text = "Save";
            // 
            // PnTop
            // 
            this.PnTop.Size = new System.Drawing.Size(856, 40);
            // 
            // PnBottom
            // 
            this.PnBottom.Location = new System.Drawing.Point(0, 514);
            this.PnBottom.Size = new System.Drawing.Size(856, 52);
            // 
            // PnBack
            // 
            this.PnBack.Controls.Add(this.kryptonNavigator1);
            this.PnBack.Size = new System.Drawing.Size(856, 474);
            this.PnBack.Controls.SetChildIndex(this.kryptonNavigator1, 0);
            // 
            // LblHeader
            // 
            this.LblHeader.Values.Text = "Title";
            // 
            // kryptonNavigator1
            // 
            // 
            // 
            // 
            this.kryptonNavigator1.Button.CloseButton.AllowInheritExtraText = false;
            this.kryptonNavigator1.Button.CloseButton.AllowInheritImage = false;
            this.kryptonNavigator1.Button.CloseButton.AllowInheritText = false;
            this.kryptonNavigator1.Button.CloseButton.AllowInheritToolTipTitle = false;
            this.kryptonNavigator1.Button.CloseButton.UniqueName = "E160DBD06DD94F77DAB1E4FFF8AC9E1A";
            this.kryptonNavigator1.Location = new System.Drawing.Point(3, 0);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Size = new System.Drawing.Size(850, 473);
            this.kryptonNavigator1.TabIndex = 3;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // BaseTabedSaveClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "BaseTabedSaveClose";
            this.Size = new System.Drawing.Size(856, 566);
            ((System.ComponentModel.ISupportInitialize)(this.PnTop)).EndInit();
            this.PnTop.ResumeLayout(false);
            this.PnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnBottom)).EndInit();
            this.PnBottom.ResumeLayout(false);
            this.PnBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnBack)).EndInit();
            this.PnBack.ResumeLayout(false);
            this.PnBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;

    }
}
