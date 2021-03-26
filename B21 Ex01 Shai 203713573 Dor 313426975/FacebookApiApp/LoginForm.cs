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
               get;
               set;
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
                   "user_gender",
                   "user_posts",
                   "public_profile",
                   "user_friends",
                   "user_tagged_places",
                   "user_location",
                   "user_photos",
                   "user_events",
                   "user_location",
                   "user_hometown",
                   "publish_to_groups",
                   "pages_manage_posts",
                   "email",
                   "pages_manage_engagement",
                   "groups_access_member_info",
                   "user_videos",
                   "user_age_range",
                   "user_link"
                   );

               AppSettings appSettings = AppSettings.LoadFromFile();

               if(!String.IsNullOrEmpty(FormLoginResult.AccessToken))
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
               this.RememberMe = checkBoxRemeberMe.Checked;
          }
     }
}