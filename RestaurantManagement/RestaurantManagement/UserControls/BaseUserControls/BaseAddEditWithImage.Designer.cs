namespace Windows.UserControls.BaseUserControls
{
    partial class BaseAddEditWithImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseAddEditWithImage));
            this.NudShortKey = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.TbName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TbAlias = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LbShortKey = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LbName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LbAlias = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.BtRemove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PnTop)).BeginInit();
            this.PnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnBottom)).BeginInit();
            this.PnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnBack)).BeginInit();
            this.PnBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
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
            this.PnBack.Controls.Add(this.BtRemove);
            this.PnBack.Controls.Add(this.BtAdd);
            this.PnBack.Controls.Add(this.PbImage);
            this.PnBack.Controls.Add(this.NudShortKey);
            this.PnBack.Controls.Add(this.TbName);
            this.PnBack.Controls.Add(this.TbAlias);
            this.PnBack.Controls.Add(this.LbShortKey);
            this.PnBack.Controls.Add(this.LbName);
            this.PnBack.Controls.Add(this.LbAlias);
            this.PnBack.Size = new System.Drawing.Size(450, 168);
            this.PnBack.Controls.SetChildIndex(this.LbAlias, 0);
            this.PnBack.Controls.SetChildIndex(this.LbName, 0);
            this.PnBack.Controls.SetChildIndex(this.LbShortKey, 0);
            this.PnBack.Controls.SetChildIndex(this.TbAlias, 0);
            this.PnBack.Controls.SetChildIndex(this.TbName, 0);
            this.PnBack.Controls.SetChildIndex(this.NudShortKey, 0);
            this.PnBack.Controls.SetChildIndex(this.PbImage, 0);
            this.PnBack.Controls.SetChildIndex(this.BtAdd, 0);
            this.PnBack.Controls.SetChildIndex(this.BtRemove, 0);
            // 
            // LblHeader
            // 
            this.LblHeader.Values.Text = "Title";
            // 
            // NudShortKey
            // 
            this.NudShortKey.Location = new System.Drawing.Point(93, 69);
            this.NudShortKey.Name = "NudShortKey";
            this.NudShortKey.Size = new System.Drawing.Size(69, 22);
            this.NudShortKey.TabIndex = 18;
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(93, 31);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(188, 20);
            this.TbName.TabIndex = 16;
            // 
            // TbAlias
            // 
            this.TbAlias.Location = new System.Drawing.Point(93, 5);
            this.TbAlias.Name = "TbAlias";
            this.TbAlias.Size = new System.Drawing.Size(99, 20);
            this.TbAlias.TabIndex = 15;
            // 
            // LbShortKey
            // 
            this.LbShortKey.Location = new System.Drawing.Point(12, 69);
            this.LbShortKey.Name = "LbShortKey";
            this.LbShortKey.Size = new System.Drawing.Size(57, 20);
            this.LbShortKey.TabIndex = 14;
            this.LbShortKey.Values.Text = "Sort key:";
            // 
            // LbName
            // 
            this.LbName.Location = new System.Drawing.Point(12, 31);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(46, 20);
            this.LbName.TabIndex = 12;
            this.LbName.Values.Text = "Name:";
            // 
            // LbAlias
            // 
            this.LbAlias.Location = new System.Drawing.Point(12, 5);
            this.LbAlias.Name = "LbAlias";
            this.LbAlias.Size = new System.Drawing.Size(39, 20);
            this.LbAlias.TabIndex = 11;
            this.LbAlias.Values.Text = "Alias:";
            // 
            // BtRemove
            // 
            this.BtRemove.Location = new System.Drawing.Point(254, 133);
            this.BtRemove.Name = "BtRemove";
            this.BtRemove.Size = new System.Drawing.Size(28, 25);
            this.BtRemove.TabIndex = 26;
            this.BtRemove.Values.Image = ((System.Drawing.Image)(resources.GetObject("BtRemove.Values.Image")));
            this.BtRemove.Values.Text = "";
            this.BtRemove.Click += new System.EventHandler(this.BtRemove_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Location = new System.Drawing.Point(254, 102);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(28, 25);
            this.BtAdd.TabIndex = 25;
            this.BtAdd.Values.Image = ((System.Drawing.Image)(resources.GetObject("BtAdd.Values.Image")));
            this.BtAdd.Values.Text = "";
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // PbImage
            // 
            this.PbImage.BackColor = System.Drawing.Color.Transparent;
            this.PbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbImage.Location = new System.Drawing.Point(287, 6);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(155, 152);
            this.PbImage.TabIndex = 24;
            this.PbImage.TabStop = false;
            // 
            // BaseAddEditWithImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "BaseAddEditWithImage";
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
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel LbName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LbAlias;
        public ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown NudShortKey;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TbName;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TbAlias;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel LbShortKey;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtRemove;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtAdd;
        public System.Windows.Forms.PictureBox PbImage;

    }
}
