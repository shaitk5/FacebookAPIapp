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
    public partial class FormUserPosts : Form
    {
        private User m_LoggedInUser;

        public FormUserPosts(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            fetchAllPosts();
        }

        private void fetchAllPosts()
        {
            try
            {
                listBoxPosts.Items.Clear();
                if (m_LoggedInUser.Posts.Count == 0)
                {
                    listBoxPosts.Items.Add("Sorry you don`t have any posts yet.");
                }
                else
                {
                    listBoxPosts.DisplayMember = "Message";
                    foreach (Post post in m_LoggedInUser.Posts)
                    {
                        listBoxPosts.Items.Add(post);
                    }
                }
            }
            catch (Exception)
            {
                listBoxPosts.Items.Add("Posts list - Permission error !!!!");
            }
        }
    }
}
