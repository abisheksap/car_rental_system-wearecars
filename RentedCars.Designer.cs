namespace last_try
{
    partial class RentedCars
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentedCars));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvRentedCars = new System.Windows.Forms.DataGridView();
            this.FN_SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedCars)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(278, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(435, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "---CURRENTLY-RENTED CARS--";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.lblStatus.Location = new System.Drawing.Point(20, 123);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(136, 20);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Active Rentals: 0";
            // 
            // dgvRentedCars
            // 
            this.dgvRentedCars.AllowUserToAddRows = false;
            this.dgvRentedCars.AllowUserToDeleteRows = false;
            this.dgvRentedCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentedCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentedCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FN_SN,
            this.CarType,
            this.dl,
            this.days,
            this.Cost,
            this.Status});
            this.dgvRentedCars.Location = new System.Drawing.Point(24, 146);
            this.dgvRentedCars.Name = "dgvRentedCars";
            this.dgvRentedCars.ReadOnly = true;
            this.dgvRentedCars.RowHeadersVisible = false;
            this.dgvRentedCars.RowHeadersWidth = 51;
            this.dgvRentedCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentedCars.Size = new System.Drawing.Size(850, 400);
            this.dgvRentedCars.TabIndex = 2;
            this.dgvRentedCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentedCars_CellContentClick);
            // 
            // FN_SN
            // 
            this.FN_SN.HeaderText = "Full Name";
            this.FN_SN.MinimumWidth = 6;
            this.FN_SN.Name = "FN_SN";
            this.FN_SN.ReadOnly = true;
            // 
            // CarType
            // 
            this.CarType.HeaderText = "Car Type";
            this.CarType.MinimumWidth = 6;
            this.CarType.Name = "CarType";
            this.CarType.ReadOnly = true;
            // 
            // dl
            // 
            this.dl.HeaderText = "Driving License";
            this.dl.MinimumWidth = 6;
            this.dl.Name = "dl";
            this.dl.ReadOnly = true;
            // 
            // days
            // 
            this.days.HeaderText = "No of days";
            this.days.MinimumWidth = 6;
            this.days.Name = "days";
            this.days.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Column1";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.Controls.Add(this.btnReturnCar);
            this.panelButtons.Controls.Add(this.btnClose);
            this.panelButtons.Location = new System.Drawing.Point(20, 583);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(850, 50);
            this.panelButtons.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(166, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnRefresh_Click);
            this.button1.MouseHover += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.BackColor = System.Drawing.Color.LightGreen;
            this.btnReturnCar.Location = new System.Drawing.Point(10, 10);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(150, 35);
            this.btnReturnCar.TabIndex = 0;
            this.btnReturnCar.Text = "Mark as Returned";
            this.btnReturnCar.UseVisualStyleBackColor = false;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(720, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.pictureBox1.Location = new System.Drawing.Point(167, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 102);
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-6, -29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(184, 132);
            this.pictureBox3.TabIndex = 117;
            this.pictureBox3.TabStop = false;
            // 
            // RentedCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 695);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.dgvRentedCars);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentedCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Currently Rented Cars";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedCars)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvRentedCars;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn FN_SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dl;
        private System.Windows.Forms.DataGridViewTextBoxColumn days;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}