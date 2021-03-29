using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApiApp
{
     public partial class FormMostLikely : Form
     {
          private User m_LoggedInUser;

          public FormMostLikely(User i_LoggedInUser = null)
          {
               m_LoggedInUser = i_LoggedInUser;
               InitializeComponent();
          }

          protected override void OnShown(EventArgs e)
          {
               base.OnShown(e);
               fetchMostLikelyAndCommentedFriend();
               fetchMostLikelyOrCommentPost();
               fetchMostLikelyPicture();
          }

          protected override void OnFormClosed(FormClosedEventArgs e)
          {
               base.OnFormClosed(e);
               textBoxCommentedPost.Text = string.Empty;
               textBoxCommentFriend.Text = string.Empty;
               textBoxLikelyPost.Text = string.Empty;
               textBoxFriendLike.Text = string.Empty;
               pictureBoxLikely.Image = null;
          }

          private void fetchMostLikelyAndCommentedFriend()
          {
               User mostLikelyFriend = null, mostCommentedFriend = null;
               Dictionary<string, FacebookUserWrapper> friendsComments = new Dictionary<string, FacebookUserWrapper>();
               Dictionary<string, FacebookUserWrapper> friendsLikes = new Dictionary<string, FacebookUserWrapper>();

               try
               {
                    if(m_LoggedInUser.Friends.Count > 0)
                    {
                         foreach(User fbFriend in m_LoggedInUser.Friends)
                         {
                              friendsLikes.Add(fbFriend.Id, new FacebookUserWrapper(fbFriend));
                              friendsComments.Add(fbFriend.Id, new FacebookUserWrapper(fbFriend));
                         }

                         updateFriendsLikesCounter(friendsLikes);
                         updateFriendsCommentsCounter(friendsComments);
                         mostLikelyFriend = getMxCounter(friendsLikes);
                         mostCommentedFriend = getMxCounter(friendsComments);
                    }

                    updateCommentedTextBox(mostCommentedFriend);
                    updateLikelyFriendTextBox(mostLikelyFriend);
               }
               catch(Exception)
               {
                    textBoxCommentFriend.Text = "There are no permissions to see the amount of comments your friends have done";
                    textBoxFriendLike.Text = "There are no permissions to see the amount of likes your friends have done";
               }
          }

          private void updateCommentedTextBox(User i_FriendMaxCommented)
          {
               if(i_FriendMaxCommented != null)
               {
                    textBoxCommentFriend.Text = i_FriendMaxCommented.UserName;
               }
               else
               {
                    textBoxCommentFriend.Text = "There are no friends that Commented your post";
               }
          }

          private void updateLikelyFriendTextBox(User i_FriendMaxCommented)
          {
               if(i_FriendMaxCommented != null)
               {
                    textBoxFriendLike.Text = i_FriendMaxCommented.UserName;
               }
               else
               {
                    textBoxFriendLike.Text = "There are no friends that Commented your post";
               }
          }

          private void updateFriendsCommentsCounter(Dictionary<string, FacebookUserWrapper> i_FbFriendsCollection)
          {
               foreach(Post post in m_LoggedInUser.Posts)
               {
                    foreach(Comment comment in post.Comments)
                    {
                         if(i_FbFriendsCollection.ContainsKey(comment.From.Id))
                         {
                              i_FbFriendsCollection[comment.From.Id].Counter++;
                         }
                    }
               }
          }

          private void updateFriendsLikesCounter(Dictionary<string, FacebookUserWrapper> i_FbFriendsCollection)
          {
               foreach(Post post in m_LoggedInUser.Posts)
               {
                    foreach(User fbFriend in post.LikedBy)
                    {
                         if(i_FbFriendsCollection.ContainsKey(fbFriend.Id))
                         {
                              i_FbFriendsCollection[fbFriend.Id].Counter++;
                         }
                    }
               }
          }

          private User getMxCounter(Dictionary<string, FacebookUserWrapper> i_FbFriendsCollection)
          {
               int maxCounter = 0;
               User friendToReturn = null;

               foreach(KeyValuePair<string, FacebookUserWrapper> friend in i_FbFriendsCollection)
               {
                    if(friend.Value.Counter > maxCounter)
                    {
                         friendToReturn = friend.Value.UserWrapper;
                         maxCounter = friend.Value.Counter;
                    }
               }

               return friendToReturn;
          }

          private void fetchMostLikelyPicture()
          {
               int maxLikes = 0;
               Photo mostLikelyPhoto = null;

               try
               {
                    if(m_LoggedInUser.Albums.Count > 0)
                    {
                         foreach(Album album in m_LoggedInUser.Albums)
                         {
                              foreach(Photo photo in album.Photos)
                              {
                                   if(photo.LikedBy.Count > maxLikes)
                                   {
                                        mostLikelyPhoto = photo;
                                        maxLikes = photo.LikedBy.Count;
                                   }
                              }
                         }

                         if(maxLikes > 0)
                         {
                              pictureBoxLikely.LoadAsync(mostLikelyPhoto.PictureNormalURL);
                         }
                    }
               }
               catch(Exception)
               {
                    pictureBoxLikely.Image = global::FacebookApiApp.Properties.Resources.FacebookNoPermission;
               }
          }

          private void fetchMostLikelyOrCommentPost()
          {
               Post mostCommented = null, mostLikelyPost = null;
               int maxLikes = 0, maxComments = 0;

               try
               {
                    if(m_LoggedInUser.Posts.Count > 0)
                    {
                         foreach(Post post in m_LoggedInUser.Posts)
                         {
                              if(post.LikedBy.Count > maxLikes)
                              {
                                   maxLikes = post.LikedBy.Count;
                                   mostLikelyPost = post;
                              }

                              if(post.Comments.Count > maxComments)
                              {
                                   maxComments = post.Comments.Count;
                                   mostCommented = post;
                              }
                         }

                         if(maxLikes > 0)
                         {
                              textBoxLikelyPost.Text = mostLikelyPost.Message;
                         }

                         if(maxComments > 0)
                         {
                              textBoxCommentedPost.Text = mostCommented.Message;
                         }
                    }
               }
               catch(Exception)
               {
                    textBoxCommentedPost.Text = "There are no permissions to access the comments list of your posts";
                    textBoxLikelyPost.Text = "There are no permissions to access the likes list of your posts";
               }
          }
     }
}
