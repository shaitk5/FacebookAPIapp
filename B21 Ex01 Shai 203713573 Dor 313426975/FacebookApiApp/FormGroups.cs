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
    public partial class FormGroups : Form
    {
        private User m_LoggedInUser;

        public FormGroups(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchGroups();
        }

        private void fetchGroups()
        {
            try
            {
                listBoxGroups.Items.Clear();
                if (m_LoggedInUser.Groups.Count == 0)
                {
                    listBoxGroups.Items.Add("Sorry you don`t have group membership yet.");
                }
                else
                {
                    listBoxGroups.DisplayMember = "Name";
                    foreach (Group group in m_LoggedInUser.Groups)
                    {
                        listBoxGroups.Items.Add(group);
                    }
                }
            }
            catch (Exception)
            {
                listBoxGroups.Items.Add("Groups list - permission error !!!!");
            }
        }

        private void FormGroups_Load(object sender, EventArgs e)
        {

        }
    }
}
