using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Service.DTO;
using Service.BLL;
using ComponentFactory.Krypton.Toolkit;
using Windows.Utilities;

namespace Windows.Forms
{
    public partial class FormLogin : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
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

            if (!IsValidityDateExceeded())
            {

                if (IsLoggedIn(txtUsername.Text, txtPassword.Text))
                {
                    this.Hide();


                    FormMain fMain = new FormMain();
                    fMain.Show();
                }
                else
                {
                    KryptonMessageBox.Show("Invalid Username or Password. Please provide valid credentials.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                KryptonMessageBox.Show("Database outdated. Need to update with the latest version", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsLoggedIn(string username, string password)
        {
            bool isSucceed = false;

            UserInfo userInfo = null;
            List<UserInfo> lstUser = new BllUserInfo().GetUserInfoByUsername(username);

            if (lstUser.Count > 0)
            {
                userInfo = lstUser[0];
            }

            if (userInfo != null)
            {
                if (userInfo.UserPassword.Trim() == password.Trim())
                {
                    BaseObject.User_Name = userInfo.UserName;
                    BaseObject.User_ID = userInfo.UserId;

                    isSucceed = true;
                }
            }

            return isSucceed;
        }

        private bool IsValidityDateExceeded()
        {
            bool isExceeded = false;

            DateTime validDate = new BllDayCloseDetails().GetValidityDate();
            DateTime sysDate = new BllDayCloseDetails().GetSystemDate();

            if (sysDate > validDate)
            {
                isExceeded = true;
            }

            return isExceeded;
        }
    }
}
