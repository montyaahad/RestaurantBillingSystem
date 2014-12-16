namespace Windows.UserControls.BaseUserControls
{
    partial class BaseAddEdit
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
            this.NudShortKey = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.RtbDescription = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.TbName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TbAlias = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LbShortKey = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LbDescription = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LbAlias = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
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
            this.BtClose.Values.Text = "Close";
            // 
            // BtSave
            // 
            this.BtSave.Values.Text = "Save";
            // 
            // PnBottom
            // 
            this.PnBottom.Location = new System.Drawing.Point(0, 208);
            // 
            // PnBack
            // 
            this.PnBack.Controls.Add(this.NudShortKey);
            this.PnBack.Controls.Add(this.RtbDescription);
            this.PnBack.Controls.Add(this.TbName);
            this.PnBack.Controls.Add(this.TbAlias);
            this.PnBack.Controls.Add(this.LbShortKey);
            this.PnBack.Controls.Add(this.LbDescription);
            this.PnBack.Controls.Add(this.LbName);
            this.PnBack.Controls.Add(this.LbAlias);
            this.PnBack.Size = new System.Drawing.Size(450, 168);
            this.PnBack.Controls.SetChildIndex(this.LbAlias, 0);
            this.PnBack.Controls.SetChildIndex(this.LbName, 0);
            this.PnBack.Controls.SetChildIndex(this.LbDescription, 0);
            this.PnBack.Controls.SetChildIndex(this.LbShortKey, 0);
            this.PnBack.Controls.SetChildIndex(this.TbAlias, 0);
            this.PnBack.Controls.SetChildIndex(this.TbName, 0);
            this.PnBack.Controls.SetChildIndex(this.RtbDescription, 0);
            this.PnBack.Controls.SetChildIndex(this.NudShortKey, 0);
            // 
            // LblHeader
            // 
            this.LblHeader.Values.Text = "Title";
            // 
            // NudShortKey
            // 
            this.NudShortKey.Location = new System.Drawing.Point(364, 25);
            this.NudShortKey.Name = "NudShortKey";
            this.NudShortKey.Size = new System.Drawing.Size(69, 22);
            this.NudShortKey.TabIndex = 18;
            // 
            // RtbDescription
            // 
            this.RtbDescription.Location = new System.Drawing.Point(93, 77);
            this.RtbDescription.Name = "RtbDescription";
            this.RtbDescription.Size = new System.Drawing.Size(340, 72);
            this.RtbDescription.TabIndex = 17;
            this.RtbDescription.Text = "";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(93, 51);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(340, 20);
            this.TbName.TabIndex = 16;
            // 
            // TbAlias
            // 
            this.TbAlias.Location = new System.Drawing.Point(93, 25);
            this.TbAlias.Name = "TbAlias";
            this.TbAlias.Size = new System.Drawing.Size(99, 20);
            this.TbAlias.TabIndex = 15;
            // 
            // LbShortKey
            // 
            this.LbShortKey.Location = new System.Drawing.Point(301, 25);
            this.LbShortKey.Name = "LbShortKey";
            this.LbShortKey.Size = new System.Drawing.Size(57, 20);
            this.LbShortKey.TabIndex = 14;
            this.LbShortKey.Values.Text = "Sort key:";
            // 
            // LbDescription
            // 
            this.LbDescription.Location = new System.Drawing.Point(12, 77);
            this.LbDescription.Name = "LbDescription";
            this.LbDescription.Size = new System.Drawing.Size(75, 20);
            this.LbDescription.TabIndex = 13;
            this.LbDescription.Values.Text = "Description:";
            // 
            // LbName
            // 
            this.LbName.Location = new System.Drawing.Point(12, 51);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(46, 20);
            this.LbName.TabIndex = 12;
            this.LbName.Values.Text = "Name:";
            // 
            // LbAlias
            // 
            this.LbAlias.Location = new System.Drawing.Point(12, 25);
            this.LbAlias.Name = "LbAlias";
            this.LbAlias.Size = new System.Drawing.Size(39, 20);
            this.LbAlias.TabIndex = 11;
            this.LbAlias.Values.Text = "Alias:";
            // 
            // BaseAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "BaseAddEdit";
            this.Size = new System.Drawing.Size(450, 260);
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

        private ComponentFactory.Krypton.Toolkit.KryptonLabel LbName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LbAlias;
        public ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown NudShortKey;
        public ComponentFactory.Krypton.Toolkit.KryptonRichTextBox RtbDescription;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TbName;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TbAlias;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel LbShortKey;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel LbDescription;

    }
}
