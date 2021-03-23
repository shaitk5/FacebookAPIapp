
namespace FacebookApiApp
{
    partial class FormUserPosts
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
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(244, 100);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(297, 404);
            this.listBoxPosts.TabIndex = 5;
            // 
            // labelPostLists
            // 
            this.labelPostLists.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPostLists.AutoSize = true;
            this.labelPostLists.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostLists.Location = new System.Drawing.Point(278, 28);
            this.labelPostLists.Name = "labelPostLists";
            this.labelPostLists.Size = new System.Drawing.Size(247, 52);
            this.labelPostLists.TabIndex = 6;
            this.labelPostLists.Text = "Posts List:";
            // 
            // FormUserPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 510);
            this.Controls.Add(this.labelPostLists);
            this.Controls.Add(this.listBoxPosts);
            this.Name = "FormUserPosts";
            this.Text = "FormUserPosts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelPostLists;
    }
}