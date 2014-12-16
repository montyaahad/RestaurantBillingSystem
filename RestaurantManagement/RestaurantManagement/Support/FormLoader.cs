using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Windows.Forms;
using Windows.UserControls;

namespace Windows.Support
{
    public class FormLoader
    {

        public static DialogResult LoadChildForm(string formName, string title = "", Object[] args = null)
        {
            try
            {
                if (FormsFactory.Forms.ContainsKey(formName))
                {
                    var form = (UserControl)Activator.CreateInstance(FormsFactory.Forms[formName], args);
                    var frm = new FormContainer(form, title);
                    DialogResult dr = frm.ShowDialog();
                    return dr;
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "Error Loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return DialogResult.Abort;
        }


        public static void SetControlValue<T>(Dictionary<string, Control> ctrls, T obj)
        {
            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                string s = prop.Name;
                Control control;
                if (ctrls.ContainsKey(s))
                {
                    control = ctrls[s];
                    if (control is KryptonTextBox || control is KryptonRichTextBox ||
                        control is KryptonNumericUpDown)
                    {
                        control.Text = prop.GetValue(obj, null).ToString();
                    }
                    else if (control is KryptonComboBox)
                    {
                        if (prop.PropertyType == typeof(string))
                            control.Text = prop.GetValue(obj, null).ToString();
                        else if (prop.PropertyType == typeof(int))
                        {

                            ((KryptonComboBox)control).SelectedValue = prop.GetValue(obj, null);
                            if (((KryptonComboBox)control).SelectedValue == null)
                                ((KryptonComboBox)control).SelectedIndex = Convert.ToInt32(prop.GetValue(obj, null));

                        }
                    }
                    else if (control is KryptonCheckBox)
                    {
                        ((KryptonCheckBox)control).Checked = Convert.ToBoolean(prop.GetValue(obj, null));
                    }
                    else if (control is PictureBox)
                    {
                        if (prop.PropertyType == typeof(byte[]))
                            ((PictureBox)control).Image = Extension.ByteArrayToImage((byte[])prop.GetValue(obj, null));
                        else if (prop.PropertyType == typeof(Image))
                            ((PictureBox)control).Image = (Image)prop.GetValue(obj, null);
                        else if (prop.PropertyType == typeof(string))
                        {
                            ((PictureBox)control).ImageLocation = prop.GetValue(obj, null) != null ? prop.GetValue(obj, null).ToString() : String.Empty;
                        }

                        ((PictureBox)control).SizeMode = PictureBoxSizeMode.Zoom;

                    }

                    else if (control is KryptonRadioButton)
                    {
                        ((KryptonRadioButton)control).Checked = (bool)prop.GetValue(obj,null);
                    }
                }
            }
        }
        public static T GetControlValue<T>(Dictionary<string, Control> ctrls) where T : new()
        {
            var obj = new T();
            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                string s = prop.Name;
                object value = "0";
                if (ctrls.ContainsKey(s))
                {
                    Control control = ctrls[s];

                    if (control is KryptonTextBox || control is KryptonRichTextBox ||
                        control is KryptonNumericUpDown || control is KryptonDateTimePicker)
                    {
                        value = control.Text;

                    }
                    else if (control is KryptonComboBox)
                    {
                        if (prop.PropertyType == typeof(string))
                            value = control.Text;
                        else
                        {

                            value = ((KryptonComboBox)control).SelectedValue ?? ((KryptonComboBox)control).SelectedIndex;
                        }
                    }
                    else if (control is KryptonCheckBox)
                    {
                        value = ((KryptonCheckBox)control).Checked;

                    }
                    else if (control is KryptonRadioButton)
                    {
                        value = ((KryptonRadioButton)control).Checked;
                    }
                    else if (control is PictureBox)
                    {
                        if (prop.PropertyType == typeof(string))
                            value = ((PictureBox)control).ImageLocation;
                        else
                            value = ((PictureBox)control).Image;

                    }

                }
                Extension.GetCorrectType(prop.PropertyType, ref value);
                prop.SetValue(obj, value, null);
            }
            return obj;
        }


        public static void LoadImage(PictureBox pb)
        {
            using (var od = new OpenFileDialog())
            {
                od.Filter = "All Image File|*.jpg;*.bmp;*.gif;*.png|JPEG|*.jpg|BitMap|*.bmp|GIF|*.gif|PNG|*.png";
                if (od.ShowDialog() == DialogResult.OK)
                {
                    pb.Image = null;
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    string picFileName = od.FileName;
                    pb.ImageLocation = picFileName;
                }
            }
        }

        public static void LoadDataSource<T>(Control control, List<T> list, string display, string value)
        {
            BindingSource bd = new BindingSource();
            
            bd.DataSource = list;
            dynamic ctrl = control;
            ctrl.DataSource = bd;
            ctrl.DisplayMember = display;
            ctrl.ValueMember = value;
            bd.ResetBindings(false);
        }

        public static void AddInitialToDataSource<T>(ref List<T> list, T obj)
        {
            list.Insert(0,obj);
        }
    }
}