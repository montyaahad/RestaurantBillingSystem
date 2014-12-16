namespace Windows.Forms
{
    partial class FormLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.Bred5 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.PnBack = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Bred3 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.Bred2 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.Bred1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.Bred4 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.PnTop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblHeader = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonBorderEdge3 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonBorderEdge2 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.BredBottom = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.BtnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PnBottom = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Bred = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            ((System.ComponentModel.ISupportInitialize)(this.PnBack)).BeginInit();
            this.PnBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnTop)).BeginInit();
            this.PnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnBottom)).BeginInit();
            this.PnBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bred5
            // 
            this.Bred5.Dock = System.Windows.Forms.DockStyle.Right;
            this.Bred5.Location = new System.Drawing.Point(437, 1);
            this.Bred5.Name = "Bred5";
            this.Bred5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Bred5.Size = new System.Drawing.Size(1, 50);
            this.Bred5.Text = "kryptonBorderEdge2";
            // 
            // PnBack
            // 
            this.PnBack.Controls.Add(this.txtPassword);
            this.PnBack.Controls.Add(this.txtUsername);
            this.PnBack.Controls.Add(this.kryptonLabel2);
            this.PnBack.Controls.Add(this.kryptonLabel1);
            this.PnBack.Controls.Add(this.Bred3);
            this.PnBack.Controls.Add(this.Bred2);
            this.PnBack.Controls.Add(this.Bred1);
            this.PnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnBack.Location = new System.Drawing.Point(0, 81);
            this.PnBack.Name = "PnBack";
            this.PnBack.Size = new System.Drawing.Size(438, 128);
            this.PnBack.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(214, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(185, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(214, 21);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(185, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(85, 68);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Password";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(85, 21);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Username";
            // 
            // Bred3
            // 
            this.Bred3.Dock = System.Windows.Forms.DockStyle.Right;
            this.Bred3.Location = new System.Drawing.Point(437, 1);
            this.Bred3.Name = "Bred3";
            this.Bred3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Bred3.Size = new System.Drawing.Size(1, 127);
            // 
            // Bred2
            // 
            this.Bred2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Bred2.Location = new System.Drawing.Point(0, 1);
            this.Bred2.Name = "Bred2";
            this.Bred2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Bred2.Size = new System.Drawing.Size(1, 127);
            // 
            // Bred1
            // 
            this.Bred1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bred1.Location = new System.Drawing.Point(0, 0);
            this.Bred1.Name = "Bred1";
            this.Bred1.Size = new System.Drawing.Size(438, 1);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(438, 1);
            // 
            // Bred4
            // 
            this.Bred4.Dock = System.Windows.Forms.DockStyle.Left;
            this.Bred4.Location = new System.Drawing.Point(0, 1);
            this.Bred4.Name = "Bred4";
            this.Bred4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Bred4.Size = new System.Drawing.Size(1, 50);
            // 
            // PnTop
            // 
            this.PnTop.Controls.Add(this.pictureBox1);
            this.PnTop.Controls.Add(this.LblHeader);
            this.PnTop.Controls.Add(this.kryptonBorderEdge3);
            this.PnTop.Controls.Add(this.kryptonBorderEdge2);
            this.PnTop.Controls.Add(this.kryptonBorderEdge1);
            this.PnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnTop.Location = new System.Drawing.Point(0, 0);
            this.PnTop.Name = "PnTop";
            this.PnTop.Size = new System.Drawing.Size(438, 81);
            this.PnTop.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(358, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LblHeader
            // 
            this.LblHeader.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.LblHeader.Location = new System.Drawing.Point(12, 5);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(61, 29);
            this.LblHeader.TabIndex = 5;
            this.LblHeader.Values.Text = "Login";
            // 
            // kryptonBorderEdge3
            // 
            this.kryptonBorderEdge3.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonBorderEdge3.Location = new System.Drawing.Point(437, 1);
            this.kryptonBorderEdge3.Name = "kryptonBorderEdge3";
            this.kryptonBorderEdge3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonBorderEdge3.Size = new System.Drawing.Size(1, 80);
            // 
            // kryptonBorderEdge2
            // 
            this.kryptonBorderEdge2.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonBorderEdge2.Location = new System.Drawing.Point(0, 1);
            this.kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            this.kryptonBorderEdge2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonBorderEdge2.Size = new System.Drawing.Size(1, 80);
            // 
            // BredBottom
            // 
            this.BredBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BredBottom.Location = new System.Drawing.Point(0, 51);
            this.BredBottom.Name = "BredBottom";
            this.BredBottom.Size = new System.Drawing.Size(438, 1);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSubmit.Location = new System.Drawing.Point(223, 9);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(90, 34);
            this.BtnSubmit.TabIndex = 0;
            this.BtnSubmit.Values.Text = "Submit";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(338, 9);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 34);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Values.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PnBottom
            // 
            this.PnBottom.Controls.Add(this.Bred5);
            this.PnBottom.Controls.Add(this.Bred4);
            this.PnBottom.Controls.Add(this.BredBottom);
            this.PnBottom.Controls.Add(this.BtnCancel);
            this.PnBottom.Controls.Add(this.BtnSubmit);
            this.PnBottom.Controls.Add(this.Bred);
            this.PnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnBottom.Location = new System.Drawing.Point(0, 209);
            this.PnBottom.Name = "PnBottom";
            this.PnBottom.Size = new System.Drawing.Size(438, 52);
            this.PnBottom.TabIndex = 7;
            // 
            // Bred
            // 
            this.Bred.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bred.Location = new System.Drawing.Point(0, 0);
            this.Bred.Name = "Bred";
            this.Bred.Size = new System.Drawing.Size(438, 1);
            this.Bred.Text = "kryptonBorderEdge1";
            // 
            // FormLogin
            // 
            this.AcceptButton = this.BtnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(438, 261);
            this.Controls.Add(this.PnBack);
            this.Controls.Add(this.PnTop);
            this.Controls.Add(this.PnBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PnBack)).EndInit();
            this.PnBack.ResumeLayout(false);
            this.PnBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnTop)).EndInit();
            this.PnTop.ResumeLayout(false);
            this.PnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnBottom)).EndInit();
            this.PnBottom.ResumeLayout(false);
            this.PnBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge Bred5;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel PnBack;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge Bred3;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge Bred2;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge Bred1;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge Bred4;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel PnTop;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel LblHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge3;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge BredBottom;
        public ComponentFactory.Krypton.Toolkit.KryptonButton BtnSubmit;
        public ComponentFactory.Krypton.Toolkit.KryptonButton BtnCancel;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel PnBottom;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge Bred;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}