using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Service.BLL;
using Windows.Support;
using System.Linq.Expressions;

namespace Windows.UserControls.BaseUserControls
{
    public partial class BaseSaveClose : UserControl
    {
        protected BaseSaveClose()
        {
            InitializeComponent();
            ControlList = new Dictionary<string, Control>();
        }


        public Dictionary<string, Control> ControlList { get; set; }
      
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BindingProperty();
        }
        public void AddToControlList<T>(Expression<Func<T>> expr, Control ctrl)
        {
            var body = ((MemberExpression)expr.Body);
            ControlList.Add(body.Member.Name, ctrl);
        }

        public void AddToControlList(string s, Control ctrl)
        {
            ControlList.Add(s, ctrl);

        }

        public virtual void BindingProperty()
        {
        }

        private void BtSaveClick(object sender, EventArgs e)
        {
            DialogResult dr = KryptonMessageBox.Show(Messages.SaveConfirmation, Text, MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Save();
        }

        protected virtual void Save()
        {
        }

    }
}
