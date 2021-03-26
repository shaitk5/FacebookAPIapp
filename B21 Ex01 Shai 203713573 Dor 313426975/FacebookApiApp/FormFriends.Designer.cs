
namespace FacebookApiApp
{
    partial class FormFriends
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
               this.labelFriendsList = new System.Windows.Forms.Label();
               this.listBoxFriends = new System.Windows.Forms.ListBox();
               this.SuspendLayout();
               // 
               // labelFriendsList
               // 
               this.labelFriendsList.AutoSize = true;
               this.labelFriendsList.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelFriendsList.Location = new System.Drawing.Point(464, 16);
               this.labelFriendsList.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
               this.labelFriendsList.Name = "labelFriendsList";
               this.labelFriendsList.Size = new System.Drawing.Size(520, 94);
               this.labelFriendsList.TabIndex = 2;
               this.labelFriendsList.Text = "Friends List:";
               // 
               // listBoxFriends
               // 
               this.listBoxFriends.FormattingEnabled = true;
               this.listBoxFriends.HorizontalScrollbar = true;
               this.listBoxFriends.ItemHeight = 29;
               this.listBoxFriends.Location = new System.Drawing.Point(439, 116);
               this.listBoxFriends.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.listBoxFriends.Name = "listBoxFriends";
               this.listBoxFriends.Size = new System.Drawing.Size(557, 729);
               this.listBoxFriends.TabIndex = 3;
               // 
               // FormFriends
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1400, 895);
               this.Controls.Add(this.listBoxFriends);
               this.Controls.Add(this.labelFriendsList);
               this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.Name = "FormFriends";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "FormFriend";
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFriendsList;
        private System.Windows.Forms.ListBox listBoxFriends;
    }
}