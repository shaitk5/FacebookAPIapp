namespace FacebookApiApp
{
    public partial class FormUserPosts
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
               this.listBoxPosts = new System.Windows.Forms.ListBox();
               this.labelPostLists = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // listBoxPosts
               // 
               this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
               this.listBoxPosts.FormattingEnabled = true;
               this.listBoxPosts.HorizontalScrollbar = true;
               this.listBoxPosts.ItemHeight = 29;
               this.listBoxPosts.Location = new System.Drawing.Point(331, 181);
               this.listBoxPosts.Margin = new System.Windows.Forms.Padding(5);
               this.listBoxPosts.Name = "listBoxPosts";
               this.listBoxPosts.Size = new System.Drawing.Size(791, 729);
               this.listBoxPosts.TabIndex = 5;
               // 
               // labelPostLists
               // 
               this.labelPostLists.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
               this.labelPostLists.AutoSize = true;
               this.labelPostLists.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelPostLists.Location = new System.Drawing.Point(486, 51);
               this.labelPostLists.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
               this.labelPostLists.Name = "labelPostLists";
               this.labelPostLists.Size = new System.Drawing.Size(443, 94);
               this.labelPostLists.TabIndex = 6;
               this.labelPostLists.Text = "Posts List:";
               // 
               // FormUserPosts
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
               this.AutoSize = true;
               this.ClientSize = new System.Drawing.Size(1360, 924);
               this.Controls.Add(this.labelPostLists);
               this.Controls.Add(this.listBoxPosts);
               this.Margin = new System.Windows.Forms.Padding(5);
               this.Name = "FormUserPosts";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "FormUserPosts";
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelPostLists;
    }
}