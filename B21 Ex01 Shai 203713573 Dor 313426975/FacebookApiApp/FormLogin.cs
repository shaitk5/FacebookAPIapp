using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApiApp
{
     public partial class FormLogin : Form
     {
          private const String m_AppID = "283238313148583";
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

          public FormLogin()
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
                    m_AppID,
                    "email",
                    "user_gender",
                    "user_birthday",
                    "user_friends",
                    "user_posts",
                    "user_events",
                    "user_likes",
                     "user_tagged_places",
                     "public_profile",
                     "publish_to_groups",
                     "user_age_range",
                     "user_link",
                     "user_videos",
                     "groups_access_member_info",
                     "user_location",
                     "user_photos",
                     "user_hometown",
                     "publish_to_groups",
                     "pages_read_engagement",
                     "pages_manage_posts"
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