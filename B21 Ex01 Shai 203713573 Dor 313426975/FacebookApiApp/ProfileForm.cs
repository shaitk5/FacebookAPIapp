using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApiApp
{
    public partial class ProfileForm : Form
    {
        private User m_LoggedInUser;
        private AppSettings m_AppSettings;

        public ProfileForm()
        {
            if (!checkIfUserExists())
            {
                initSetting();
            }

            m_AppSettings.SaveToFile();
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        private void initSetting()
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {

        }

        private bool checkIfUserExists()
        {
            bool v_IfRememberUser = false;

            m_AppSettings = AppSettings.LoadFromFile();
            if (m_AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                v_IfRememberUser = true;
                m_LoggedInUser = FacebookService.Connect(m_AppSettings.LastAccessToken).LoggedInUser;
            }

            return v_IfRememberUser;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchUserInfo();
        }

        private void fetchUserInfo()
        {
            labelName.Text = string.Concat(labelName.Text, m_LoggedInUser.Name);
            labelBirthday.Text = string.Concat(labelBirthday.Text, m_LoggedInUser.Birthday);
            labelGender.Text = string.Concat(labelGender.Text, m_LoggedInUser.Gender);
            pictureBoxProfilePic.LoadAsync(m_LoggedInUser.PictureNormalURL);
            labelLogInName.Text = string.Format("Hello, {0}", m_LoggedInUser.Name);
        }

        private void pictureBoxFriends_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxAlbums_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPost_Click(object sender, EventArgs e)
        {
        }

        private void postStatus()
        {
           
        }

        private void pictureBoxUpload_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
 
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(new Action(onLogOut));
        }

        private void onLogOut()
        {
            m_AppSettings.LastAccessToken = null;
            m_AppSettings.RememberUser = false;
            m_AppSettings.SaveToFile();
            MessageBox.Show("Thank you for using our facebook, bye bye.");
            this.Close();
        }

        private void pictureBoxMyPosts_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxGroups_Click(object sender, EventArgs e) 
        {
        }

        private void pictureBoxCheckin_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxEvents_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxCorona_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBirthday_Click(object sender, EventArgs e)
        {
 
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBoxProfilePic_Click(object sender, EventArgs e)
        {

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}
