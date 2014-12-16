namespace Windows.UserControls
{
    partial class UcMenuItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcMenuItems));
            this.MenuItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.BtDelete.Values.Text = "Delete";
            // 
            // BtEdit
            // 
            this.BtEdit.Values.Text = "Edit";
            // 
            // BtNew
            // 
            this.BtNew.Values.Text = "New";
            // 
            // LblDetails
            // 
            this.LblDetails.Values.Text = "Description";
            // 
            // LblTitle
            // 
            this.LblTitle.Size = new System.Drawing.Size(116, 29);
            this.LblTitle.Values.Text = "Menu Items";
            // 
            // Dgv
            // 
            this.Dgv.AutoGenerateColumns = false;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuItemCode,
            this.MenuItemName,
            this.Price,
            this.MenuCategoryId,
            this.MenuCategoryName,
            this.Description});
            this.Dgv.DataSource = this.Bd;
            // 
            // PbPicture
            // 
            this.PbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.PbPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PbPicture.Image = ((System.Drawing.Image)(resources.GetObject("PbPicture.Image")));
            this.PbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // MenuItemCode
            // 
            this.MenuItemCode.DataPropertyName = "MenuItemCode";
            this.MenuItemCode.HeaderText = "Code";
            this.MenuItemCode.Name = "MenuItemCode";
            // 
            // MenuItemName
            // 
            this.MenuItemName.DataPropertyName = "MenuItemName";
            this.MenuItemName.HeaderText = "Name";
            this.MenuItemName.Name = "MenuItemName";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // MenuCategoryId
            // 
            this.MenuCategoryId.DataPropertyName = "MenuCategoryId";
            this.MenuCategoryId.HeaderText = "Category Id";
            this.MenuCategoryId.Name = "MenuCategoryId";
            // 
            // MenuCategoryName
            // 
            this.MenuCategoryName.DataPropertyName = "MenuCategoryName";
            this.MenuCategoryName.HeaderText = "Category";
            this.MenuCategoryName.Name = "MenuCategoryName";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // UcMenuItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UcMenuItems";
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

        private System.Windows.Forms.DataGridViewTextBoxColumn MenuItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;


    }
}
