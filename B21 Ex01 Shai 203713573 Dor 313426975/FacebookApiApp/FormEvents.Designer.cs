
namespace FacebookApiApp
{
    partial class FormEvents
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
            this.labelEventsList = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelEventsList
            // 
            this.labelEventsList.AutoSize = true;
            this.labelEventsList.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventsList.Location = new System.Drawing.Point(90, 9);
            this.labelEventsList.Name = "labelEventsList";
            this.labelEventsList.Size = new System.Drawing.Size(327, 33);
            this.labelEventsList.TabIndex = 6;
            this.labelEventsList.Text = "Your future events list:";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.HorizontalScrollbar = true;
            this.listBoxEvents.Location = new System.Drawing.Point(96, 59);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(356, 420);
            this.listBoxEvents.TabIndex = 7;
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 491);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.labelEventsList);
            this.Name = "FormEvents";
            this.Text = "FormEvents";
            this.Load += new System.EventHandler(this.FormEvents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEventsList;
        private System.Windows.Forms.ListBox listBoxEvents;
    }
}