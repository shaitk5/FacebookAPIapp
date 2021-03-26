
namespace FacebookApiApp
{
    partial class FormCoronaIsolationPost
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
            this.labelCorona.Location = new System.Drawing.Point(144, 9);
            this.labelCorona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCorona.Name = "labelCorona";
            this.labelCorona.Size = new System.Drawing.Size(504, 46);
            this.labelCorona.TabIndex = 1;
            this.labelCorona.Text = "Covid-19 Post will tag all of your friends and places\r\n that you were with in the" +
    " last month";
            this.labelCorona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCorona
            // 
            this.textBoxCorona.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxCorona.Location = new System.Drawing.Point(168, 103);
            this.textBoxCorona.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCorona.Multiline = true;
            this.textBoxCorona.Name = "textBoxCorona";
            this.textBoxCorona.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCorona.Size = new System.Drawing.Size(465, 244);
            this.textBoxCorona.TabIndex = 2;
            this.textBoxCorona.Text = resources.GetString("textBoxCorona.Text");
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.Image = global::FacebookApiApp.Properties.Resources.PostLogo;
            this.pictureBoxPost.Location = new System.Drawing.Point(551, 351);
            this.pictureBoxPost.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(82, 77);
            this.pictureBoxPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPost.TabIndex = 3;
            this.pictureBoxPost.TabStop = false;
            // 
            // FormCoronaIsolationPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxPost);
            this.Controls.Add(this.textBoxCorona);
            this.Controls.Add(this.labelCorona);
            this.Name = "FormCoronaIsolationPost";
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