using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Service.BLL;
using Service.DTO;
using ComponentFactory.Krypton.Toolkit;
using Windows.Utilities;
using Windows.Support;
using System.IO;

namespace Windows.UserControls
{
    public partial class UcDayClose : UserControl
    {
        public UcDayClose()
        {
            InitializeComponent();
        }

        private void UcDayClose_Load(object sender, EventArgs e)
        {
            DateTime sdate = new BllDayCloseDetails().GetSystemDate();

            dtpClosingDate.Value = sdate;
            txtUsername.Text = BaseObject.User_Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                KryptonMessageBox.Show("Please provide Username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                KryptonMessageBox.Show("Please provide Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }


            if (IsLoggedIn(txtUsername.Text, txtPassword.Text))
            {
                DialogResult dr = KryptonMessageBox.Show(Messages.SaveConfirmation, Text, MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DayCloseDetails dayClose = new DayCloseDetails();
                    dayClose.ClosingDate = dtpClosingDate.Value;
                    dayClose.NewDate = dtpClosingDate.Value.AddDays(1);
                    dayClose.EntryDateTime = DateTime.Now;
                    dayClose.UserId = BaseObject.User_ID;

                    new BllDayCloseDetails().InsertOrUpdate(dayClose);

                    BackupDB();

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    dtpClosingDate.Value = dtpClosingDate.Value.AddDays(1);
                }
            }
            else
            {
                KryptonMessageBox.Show("Invalid Username or Password. Please provide valid credentials.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsLoggedIn(string username, string password)
        {
            bool isSucceed = false;

            UserInfo userInfo = null; 
            List<UserInfo> lstUser= new BllUserInfo().GetUserInfoByUsername(username);

            if (lstUser.Count > 0)
            {
                userInfo = lstUser[0];
            }

            if (userInfo != null)
            {
                if (userInfo.UserPassword.Trim() == password.Trim())
                {
                    isSucceed = true;
                }
            }

            return isSucceed;
        }

        private void BackupDB()
        {
            string path = String.Format("{0}\\RESTAURANT_DB_BACKUP_{1:dd_MM_yyyy}.bak", System.Configuration.ConfigurationManager.AppSettings["BackupPath"], DateTime.Now.Date);
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            new BllDayCloseDetails().GetDbBackup(path);
        }
    }
}
