using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FacebookApiApp
{
    public partial class FormProfile : Form
    {
        private User m_LoggedInUser;
        private LoginForm m_FormLogIn;
        private AppSettings m_AppSettings;
        private FormBirthday m_FormBirthday;

        public FormProfile()
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
            m_AppSettings = new AppSettings();
            m_FormLogIn = new LoginForm();
            m_FormLogIn.ShowDialog();

            if (m_FormLogIn.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Sorry you must login to use our application bye bye.");
                Environment.Exit(0);
            }

            m_LoggedInUser = m_FormLogIn.LoggedInUser;

            if (m_LoggedInUser == null)
            {
                MessageBox.Show("Unseccess login, try again next time");
                Environment.Exit(0);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (m_FormLogIn != null)
            {
                m_AppSettings.RememberUser = m_FormLogIn.RememberMe;

                if (m_AppSettings.RememberUser)
                {
                    m_AppSettings.LastAccessToken = m_FormLogIn.FormLoginResult.AccessToken;
                }
            }

            m_AppSettings.SaveToFile();
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
            // initialize all initial (Birthday this week, corona news, most likely photo, yada yada yada...) forms (Different Threads)
            fetchUserInfo();
        }

        private void fetchUserInfo()
        {
            pictureBoxProfilePic.Image = m_LoggedInUser.ImageSmall;
            labelBirthday.Text = string.Concat(labelBirthday.Text, m_LoggedInUser.Birthday);
            labelGender.Text = string.Concat(labelGender.Text, m_LoggedInUser.Gender);
            pictureBoxProfilePic.LoadAsync(m_LoggedInUser.PictureNormalURL);
            labelLogInName.Text = string.Format("Hello, {0}", m_LoggedInUser.Name);
            textBoxPost.Text = "Write your post...";
        }

        private void pictureBoxFriends_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxAlbums_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPost_Click(object sender, EventArgs e)
        {
            try
            {
                this.m_LoggedInUser.PostStatus(textBoxPost.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Posting Permission error !!!!");
                textBoxPost.Clear();
            }
        }

        private void pictureBoxUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string pictureUrl;

                openFileUploadPicture.InitialDirectory = "c:\\";
                openFileUploadPicture.Filter = "*.png|*.jpg|*.jpeg|*.gif";
                openFileUploadPicture.ShowDialog();
                pictureUrl = openFileUploadPicture.FileName;
                m_LoggedInUser.PostPhoto(pictureUrl, textBoxPost.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Posting picture permission error !!!!");
            }
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
            labelLogInName.Text = string.Format("Hello, {0}", m_LoggedInUser.Name);
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
            if (m_FormBirthday != null)
            {
                m_FormBirthday.ShowDialog();
            }
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

        private void labelLogInName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPost_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileUploadPicture_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
