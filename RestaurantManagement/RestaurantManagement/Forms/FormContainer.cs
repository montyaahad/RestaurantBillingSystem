using System.Drawing;
using System.Windows.Forms;

namespace Windows.Forms
{
    public partial class FormContainer : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public FormContainer(UserControl control, string title = "")
        {
            InitializeComponent();
            Size = new Size(control.Width + 10, control.Height + 30);
            control.Dock = DockStyle.Fill;
            Controls.Add(control);
            Text = title;
            Uc = control;
        }
        public UserControl Uc { get; set; }
    }
}