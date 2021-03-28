
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlbums));
               this.listBoxAlbums = new System.Windows.Forms.ListBox();
               this.labelAlbumList = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // listBoxAlbums
               // 
               this.listBoxAlbums.FormattingEnabled = true;
               resources.ApplyResources(this.listBoxAlbums, "listBoxAlbums");
               this.listBoxAlbums.Name = "listBoxAlbums";
               // 
               // labelAlbumList
               // 
               resources.ApplyResources(this.labelAlbumList, "labelAlbumList");
               this.labelAlbumList.Name = "labelAlbumList";
               // 
               // FormAlbums
               // 
               resources.ApplyResources(this, "$this");
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
               this.Controls.Add(this.labelAlbumList);
               this.Controls.Add(this.listBoxAlbums);
               this.Name = "FormAlbums";
               this.Load += new System.EventHandler(this.FormAlbums_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label labelAlbumList;
    }
}