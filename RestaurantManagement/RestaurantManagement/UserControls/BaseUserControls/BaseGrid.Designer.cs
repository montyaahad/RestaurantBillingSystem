namespace Windows.UserControls.BaseUserControls
{
    partial class BaseGrid
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseGrid));
            this.pnBack = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonBorderEdge5 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge3 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.pnBottom = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonBorderEdge7 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge6 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.BredGridBottom = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.BtClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtNew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bredBaseGrid = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.pnTop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.LblDetails = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LblTitle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.PbPicture = new System.Windows.Forms.PictureBox();
            this.kryptonBorderEdge8 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge4 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge2 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.Dgv = new Windows.UserControls.BaseUserControls.OpenGridView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnBack)).BeginInit();
            this.pnBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnBottom)).BeginInit();
            this.pnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnTop)).BeginInit();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBack
            // 
            this.pnBack.Controls.Add(this.Dgv);
            this.pnBack.Controls.Add(this.kryptonBorderEdge5);
            this.pnBack.Controls.Add(this.kryptonBorderEdge3);
            this.pnBack.Controls.Add(this.kryptonBorderEdge1);
            this.pnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBack.Location = new System.Drawing.Point(0, 91);
            this.pnBack.Name = "pnBack";
            this.pnBack.Size = new System.Drawing.Size(664, 288);
            this.pnBack.TabIndex = 0;
            // 
            // kryptonBorderEdge5
            // 
            this.kryptonBorderEdge5.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonBorderEdge5.Location = new System.Drawing.Point(663, 1);
            this.kryptonBorderEdge5.Name = "kryptonBorderEdge5";
            this.kryptonBorderEdge5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonBorderEdge5.Size = new System.Drawing.Size(1, 287);
            // 
            // kryptonBorderEdge3
            // 
            this.kryptonBorderEdge3.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonBorderEdge3.Location = new System.Drawing.Point(0, 1);
            this.kryptonBorderEdge3.Name = "kryptonBorderEdge3";
            this.kryptonBorderEdge3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonBorderEdge3.Size = new System.Drawing.Size(1, 287);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(664, 1);
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.kryptonBorderEdge7);
            this.pnBottom.Controls.Add(this.kryptonBorderEdge6);
            this.pnBottom.Controls.Add(this.BredGridBottom);
            this.pnBottom.Controls.Add(this.BtClose);
            this.pnBottom.Controls.Add(this.BtDelete);
            this.pnBottom.Controls.Add(this.BtEdit);
            this.pnBottom.Controls.Add(this.BtNew);
            this.pnBottom.Controls.Add(this.bredBaseGrid);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 379);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(664, 46);
            this.pnBottom.TabIndex = 3;
            // 
            // kryptonBorderEdge7
            // 
            this.kryptonBorderEdge7.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonBorderEdge7.Location = new System.Drawing.Point(663, 1);
            this.kryptonBorderEdge7.Name = "kryptonBorderEdge7";
            this.kryptonBorderEdge7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonBorderEdge7.Size = new System.Drawing.Size(1, 44);
            // 
            // kryptonBorderEdge6
            // 
            this.kryptonBorderEdge6.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonBorderEdge6.Location = new System.Drawing.Point(0, 1);
            this.kryptonBorderEdge6.Name = "kryptonBorderEdge6";
            this.kryptonBorderEdge6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonBorderEdge6.Size = new System.Drawing.Size(1, 44);
            // 
            // BredGridBottom
            // 
            this.BredGridBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BredGridBottom.Location = new System.Drawing.Point(0, 45);
            this.BredGridBottom.Name = "BredGridBottom";
            this.BredGridBottom.Size = new System.Drawing.Size(664, 1);
            this.BredGridBottom.Text = "kryptonBorderEdge1";
            // 
            // BtClose
            // 
            this.BtClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtClose.Location = new System.Drawing.Point(565, 6);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(90, 34);
            this.BtClose.TabIndex = 4;
            this.BtClose.Values.Text = "Close";
            this.BtClose.Click += new System.EventHandler(this.BtCloseClick);
            // 
            // BtDelete
            // 
            this.BtDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtDelete.Location = new System.Drawing.Point(469, 6);
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Size = new System.Drawing.Size(90, 34);
            this.BtDelete.TabIndex = 3;
            this.BtDelete.Values.Text = "Delete";
            this.BtDelete.Click += new System.EventHandler(this.BtDeleteClick);
            // 
            // BtEdit
            // 
            this.BtEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtEdit.Location = new System.Drawing.Point(373, 6);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(90, 34);
            this.BtEdit.TabIndex = 2;
            this.BtEdit.Values.Text = "Edit";
            this.BtEdit.Click += new System.EventHandler(this.BtEditClick);
            // 
            // BtNew
            // 
            this.BtNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtNew.Location = new System.Drawing.Point(277, 6);
            this.BtNew.Name = "BtNew";
            this.BtNew.Size = new System.Drawing.Size(90, 34);
            this.BtNew.TabIndex = 1;
            this.BtNew.Values.Text = "New";
            this.BtNew.Click += new System.EventHandler(this.BtNewClick);
            // 
            // bredBaseGrid
            // 
            this.bredBaseGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.bredBaseGrid.Location = new System.Drawing.Point(0, 0);
            this.bredBaseGrid.Name = "bredBaseGrid";
            this.bredBaseGrid.Size = new System.Drawing.Size(664, 1);
            this.bredBaseGrid.Text = "kryptonBorderEdge1";
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.LblDetails);
            this.pnTop.Controls.Add(this.LblTitle);
            this.pnTop.Controls.Add(this.PbPicture);
            this.pnTop.Controls.Add(this.kryptonBorderEdge8);
            this.pnTop.Controls.Add(this.kryptonBorderEdge4);
            this.pnTop.Controls.Add(this.kryptonBorderEdge2);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(664, 91);
            this.pnTop.TabIndex = 2;
            // 
            // LblDetails
            // 
            this.LblDetails.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblDetails.AutoSize = false;
            this.LblDetails.Location = new System.Drawing.Point(25, 36);
            this.LblDetails.Name = "LblDetails";
            this.LblDetails.Size = new System.Drawing.Size(412, 46);
            this.LblDetails.TabIndex = 23;
            this.LblDetails.Values.Text = "Description";
            // 
            // LblTitle
            // 
            this.LblTitle.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.LblTitle.Location = new System.Drawing.Point(21, 5);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(51, 29);
            this.LblTitle.TabIndex = 22;
            this.LblTitle.Values.Text = "Title";
            // 
            // PbPicture
            // 
            this.PbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbPicture.BackColor = System.Drawing.Color.Transparent;
            this.PbPicture.Image = ((System.Drawing.Image)(resources.GetObject("PbPicture.Image")));
            this.PbPicture.Location = new System.Drawing.Point(575, 7);
            this.PbPicture.Name = "PbPicture";
            this.PbPicture.Size = new System.Drawing.Size(80, 80);
            this.PbPicture.TabIndex = 18;
            this.PbPicture.TabStop = false;
            // 
            // kryptonBorderEdge8
            // 
            this.kryptonBorderEdge8.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonBorderEdge8.Location = new System.Drawing.Point(1, 0);
            this.kryptonBorderEdge8.Name = "kryptonBorderEdge8";
            this.kryptonBorderEdge8.Size = new System.Drawing.Size(662, 1);
            this.kryptonBorderEdge8.Text = "kryptonBorderEdge1";
            // 
            // kryptonBorderEdge4
            // 
            this.kryptonBorderEdge4.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonBorderEdge4.Location = new System.Drawing.Point(663, 0);
            this.kryptonBorderEdge4.Name = "kryptonBorderEdge4";
            this.kryptonBorderEdge4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonBorderEdge4.Size = new System.Drawing.Size(1, 91);
            // 
            // kryptonBorderEdge2
            // 
            this.kryptonBorderEdge2.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonBorderEdge2.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            this.kryptonBorderEdge2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonBorderEdge2.Size = new System.Drawing.Size(1, 91);
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv.Location = new System.Drawing.Point(1, 1);
            this.Dgv.Name = "Dgv";
            this.Dgv.Size = new System.Drawing.Size(662, 287);
            this.Dgv.TabIndex = 3;
            this.Dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCellClick);
            this.Dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellDoubleClick);
            // 
            // BaseGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBack);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnTop);
            this.Name = "BaseGrid";
            this.Size = new System.Drawing.Size(664, 425);
            ((System.ComponentModel.ISupportInitialize)(this.pnBack)).EndInit();
            this.pnBack.ResumeLayout(false);
            this.pnBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnBottom)).EndInit();
            this.pnBottom.ResumeLayout(false);
            this.pnBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnTop)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonPanel pnBack;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel pnBottom;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel pnTop;
        public ComponentFactory.Krypton.Toolkit.KryptonButton BtClose;
        public ComponentFactory.Krypton.Toolkit.KryptonButton BtDelete;
        public ComponentFactory.Krypton.Toolkit.KryptonButton BtEdit;
        public ComponentFactory.Krypton.Toolkit.KryptonButton BtNew;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel LblDetails;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel LblTitle;
        public OpenGridView Dgv;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge bredBaseGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge BredGridBottom;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge8;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge5;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge7;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge6;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge4;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge3;
        public System.Windows.Forms.PictureBox PbPicture;
    }
}
