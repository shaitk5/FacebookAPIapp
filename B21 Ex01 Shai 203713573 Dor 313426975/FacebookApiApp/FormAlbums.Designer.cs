
namespace FacebookApiApp
{
    partial class FormAlbums
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
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.labelAlbumList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.HorizontalScrollbar = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(251, 66);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(320, 394);
            this.listBoxAlbums.TabIndex = 3;
            // 
            // labelAlbumList
            // 
            this.labelAlbumList.AutoSize = true;
            this.labelAlbumList.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumList.Location = new System.Drawing.Point(288, 9);
            this.labelAlbumList.Name = "labelAlbumList";
            this.labelAlbumList.Size = new System.Drawing.Size(235, 42);
            this.labelAlbumList.TabIndex = 4;
            this.labelAlbumList.Text = "Albums List:";
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.labelAlbumList);
            this.Controls.Add(this.listBoxAlbums);
            this.Name = "FormAlbums";
            this.Text = "FormAlbums";
            this.Load += new System.EventHandler(this.FormAlbums_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label labelAlbumList;
    }
}