using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApiApp
{
     public partial class LoginForm : Form
     {
        public User LoggedInUser
        {
            get;
            private set;
        }

        public LoginResult FormLoginResult
        {
            get;
            private set;
        }

        public bool RememberMe
        {
            get
            {
                bool v_IfRemember = true;

                v_IfRemember = checkBoxRemeberMe.Checked;

                return v_IfRemember;
            }
        }

        public LoginForm()
          {
               InitializeComponent();
          }

          private void LoginButtonOnClick(object sender, EventArgs e)
          {
            LoggedInUserData();
          }

        private void LoggedInUserData()
        {
            FormLoginResult = FacebookService.Login(
                "283238313148583",
                "user_birthday",
                "user_friends",
                "user_likes",
                "user_posts",
                "public_profile");

            AppSettings appSettings = AppSettings.LoadFromFile();

            if (!String.IsNullOrEmpty(FormLoginResult.AccessToken))
            {
                LoggedInUser = FormLoginResult.LoggedInUser;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(FormLoginResult.ErrorMessage);
            }
        }

        private void checkBoxRemeberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
