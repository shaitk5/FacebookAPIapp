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
    public partial class FormBirthday : Form
    {
        private User m_LoggedInUser;

        public FormBirthday(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchBirthdays();
        }

        private void fetchBirthdays()
        {
            try
            {
                DateTime today = DateTime.Now;
                listBoxBirthdays.Items.Clear();
                if (m_LoggedInUser.Friends.Count > 0)
                {
                    foreach (User friend in m_LoggedInUser.Friends)
                    {
                        if (DateTime.Parse(friend.Birthday) == today)
                        {
                            listBoxBirthdays.Items.Add(friend.Name);
                        }
                    }

                    if (listBoxBirthdays.Items.Count == 0)
                    {
                        listBoxBirthdays.Items.Add("None of your friends have a birthday today");
                    }
                }
                else
                {
                    listBoxBirthdays.Items.Add("The friends list is empty");
                }
            }
            catch (Exception)
            {
                listBoxBirthdays.Items.Add("Permission error !!!!");
            }
        }

        private void FormBirthday_Load(object sender, EventArgs e)
        {

        }
    }
}
