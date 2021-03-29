namespace FacebookApiApp
{
    public partial class FormMostLikely
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
               this.labelTitle = new System.Windows.Forms.Label();
               this.textBoxCommentedPost = new System.Windows.Forms.TextBox();
               this.labelMustComment = new System.Windows.Forms.Label();
               this.textBoxCommentFriend = new System.Windows.Forms.TextBox();
               this.labelCommentFriend = new System.Windows.Forms.Label();
               this.textBoxFriendLike = new System.Windows.Forms.TextBox();
               this.labelLikelyFriend = new System.Windows.Forms.Label();
               this.textBoxLikelyPost = new System.Windows.Forms.TextBox();
               this.labelLikelyPost = new System.Windows.Forms.Label();
               this.pictureBoxLikely = new System.Windows.Forms.PictureBox();
               this.labelLikelyPicture = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikely)).BeginInit();
               this.SuspendLayout();
               // 
               // labelTitle
               // 
               this.labelTitle.AutoSize = true;
               this.labelTitle.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.labelTitle.Location = new System.Drawing.Point(418, 20);
               this.labelTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
               this.labelTitle.Name = "labelTitle";
               this.labelTitle.Size = new System.Drawing.Size(958, 81);
               this.labelTitle.TabIndex = 1;
               this.labelTitle.Text = "Your most likely items are :";
               // 
               // textBoxCommentedPost
               // 
               this.textBoxCommentedPost.Location = new System.Drawing.Point(1050, 654);
               this.textBoxCommentedPost.Margin = new System.Windows.Forms.Padding(7);
               this.textBoxCommentedPost.Multiline = true;
               this.textBoxCommentedPost.Name = "textBoxCommentedPost";
               this.textBoxCommentedPost.ScrollBars = System.Windows.Forms.ScrollBars.Both;
               this.textBoxCommentedPost.Size = new System.Drawing.Size(683, 296);
               this.textBoxCommentedPost.TabIndex = 20;
               // 
               // labelMustComment
               // 
               this.labelMustComment.AutoSize = true;
               this.labelMustComment.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.labelMustComment.Location = new System.Drawing.Point(1106, 598);
               this.labelMustComment.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
               this.labelMustComment.Name = "labelMustComment";
               this.labelMustComment.Size = new System.Drawing.Size(384, 40);
               this.labelMustComment.TabIndex = 19;
               this.labelMustComment.Text = "Most commented post";
               // 
               // textBoxCommentFriend
               // 
               this.textBoxCommentFriend.Location = new System.Drawing.Point(152, 861);
               this.textBoxCommentFriend.Margin = new System.Windows.Forms.Padding(7);
               this.textBoxCommentFriend.Multiline = true;
               this.textBoxCommentFriend.Name = "textBoxCommentFriend";
               this.textBoxCommentFriend.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
               this.textBoxCommentFriend.Size = new System.Drawing.Size(809, 89);
               this.textBoxCommentFriend.TabIndex = 18;
               // 
               // labelCommentFriend
               // 
               this.labelCommentFriend.AutoSize = true;
               this.labelCommentFriend.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.labelCommentFriend.Location = new System.Drawing.Point(154, 787);
               this.labelCommentFriend.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
               this.labelCommentFriend.Name = "labelCommentFriend";
               this.labelCommentFriend.Size = new System.Drawing.Size(588, 40);
               this.labelCommentFriend.TabIndex = 17;
               this.labelCommentFriend.Text = "The friend who comment the most";
               // 
               // textBoxFriendLike
               // 
               this.textBoxFriendLike.Location = new System.Drawing.Point(152, 654);
               this.textBoxFriendLike.Margin = new System.Windows.Forms.Padding(7);
               this.textBoxFriendLike.Multiline = true;
               this.textBoxFriendLike.Name = "textBoxFriendLike";
               this.textBoxFriendLike.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
               this.textBoxFriendLike.Size = new System.Drawing.Size(809, 93);
               this.textBoxFriendLike.TabIndex = 16;
               // 
               // labelLikelyFriend
               // 
               this.labelLikelyFriend.AutoSize = true;
               this.labelLikelyFriend.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.labelLikelyFriend.Location = new System.Drawing.Point(159, 598);
               this.labelLikelyFriend.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
               this.labelLikelyFriend.Name = "labelLikelyFriend";
               this.labelLikelyFriend.Size = new System.Drawing.Size(564, 40);
               this.labelLikelyFriend.TabIndex = 15;
               this.labelLikelyFriend.Text = "The friend who like you the most";
               // 
               // textBoxLikelyPost
               // 
               this.textBoxLikelyPost.Location = new System.Drawing.Point(817, 268);
               this.textBoxLikelyPost.Margin = new System.Windows.Forms.Padding(7);
               this.textBoxLikelyPost.Multiline = true;
               this.textBoxLikelyPost.Name = "textBoxLikelyPost";
               this.textBoxLikelyPost.ScrollBars = System.Windows.Forms.ScrollBars.Both;
               this.textBoxLikelyPost.Size = new System.Drawing.Size(916, 285);
               this.textBoxLikelyPost.TabIndex = 14;
               // 
               // labelLikelyPost
               // 
               this.labelLikelyPost.AutoSize = true;
               this.labelLikelyPost.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.labelLikelyPost.Location = new System.Drawing.Point(882, 178);
               this.labelLikelyPost.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
               this.labelLikelyPost.Name = "labelLikelyPost";
               this.labelLikelyPost.Size = new System.Drawing.Size(278, 40);
               this.labelLikelyPost.TabIndex = 13;
               this.labelLikelyPost.Text = "Most likely post";
               // 
               // pictureBoxLikely
               // 
               this.pictureBoxLikely.Location = new System.Drawing.Point(166, 268);
               this.pictureBoxLikely.Margin = new System.Windows.Forms.Padding(7);
               this.pictureBoxLikely.Name = "pictureBoxLikely";
               this.pictureBoxLikely.Size = new System.Drawing.Size(527, 290);
               this.pictureBoxLikely.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxLikely.TabIndex = 12;
               this.pictureBoxLikely.TabStop = false;
               // 
               // labelLikelyPicture
               // 
               this.labelLikelyPicture.AutoSize = true;
               this.labelLikelyPicture.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.labelLikelyPicture.Location = new System.Drawing.Point(212, 178);
               this.labelLikelyPicture.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
               this.labelLikelyPicture.Name = "labelLikelyPicture";
               this.labelLikelyPicture.Size = new System.Drawing.Size(323, 40);
               this.labelLikelyPicture.TabIndex = 11;
               this.labelLikelyPicture.Text = "Most likely picture";
               // 
               // FormMostLikely
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
               this.AutoSize = true;
               this.ClientSize = new System.Drawing.Size(1867, 1004);
               this.Controls.Add(this.textBoxCommentedPost);
               this.Controls.Add(this.labelMustComment);
               this.Controls.Add(this.textBoxCommentFriend);
               this.Controls.Add(this.labelCommentFriend);
               this.Controls.Add(this.textBoxFriendLike);
               this.Controls.Add(this.labelLikelyFriend);
               this.Controls.Add(this.textBoxLikelyPost);
               this.Controls.Add(this.labelLikelyPost);
               this.Controls.Add(this.pictureBoxLikely);
               this.Controls.Add(this.labelLikelyPicture);
               this.Controls.Add(this.labelTitle);
               this.Margin = new System.Windows.Forms.Padding(7);
               this.Name = "FormMostLikely";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "MostLikely";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikely)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxCommentedPost;
        private System.Windows.Forms.Label labelMustComment;
        private System.Windows.Forms.TextBox textBoxCommentFriend;
        private System.Windows.Forms.Label labelCommentFriend;
        private System.Windows.Forms.TextBox textBoxFriendLike;
        private System.Windows.Forms.Label labelLikelyFriend;
        private System.Windows.Forms.TextBox textBoxLikelyPost;
        private System.Windows.Forms.Label labelLikelyPost;
        private System.Windows.Forms.PictureBox pictureBoxLikely;
        private System.Windows.Forms.Label labelLikelyPicture;
    }
}