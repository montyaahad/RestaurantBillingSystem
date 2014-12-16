using System;
using ComponentFactory.Krypton.Ribbon;
using Windows.Support;
using Windows.UserControls;
using System.Windows.Forms;
using Windows.Utilities;

namespace Windows.Forms
{
    public partial class FormMain : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public FormMain()
        {
            InitializeComponent();
            
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            FormsFactory.ListForms();


            toolStripStatusLabelUser.Text = "Logged in as : " + BaseObject.User_Name;
        }

        private void BtnRbnBtnClick(Object sender, EventArgs e)
        {
            var btn = (KryptonRibbonGroupButton)sender;
            string context = String.Format("{0} {1}", btn.TextLine1, btn.TextLine2);
            FormLoader.LoadChildForm(context.Replace(" ", ""), context);
        }

        private void FormMain_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}