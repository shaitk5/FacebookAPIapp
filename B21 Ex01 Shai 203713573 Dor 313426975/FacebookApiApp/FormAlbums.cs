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
    public partial class FormAlbums : Form
    {
        private User m_LoggedInUser;

        public FormAlbums(User i_LoggesInUser = null)
        {
            m_LoggedInUser = i_LoggesInUser;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            try
            {
                listBoxAlbums.Items.Clear();
                listBoxAlbums.DisplayMember = "Name";
                if (m_LoggedInUser.Albums.Count == 0)
                {
                    listBoxAlbums.Items.Add("No Albums to retrieve.");
                }
                else
                {
                    foreach (Album album in m_LoggedInUser.Albums)
                    {
                        listBoxAlbums.Items.Add(album);
                    }
                }
            }
            catch (Exception)
            {
                listBoxAlbums.Items.Add("Permission error !!!!");
            }
        }

        private void FormAlbums_Load(object sender, EventArgs e)
        {

        }
    }
}
