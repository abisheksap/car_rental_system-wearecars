namespace last_try
{
    partial class DisplayBookingsForm
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
            this.rtbBookings = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbBookings
            // 
            this.rtbBookings.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtbBookings.Location = new System.Drawing.Point(20, 50);
            this.rtbBookings.Name = "rtbBookings";
            this.rtbBookings.ReadOnly = true;
            this.rtbBookings.Size = new System.Drawing.Size(850, 550);
            this.rtbBookings.TabIndex = 0;
            this.rtbBookings.Text = "";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ALL BOOKINGS SUMMARY";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblCount.Location = new System.Drawing.Point(20, 620);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(122, 16);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Total Bookings: 0";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 10F);
            this.btnClose.Location = new System.Drawing.Point(380, 620);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Arial", 10F);
            this.btnPrint.Location = new System.Drawing.Point(520, 620);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 35);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print Summary";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.LightCoral;
            this.btnClearAll.Font = new System.Drawing.Font("Arial", 10F);
            this.btnClearAll.Location = new System.Drawing.Point(660, 620);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(150, 35);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "Clear All Bookings";
            this.btnClearAll.UseVisualStyleBackColor = false;
            // 
            // DisplayBookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rtbBookings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayBookingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "All Bookings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbBookings;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClearAll;
    }
}