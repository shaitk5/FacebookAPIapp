
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
            this.labelAlbumList.Location = new System.Drawing.Point(235, 9);
            this.labelAlbumList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlbumList.Name = "labelAlbumList";
            this.labelAlbumList.Size = new System.Drawing.Size(314, 34);
            this.labelAlbumList.TabIndex = 6;
            this.labelAlbumList.Text = "Friends Birthday List:";
            // 
            // listBoxBirthdays
            // 
            this.listBoxBirthdays.FormattingEnabled = true;
            this.listBoxBirthdays.HorizontalScrollbar = true;
            this.listBoxBirthdays.Location = new System.Drawing.Point(273, 57);
            this.listBoxBirthdays.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBirthdays.Name = "listBoxBirthdays";
            this.listBoxBirthdays.Size = new System.Drawing.Size(250, 342);
            this.listBoxBirthdays.TabIndex = 7;
            // 
            // FormBirthday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxBirthdays);
            this.Controls.Add(this.labelAlbumList);
            this.Name = "FormBirthday";
            this.Text = "FormBirthday";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlbumList;
        private System.Windows.Forms.ListBox listBoxBirthdays;
    }
}