namespace Windows.UserControls.SubControls
{
    partial class UcVenue
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
            this.TbVenue = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // TbVenue
            // 
            this.TbVenue.Location = new System.Drawing.Point(0, 0);
            this.TbVenue.Multiline = true;
            this.TbVenue.Name = "TbVenue";
            this.TbVenue.Size = new System.Drawing.Size(255, 44);
            this.TbVenue.TabIndex = 0;
            this.TbVenue.WordWrap = false;
            // 
            // UcVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TbVenue);
            this.Name = "UcVenue";
            this.Size = new System.Drawing.Size(255, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonTextBox TbVenue;

    }
}
