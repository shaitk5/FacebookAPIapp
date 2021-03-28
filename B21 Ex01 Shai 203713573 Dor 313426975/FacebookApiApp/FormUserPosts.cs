using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApiApp
{
     public partial class FormUserPosts : Form
     {
          private User m_LoggedInUser;

          public FormUserPosts(User i_LoggedInUser = null)
          {
               m_LoggedInUser = i_LoggedInUser;
               InitializeComponent();
               listBoxPosts.Items.Add("Loading...");
          }

          protected override void OnShown(EventArgs e)
          {
               base.OnShown(e);
               fetchAllPosts();
          }

          private void fetchAllPosts()
          {
               try
               {
                    listBoxPosts.Items.Clear();
                    if(m_LoggedInUser.Posts.Count == 0)
                    {
                         listBoxPosts.Items.Add("Sorry you don`t have any posts yet.");
                    }
                    else
                    {
                         listBoxPosts.DisplayMember = "Message";
                         foreach(Post post in m_LoggedInUser.Posts)
                         {
                              if (post.Message != null)
                              {
                                   listBoxPosts.Items.Add(post);
                              }
                         }
                    }
               }
               catch(Exception)
               {
                    listBoxPosts.Items.Add("Posts list - Permission error !!!!");
               }
          }
     }
}
