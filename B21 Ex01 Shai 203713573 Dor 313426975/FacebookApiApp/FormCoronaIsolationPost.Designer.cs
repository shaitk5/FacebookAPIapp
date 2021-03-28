namespace FacebookApiApp
{
    public partial class FormCoronaIsolationPost
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCoronaIsolationPost));
               this.labelCorona = new System.Windows.Forms.Label();
               this.textBoxCorona = new System.Windows.Forms.TextBox();
               this.pictureBoxPost = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
               this.SuspendLayout();
               // 
               // labelCorona
               // 
               this.labelCorona.AutoSize = true;
               this.labelCorona.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.labelCorona.Location = new System.Drawing.Point(336, 20);
               this.labelCorona.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
               this.labelCorona.Name = "labelCorona";
               this.labelCorona.Size = new System.Drawing.Size(1102, 102);
               this.labelCorona.TabIndex = 1;
               this.labelCorona.Text = "Covid-19 Post will tag all of your friends and places\r\n that you were with in the" +
    " last month";
               this.labelCorona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // textBoxCorona
               // 
               this.textBoxCorona.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
               this.textBoxCorona.Location = new System.Drawing.Point(392, 230);
               this.textBoxCorona.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.textBoxCorona.Multiline = true;
               this.textBoxCorona.Name = "textBoxCorona";
               this.textBoxCorona.ScrollBars = System.Windows.Forms.ScrollBars.Both;
               this.textBoxCorona.Size = new System.Drawing.Size(1080, 539);
               this.textBoxCorona.TabIndex = 2;
               this.textBoxCorona.Text = resources.GetString("textBoxCorona.Text");
               // 
               // pictureBoxPost
               // 
               this.pictureBoxPost.Image = global::FacebookApiApp.Properties.Resources.PostLogo;
               this.pictureBoxPost.Location = new System.Drawing.Point(1286, 783);
               this.pictureBoxPost.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.pictureBoxPost.Name = "pictureBoxPost";
               this.pictureBoxPost.Size = new System.Drawing.Size(191, 172);
               this.pictureBoxPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBoxPost.TabIndex = 3;
               this.pictureBoxPost.TabStop = false;
               this.pictureBoxPost.Click += new System.EventHandler(this.pictureBoxPost_Click);
               // 
               // FormCoronaIsolationPost
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
               this.AutoSize = true;
               this.ClientSize = new System.Drawing.Size(1867, 1004);
               this.Controls.Add(this.pictureBoxPost);
               this.Controls.Add(this.textBoxCorona);
               this.Controls.Add(this.labelCorona);
               this.Margin = new System.Windows.Forms.Padding(7);
               this.Name = "FormCoronaIsolationPost";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "FormCoronaIsolationPost";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCorona;
        private System.Windows.Forms.TextBox textBoxCorona;
        private System.Windows.Forms.PictureBox pictureBoxPost;
    }
}