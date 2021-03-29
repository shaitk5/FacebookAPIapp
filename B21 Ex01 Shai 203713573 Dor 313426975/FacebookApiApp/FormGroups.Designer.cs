namespace FacebookApiApp
{
    public partial class FormGroups
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
               this.listBoxGroups.ItemHeight = 29;
               this.listBoxGroups.Location = new System.Drawing.Point(187, 139);
               this.listBoxGroups.Margin = new System.Windows.Forms.Padding(7);
               this.listBoxGroups.Name = "listBoxGroups";
               this.listBoxGroups.Size = new System.Drawing.Size(791, 874);
               this.listBoxGroups.TabIndex = 5;
               // 
               // labelGroupList
               // 
               this.labelGroupList.AutoSize = true;
               this.labelGroupList.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelGroupList.Location = new System.Drawing.Point(289, 20);
               this.labelGroupList.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
               this.labelGroupList.Name = "labelGroupList";
               this.labelGroupList.Size = new System.Drawing.Size(511, 94);
               this.labelGroupList.TabIndex = 6;
               this.labelGroupList.Text = "Groups List:";
               // 
               // FormGroups
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
               this.AutoSize = true;
               this.ClientSize = new System.Drawing.Size(1134, 1044);
               this.Controls.Add(this.labelGroupList);
               this.Controls.Add(this.listBoxGroups);
               this.Margin = new System.Windows.Forms.Padding(7);
               this.Name = "FormGroups";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Groups";
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label labelGroupList;
    }
}