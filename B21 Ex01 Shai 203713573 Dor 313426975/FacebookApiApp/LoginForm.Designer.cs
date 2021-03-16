namespace FacebookApiApp
{
     partial class LoginForm
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
               if(disposing && (components != null))
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
               this.checkBox1 = new System.Windows.Forms.CheckBox();
               this.LogoPicture = new System.Windows.Forms.PictureBox();
               this.LoginButton = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
               this.SuspendLayout();
               // 
               // checkBox1
               // 
               this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.checkBox1.AutoSize = true;
               this.checkBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
               this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.checkBox1.Location = new System.Drawing.Point(335, 744);
               this.checkBox1.Name = "checkBox1";
               this.checkBox1.Size = new System.Drawing.Size(247, 40);
               this.checkBox1.TabIndex = 2;
               this.checkBox1.Text = "Remember Me!";
               this.checkBox1.UseVisualStyleBackColor = true;
               // 
               // LogoPicture
               // 
               this.LogoPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.LogoPicture.BackColor = System.Drawing.Color.White;
               this.LogoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.LogoPicture.Cursor = System.Windows.Forms.Cursors.Arrow;
               this.LogoPicture.Image = global::FacebookApiApp.Properties.Resources.FacebookLogo;
               this.LogoPicture.Location = new System.Drawing.Point(272, 93);
               this.LogoPicture.Name = "LogoPicture";
               this.LogoPicture.Size = new System.Drawing.Size(384, 379);
               this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.LogoPicture.TabIndex = 1;
               this.LogoPicture.TabStop = false;
               // 
               // LoginButton
               // 
               this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.LoginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.LoginButton.BackgroundImage = global::FacebookApiApp.Properties.Resources.FacebookLoginButton;
               this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.LoginButton.Cursor = System.Windows.Forms.Cursors.Arrow;
               this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.LoginButton.Location = new System.Drawing.Point(235, 617);
               this.LoginButton.Name = "LoginButton";
               this.LoginButton.Size = new System.Drawing.Size(453, 106);
               this.LoginButton.TabIndex = 0;
               this.LoginButton.UseVisualStyleBackColor = false;
               this.LoginButton.Click += new System.EventHandler(this.LoginButtonOnClick);
               // 
               // LoginForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
               this.AutoSize = true;
               this.BackColor = System.Drawing.Color.White;
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClientSize = new System.Drawing.Size(950, 921);
               this.Controls.Add(this.checkBox1);
               this.Controls.Add(this.LogoPicture);
               this.Controls.Add(this.LoginButton);
               this.Cursor = System.Windows.Forms.Cursors.Default;
               this.ImeMode = System.Windows.Forms.ImeMode.Off;
               this.MaximumSize = new System.Drawing.Size(978, 1000);
               this.MinimumSize = new System.Drawing.Size(539, 833);
               this.Name = "LoginForm";
               this.Text = "FacebookAPI ";
               ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button LoginButton;
          private System.Windows.Forms.PictureBox LogoPicture;
          private System.Windows.Forms.CheckBox checkBox1;
     }
}

