
namespace FacebookApiApp
{
    partial class FormBirthday
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
               this.labelAlbumList = new System.Windows.Forms.Label();
               this.listBoxBirthdays = new System.Windows.Forms.ListBox();
               this.SuspendLayout();
               // 
               // labelAlbumList
               // 
               this.labelAlbumList.AutoSize = true;
               this.labelAlbumList.Font = new System.Drawing.Font("Tahoma", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelAlbumList.Location = new System.Drawing.Point(548, 20);
               this.labelAlbumList.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
               this.labelAlbumList.Name = "labelAlbumList";
               this.labelAlbumList.Size = new System.Drawing.Size(706, 76);
               this.labelAlbumList.TabIndex = 6;
               this.labelAlbumList.Text = "Friends Birthday List:";
               // 
               // listBoxBirthdays
               // 
               this.listBoxBirthdays.FormattingEnabled = true;
               this.listBoxBirthdays.HorizontalScrollbar = true;
               this.listBoxBirthdays.ItemHeight = 29;
               this.listBoxBirthdays.Location = new System.Drawing.Point(637, 127);
               this.listBoxBirthdays.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.listBoxBirthdays.Name = "listBoxBirthdays";
               this.listBoxBirthdays.Size = new System.Drawing.Size(578, 758);
               this.listBoxBirthdays.TabIndex = 7;
               // 
               // FormBirthday
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1867, 1004);
               this.Controls.Add(this.listBoxBirthdays);
               this.Controls.Add(this.labelAlbumList);
               this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
               this.Name = "FormBirthday";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "FormBirthday";
               this.Load += new System.EventHandler(this.FormBirthday_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlbumList;
        private System.Windows.Forms.ListBox listBoxBirthdays;
    }
}