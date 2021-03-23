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
    public partial class FormFriends : Form
    {
        private User m_LoggedInUser;

        public FormFriends(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchFriendsList();
        }

        private void fetchFriendsList()
        {
            try
            {
                listBoxFriends.Items.Clear();
                listBoxFriends.DisplayMember = "Name";
                if (m_LoggedInUser.Friends.Count == 0)
                {
                    listBoxFriends.Items.Add("No Friends to show");
                }
                else
                {
                    foreach (User friend in m_LoggedInUser.Friends)
                    {
                        listBoxFriends.Items.Add(friend);
                        friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                    }
                }
            }
            catch (Exception)
            {
                listBoxFriends.Items.Add("Friends - Permission error !!!!");
            }
        }

        private void FormFriends_Load(object sender, EventArgs e)
        {

        }
    }
}
