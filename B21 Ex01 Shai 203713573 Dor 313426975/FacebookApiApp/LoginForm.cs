using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using Facebook;
using FacebookApiApp;

namespace FacebookApiApp
{
     public partial class LoginForm : Form
     {
          LoginResult m_LoginResult;
          bool m_RememberUser;

          public LoginForm()
          {
               InitializeComponent();
               
               LoggedInUserData();
          }

          private void LoggedInUserData()
          {
               

          }

          private void LoginButtonOnClick(object sender, EventArgs e)
          {
               m_RememberUser = checkBox1.Checked;
               m_LoginResult = FacebookService.Login("283238313148583", "user_birthday", "user_friends", "user_likes", "user_posts", "public_profile");
          }

          private void LoginForm_Load(object sender, EventArgs e)
          {

          }
     }
}
