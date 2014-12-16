using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Windows.Forms
{
    public partial class Form1 : Form
    {
        public Form1(Control form)
        {
            InitializeComponent();
            _form = form;
        }

        private Control _form;

        public static IEnumerable<Control> GetControls(Control form)
        {
            foreach (Control childControl in form.Controls)
            {   // Recurse child controls.
                foreach (Control grandChild in GetControls(childControl))
                {
                    if(SelectedControl(grandChild))
                        yield return grandChild;
                }
                if (SelectedControl(childControl))
                    yield return childControl;
            }
        }
        static bool SelectedControl(Control control)
        {
            if (control is KryptonTextBox || control is KryptonComboBox || control is KryptonRichTextBox || control is KryptonNumericUpDown || control is KryptonCheckBox)
                return true;
            return false;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach (var c in GetControls(_form))
            {
                richTextBox1.Text += string.Format("AddToControlList(() => o.,{0});\n",c.Name);
            }

        }
    }
}
