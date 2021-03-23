
namespace FacebookApiApp
{
    partial class FormGroups
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
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.labelGroupList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.HorizontalScrollbar = true;
            this.listBoxGroups.Location = new System.Drawing.Point(82, 62);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(320, 394);
            this.listBoxGroups.TabIndex = 5;
            // 
            // labelGroupList
            // 
            this.labelGroupList.AutoSize = true;
            this.labelGroupList.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroupList.Location = new System.Drawing.Point(124, 9);
            this.labelGroupList.Name = "labelGroupList";
            this.labelGroupList.Size = new System.Drawing.Size(230, 42);
            this.labelGroupList.TabIndex = 6;
            this.labelGroupList.Text = "Groups List:";
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 468);
            this.Controls.Add(this.labelGroupList);
            this.Controls.Add(this.listBoxGroups);
            this.Name = "FormGroups";
            this.Text = "FormGroups";
            this.Load += new System.EventHandler(this.FormGroups_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label labelGroupList;
    }
}