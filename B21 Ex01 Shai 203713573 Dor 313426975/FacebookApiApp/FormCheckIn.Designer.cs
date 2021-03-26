
namespace FacebookApiApp
{
    partial class FormCheckIn
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
               this.label1 = new System.Windows.Forms.Label();
               this.listBoxCheckins = new System.Windows.Forms.ListBox();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(670, 20);
               this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(544, 87);
               this.label1.TabIndex = 1;
               this.label1.Text = "Check-In List:";
               // 
               // listBoxCheckins
               // 
               this.listBoxCheckins.FormattingEnabled = true;
               this.listBoxCheckins.HorizontalScrollbar = true;
               this.listBoxCheckins.ItemHeight = 29;
               this.listBoxCheckins.Location = new System.Drawing.Point(595, 149);
               this.listBoxCheckins.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
               this.listBoxCheckins.Name = "listBoxCheckins";
               this.listBoxCheckins.Size = new System.Drawing.Size(685, 874);
               this.listBoxCheckins.TabIndex = 2;
               // 
               // FormCheckIn
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1867, 1053);
               this.Controls.Add(this.listBoxCheckins);
               this.Controls.Add(this.label1);
               this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
               this.Name = "FormCheckIn";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "FormCheckIn";
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCheckins;
    }
}