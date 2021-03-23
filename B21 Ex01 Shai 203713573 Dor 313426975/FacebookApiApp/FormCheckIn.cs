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
    public partial class FormCheckIn : Form
    {
        private User m_LoggedInUser;

        public FormCheckIn(User i_User = null)
        {
            m_LoggedInUser = i_User;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchCheckins();
        }

        private void fetchCheckins()
        {
            try
            {
                if (m_LoggedInUser.Checkins.Count == 0)
                {
                    listBoxCheckins.Items.Add("No Checkins to show.");
                }
                else
                {
                    foreach (Checkin checkin in m_LoggedInUser.Checkins)
                    {
                        listBoxCheckins.Items.Add(checkin.Place.Name);
                    }
                }
            }
            catch (Exception)
            {
                listBoxCheckins.Items.Add("Checkins list - Permission error !!!!");
            }
        }

        private void FormCheckIn_Load(object sender, EventArgs e)
        {

        }
    }
}
