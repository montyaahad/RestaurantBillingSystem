namespace Windows.UserControls
{
    partial class UcMenuCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcMenuCategory));
            this.MenuCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // pnBack
            // 
            this.pnBack.Size = new System.Drawing.Size(615, 247);
            // 
            // pnBottom
            // 
            this.pnBottom.Location = new System.Drawing.Point(0, 338);
            this.pnBottom.Size = new System.Drawing.Size(615, 46);
            // 
            // pnTop
            // 
            this.pnTop.Size = new System.Drawing.Size(615, 91);
            // 
            // BtClose
            // 
            this.BtClose.Location = new System.Drawing.Point(497, 6);
            this.BtClose.Values.Text = "Close";
            // 
            // BtDelete
            // 
            this.BtDelete.Location = new System.Drawing.Point(5, 5);
            this.BtDelete.Values.Text = "Delete";
            this.BtDelete.Visible = false;
            // 
            // BtEdit
            // 
            this.BtEdit.Location = new System.Drawing.Point(401, 6);
            this.BtEdit.Values.Text = "Edit";
            // 
            // BtNew
            // 
            this.BtNew.Location = new System.Drawing.Point(305, 6);
            this.BtNew.Values.Text = "New";
            // 
            // LblDetails
            // 
            this.LblDetails.Values.Text = "Description";
            // 
            // LblTitle
            // 
            this.LblTitle.Size = new System.Drawing.Size(147, 29);
            this.LblTitle.Values.Text = "Menu Category";
            // 
            // Dgv
            // 
            this.Dgv.AutoGenerateColumns = false;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuCategoryId,
            this.MenuCategoryName});
            this.Dgv.DataSource = this.Bd;
            this.Dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgv.Size = new System.Drawing.Size(613, 246);
            // 
            // PbPicture
            // 
            this.PbPicture.Image = ((System.Drawing.Image)(resources.GetObject("PbPicture.Image")));
            this.PbPicture.Location = new System.Drawing.Point(507, 6);
            this.PbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // MenuCategoryId
            // 
            this.MenuCategoryId.DataPropertyName = "MenuCategoryId";
            this.MenuCategoryId.HeaderText = "Id";
            this.MenuCategoryId.Name = "MenuCategoryId";
            // 
            // MenuCategoryName
            // 
            this.MenuCategoryName.DataPropertyName = "MenuCategoryName";
            this.MenuCategoryName.HeaderText = "Menu Category";
            this.MenuCategoryName.Name = "MenuCategoryName";
            // 
            // UcMenuCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UcMenuCategory";
            this.Size = new System.Drawing.Size(615, 384);
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

        private System.Windows.Forms.DataGridViewTextBoxColumn MenuCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuCategoryName;


    }
}
