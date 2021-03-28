namespace FacebookApiApp
{
    public partial class FormProfile
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
               this.textBoxPost = new System.Windows.Forms.TextBox();
               this.labelBirthday = new System.Windows.Forms.Label();
               this.labelGender = new System.Windows.Forms.Label();
               this.buttonLogOut = new System.Windows.Forms.Button();
               this.openFileUploadPicture = new System.Windows.Forms.OpenFileDialog();
               this.labelLogInName = new System.Windows.Forms.Label();
               this.pictureBoxProfilePic = new System.Windows.Forms.PictureBox();
               this.LogoPicture = new System.Windows.Forms.PictureBox();
               this.pictureBoxGroups = new System.Windows.Forms.PictureBox();
               this.pictureBoxEvents = new System.Windows.Forms.PictureBox();
               this.pictureBoxMyPosts = new System.Windows.Forms.PictureBox();
               this.pictureBoxUpload = new System.Windows.Forms.PictureBox();
               this.pictureBoxAlbums = new System.Windows.Forms.PictureBox();
               this.pictureBoxBirthday = new System.Windows.Forms.PictureBox();
               this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
               this.pictureBoxCheckin = new System.Windows.Forms.PictureBox();
               this.pictureBoxCorona = new System.Windows.Forms.PictureBox();
               this.pictureBoxLikely = new System.Windows.Forms.PictureBox();
               this.pictureBoxPost = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyPosts)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirthday)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckin)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorona)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikely)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
               this.SuspendLayout();
               // 
               // textBoxPost
               // 
               this.textBoxPost.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
               this.textBoxPost.BackColor = System.Drawing.Color.White;
               this.textBoxPost.Location = new System.Drawing.Point(691, 629);
               this.textBoxPost.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.textBoxPost.Multiline = true;
               this.textBoxPost.Name = "textBoxPost";
               this.textBoxPost.ScrollBars = System.Windows.Forms.ScrollBars.Both;
               this.textBoxPost.Size = new System.Drawing.Size(1087, 180);
               this.textBoxPost.TabIndex = 14;
               // 
               // labelBirthday
               // 
               this.labelBirthday.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.labelBirthday.AutoSize = true;
               this.labelBirthday.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelBirthday.Location = new System.Drawing.Point(684, 361);
               this.labelBirthday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
               this.labelBirthday.Name = "labelBirthday";
               this.labelBirthday.Size = new System.Drawing.Size(181, 40);
               this.labelBirthday.TabIndex = 17;
               this.labelBirthday.Text = "Birthday: ";
               this.labelBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // labelGender
               // 
               this.labelGender.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.labelGender.AutoSize = true;
               this.labelGender.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelGender.Location = new System.Drawing.Point(1608, 361);
               this.labelGender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
               this.labelGender.Name = "labelGender";
               this.labelGender.Size = new System.Drawing.Size(170, 40);
               this.labelGender.TabIndex = 18;
               this.labelGender.Text = "Gender:  ";
               this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // buttonLogOut
               // 
               this.buttonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.buttonLogOut.BackColor = System.Drawing.Color.CornflowerBlue;
               this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
               this.buttonLogOut.Location = new System.Drawing.Point(2315, 40);
               this.buttonLogOut.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.buttonLogOut.Name = "buttonLogOut";
               this.buttonLogOut.Size = new System.Drawing.Size(175, 161);
               this.buttonLogOut.TabIndex = 20;
               this.buttonLogOut.Text = "Log Out";
               this.buttonLogOut.UseVisualStyleBackColor = false;
               this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
               // 
               // openFileUploadPicture
               // 
               this.openFileUploadPicture.FileName = "openFileUploadPicture";
               // 
               // labelLogInName
               // 
               this.labelLogInName.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.labelLogInName.AutoSize = true;
               this.labelLogInName.BackColor = System.Drawing.Color.Transparent;
               this.labelLogInName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelLogInName.Location = new System.Drawing.Point(1080, 265);
               this.labelLogInName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
               this.labelLogInName.Name = "labelLogInName";
               this.labelLogInName.Size = new System.Drawing.Size(291, 40);
               this.labelLogInName.TabIndex = 27;
               this.labelLogInName.Text = "Hello, UserName";
               this.labelLogInName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
               // 
               // pictureBoxProfilePic
               // 
               this.pictureBoxProfilePic.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.pictureBoxProfilePic.Location = new System.Drawing.Point(1113, 40);
               this.pictureBoxProfilePic.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
               this.pictureBoxProfilePic.Name = "pictureBoxProfilePic";
               this.pictureBoxProfilePic.Size = new System.Drawing.Size(229, 219);
               this.pictureBoxProfilePic.TabIndex = 26;
               this.pictureBoxProfilePic.TabStop = false;
               // 
               // LogoPicture
               // 
               this.LogoPicture.BackColor = System.Drawing.Color.White;
               this.LogoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.LogoPicture.Cursor = System.Windows.Forms.Cursors.Arrow;
               this.LogoPicture.Image = global::FacebookApiApp.Properties.Resources.FacebookLogo;
               this.LogoPicture.Location = new System.Drawing.Point(49, 40);
               this.LogoPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.LogoPicture.Name = "LogoPicture";
               this.LogoPicture.Size = new System.Drawing.Size(201, 178);
               this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.LogoPicture.TabIndex = 25;
               this.LogoPicture.TabStop = false;
               // 
               // pictureBoxGroups
               // 
               this.pictureBoxGroups.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
               this.pictureBoxGroups.BackColor = System.Drawing.Color.MidnightBlue;
               this.pictureBoxGroups.Image = global::FacebookApiApp.Properties.Resources.FacebookGroupsLogo;
               this.pictureBoxGroups.Location = new System.Drawing.Point(971, 453);
               this.pictureBoxGroups.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.pictureBoxGroups.Name = "pictureBoxGroups";
               this.pictureBoxGroups.Size = new System.Drawing.Size(177, 145);
               this.pictureBoxGroups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxGroups.TabIndex = 23;
               this.pictureBoxGroups.TabStop = false;
               this.pictureBoxGroups.Click += new System.EventHandler(this.pictureBoxGroups_Click);
               // 
               // pictureBoxEvents
               // 
               this.pictureBoxEvents.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
               this.pictureBoxEvents.BackColor = System.Drawing.Color.AliceBlue;
               this.pictureBoxEvents.Image = global::FacebookApiApp.Properties.Resources.FacebookEventsLogo;
               this.pictureBoxEvents.Location = new System.Drawing.Point(1351, 453);
               this.pictureBoxEvents.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.pictureBoxEvents.Name = "pictureBoxEvents";
               this.pictureBoxEvents.Size = new System.Drawing.Size(182, 145);
               this.pictureBoxEvents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBoxEvents.TabIndex = 22;
               this.pictureBoxEvents.TabStop = false;
               this.pictureBoxEvents.Click += new System.EventHandler(this.pictureBoxEvents_Click);
               // 
               // pictureBoxMyPosts
               // 
               this.pictureBoxMyPosts.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
               this.pictureBoxMyPosts.BackColor = System.Drawing.Color.MidnightBlue;
               this.pictureBoxMyPosts.Image = global::FacebookApiApp.Properties.Resources.MyPostLogo;
               this.pictureBoxMyPosts.Location = new System.Drawing.Point(621, 453);
               this.pictureBoxMyPosts.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.pictureBoxMyPosts.Name = "pictureBoxMyPosts";
               this.pictureBoxMyPosts.Size = new System.Drawing.Size(166, 145);
               this.pictureBoxMyPosts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxMyPosts.TabIndex = 21;
               this.pictureBoxMyPosts.TabStop = false;
               this.pictureBoxMyPosts.Click += new System.EventHandler(this.pictureBoxMyPosts_Click);
               // 
               // pictureBoxUpload
               // 
               this.pictureBoxUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.pictureBoxUpload.BackColor = System.Drawing.Color.Transparent;
               this.pictureBoxUpload.Image = global::FacebookApiApp.Properties.Resources.PhotoLogo;
               this.pictureBoxUpload.Location = new System.Drawing.Point(686, 828);
               this.pictureBoxUpload.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.pictureBoxUpload.Name = "pictureBoxUpload";
               this.pictureBoxUpload.Size = new System.Drawing.Size(187, 187);
               this.pictureBoxUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBoxUpload.TabIndex = 15;
               this.pictureBoxUpload.TabStop = false;
               this.pictureBoxUpload.Click += new System.EventHandler(this.pictureBoxUpload_Click);
               // 
               // pictureBoxAlbums
               // 
               this.pictureBoxAlbums.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
               this.pictureBoxAlbums.BackColor = System.Drawing.Color.MidnightBlue;
               this.pictureBoxAlbums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
               this.pictureBoxAlbums.Image = global::FacebookApiApp.Properties.Resources.facebookAlbumsLogo;
               this.pictureBoxAlbums.Location = new System.Drawing.Point(443, 453);
               this.pictureBoxAlbums.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.pictureBoxAlbums.Name = "pictureBoxAlbums";
               this.pictureBoxAlbums.Size = new System.Drawing.Size(168, 145);
               this.pictureBoxAlbums.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxAlbums.TabIndex = 8;
               this.pictureBoxAlbums.TabStop = false;
               this.pictureBoxAlbums.Click += new System.EventHandler(this.pictureBoxAlbums_Click);
               // 
               // pictureBoxBirthday
               // 
               this.pictureBoxBirthday.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
               this.pictureBoxBirthday.BackColor = System.Drawing.Color.MidnightBlue;
               this.pictureBoxBirthday.Cursor = System.Windows.Forms.Cursors.Default;
               this.pictureBoxBirthday.Image = global::FacebookApiApp.Properties.Resources.BirthdayLogo;
               this.pictureBoxBirthday.Location = new System.Drawing.Point(1734, 453);
               this.pictureBoxBirthday.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.pictureBoxBirthday.Name = "pictureBoxBirthday";
               this.pictureBoxBirthday.Size = new System.Drawing.Size(184, 145);
               this.pictureBoxBirthday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxBirthday.TabIndex = 7;
               this.pictureBoxBirthday.TabStop = false;
               this.pictureBoxBirthday.Click += new System.EventHandler(this.pictureBoxBirthday_Click);
               // 
               // pictureBoxFriends
               // 
               this.pictureBoxFriends.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
               this.pictureBoxFriends.BackColor = System.Drawing.Color.MidnightBlue;
               this.pictureBoxFriends.Image = global::FacebookApiApp.Properties.Resources.FriendsLogo;
               this.pictureBoxFriends.Location = new System.Drawing.Point(796, 453);
               this.pictureBoxFriends.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.pictureBoxFriends.Name = "pictureBoxFriends";
               this.pictureBoxFriends.Size = new System.Drawing.Size(166, 145);
               this.pictureBoxFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxFriends.TabIndex = 6;
               this.pictureBoxFriends.TabStop = false;
               this.pictureBoxFriends.Click += new System.EventHandler(this.pictureBoxFriends_Click);
               // 
               // pictureBoxCheckin
               // 
               this.pictureBoxCheckin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
               this.pictureBoxCheckin.BackColor = System.Drawing.Color.MidnightBlue;
               this.pictureBoxCheckin.Image = global::FacebookApiApp.Properties.Resources.FacebookCheckinsLogo;
               this.pictureBoxCheckin.Location = new System.Drawing.Point(1157, 453);
               this.pictureBoxCheckin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.pictureBoxCheckin.Name = "pictureBoxCheckin";
               this.pictureBoxCheckin.Size = new System.Drawing.Size(184, 145);
               this.pictureBoxCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBoxCheckin.TabIndex = 5;
               this.pictureBoxCheckin.TabStop = false;
               this.pictureBoxCheckin.Click += new System.EventHandler(this.pictureBoxCheckin_Click);
               // 
               // pictureBoxCorona
               // 
               this.pictureBoxCorona.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
               this.pictureBoxCorona.BackColor = System.Drawing.Color.MidnightBlue;
               this.pictureBoxCorona.Image = global::FacebookApiApp.Properties.Resources.FacebookCoronaLogo;
               this.pictureBoxCorona.Location = new System.Drawing.Point(1542, 453);
               this.pictureBoxCorona.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.pictureBoxCorona.Name = "pictureBoxCorona";
               this.pictureBoxCorona.Size = new System.Drawing.Size(182, 145);
               this.pictureBoxCorona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBoxCorona.TabIndex = 4;
               this.pictureBoxCorona.TabStop = false;
               this.pictureBoxCorona.Click += new System.EventHandler(this.pictureBoxCorona_Click);
               // 
               // pictureBoxLikely
               // 
               this.pictureBoxLikely.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
               this.pictureBoxLikely.BackColor = System.Drawing.Color.MidnightBlue;
               this.pictureBoxLikely.Image = global::FacebookApiApp.Properties.Resources.MostLikelyFacebook;
               this.pictureBoxLikely.Location = new System.Drawing.Point(1927, 453);
               this.pictureBoxLikely.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.pictureBoxLikely.Name = "pictureBoxLikely";
               this.pictureBoxLikely.Size = new System.Drawing.Size(177, 145);
               this.pictureBoxLikely.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBoxLikely.TabIndex = 3;
               this.pictureBoxLikely.TabStop = false;
               this.pictureBoxLikely.Click += new System.EventHandler(this.pictureBoxMostLikely_Click);
               // 
               // pictureBoxPost
               // 
               this.pictureBoxPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.pictureBoxPost.BackColor = System.Drawing.Color.White;
               this.pictureBoxPost.Image = global::FacebookApiApp.Properties.Resources.PostLogo;
               this.pictureBoxPost.Location = new System.Drawing.Point(1598, 828);
               this.pictureBoxPost.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.pictureBoxPost.Name = "pictureBoxPost";
               this.pictureBoxPost.Size = new System.Drawing.Size(184, 187);
               this.pictureBoxPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBoxPost.TabIndex = 2;
               this.pictureBoxPost.TabStop = false;
               this.pictureBoxPost.Click += new System.EventHandler(this.pictureBoxPost_Click);
               // 
               // FormProfile
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSize = true;
               this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
               this.BackColor = System.Drawing.Color.Azure;
               this.CausesValidation = false;
               this.ClientSize = new System.Drawing.Size(2515, 1109);
               this.Controls.Add(this.labelLogInName);
               this.Controls.Add(this.pictureBoxProfilePic);
               this.Controls.Add(this.LogoPicture);
               this.Controls.Add(this.pictureBoxGroups);
               this.Controls.Add(this.pictureBoxEvents);
               this.Controls.Add(this.pictureBoxMyPosts);
               this.Controls.Add(this.buttonLogOut);
               this.Controls.Add(this.labelGender);
               this.Controls.Add(this.labelBirthday);
               this.Controls.Add(this.pictureBoxUpload);
               this.Controls.Add(this.pictureBoxAlbums);
               this.Controls.Add(this.pictureBoxBirthday);
               this.Controls.Add(this.pictureBoxFriends);
               this.Controls.Add(this.pictureBoxCheckin);
               this.Controls.Add(this.pictureBoxCorona);
               this.Controls.Add(this.pictureBoxLikely);
               this.Controls.Add(this.pictureBoxPost);
               this.Controls.Add(this.textBoxPost);
               this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.Name = "FormProfile";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "FormFacebook";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyPosts)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirthday)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheckin)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorona)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikely)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxPost;
        private System.Windows.Forms.PictureBox pictureBoxLikely;
        private System.Windows.Forms.PictureBox pictureBoxCorona;
        private System.Windows.Forms.PictureBox pictureBoxCheckin;
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxBirthday;
        private System.Windows.Forms.PictureBox pictureBoxAlbums;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.PictureBox pictureBoxUpload;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.OpenFileDialog openFileUploadPicture;
        private System.Windows.Forms.PictureBox pictureBoxMyPosts;
        private System.Windows.Forms.PictureBox pictureBoxEvents;
        private System.Windows.Forms.PictureBox pictureBoxGroups;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.PictureBox pictureBoxProfilePic;
        private System.Windows.Forms.Label labelLogInName;
    }
}