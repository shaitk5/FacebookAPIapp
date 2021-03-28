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
    public partial class FormEvents : Form
    {
        private User m_LoggedInUser;

        public FormEvents(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchEvents();
        }

        private void fetchEvents()
        {
            try
            {
                listBoxEvents.Items.Clear();
                if (m_LoggedInUser.Events.Count == 0)
                {
                    listBoxEvents.Items.Add("Sorry there are not future events in your account.");
                }
                else
                {
                    foreach (Event fbEvent in m_LoggedInUser.Events)
                    {
                        if (fbEvent.StartTime > DateTime.Now)
                        {
                            listBoxEvents.Items.Add(string.Format("{0} At : {1}", fbEvent.Name, fbEvent.StartTime));
                        }
                    }
                }
            }
            catch (Exception)
            {
                listBoxEvents.Items.Add("Events - Permission error !!!!");
            }
        }
    }
}
