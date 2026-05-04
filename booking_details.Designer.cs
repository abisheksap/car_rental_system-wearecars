namespace last_try

{ 
    partial class booking_details
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booking_details));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.chkValidLicense = new System.Windows.Forms.CheckBox();
            this.lblLicenseNumber = new System.Windows.Forms.Label();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.lblCarType = new System.Windows.Forms.Label();
            this.cmbCarType = new System.Windows.Forms.ComboBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.grpFuelType = new System.Windows.Forms.GroupBox();
            this.rbElectric = new System.Windows.Forms.RadioButton();
            this.rbHybrid = new System.Windows.Forms.RadioButton();
            this.rbDiesel = new System.Windows.Forms.RadioButton();
            this.rbPetrol = new System.Windows.Forms.RadioButton();
            this.grpExtras = new System.Windows.Forms.GroupBox();
            this.chkBreakdownCover = new System.Windows.Forms.CheckBox();
            this.chkUnlimitedMileage = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnViewBookings = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblheading = new System.Windows.Forms.Label();
            this.lblValidLicense = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.grpFuelType.SuspendLayout();
            this.grpExtras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(-28, 148);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(350, 25);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Customer First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(328, 148);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(300, 29);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblSurname
            // 
            this.lblSurname.Location = new System.Drawing.Point(-30, 188);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(352, 25);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Customer Surname:";
            this.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(328, 188);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(300, 29);
            this.txtSurname.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(-130, 232);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(448, 25);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Customer Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(328, 228);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 29);
            this.txtAddress.TabIndex = 2;
            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(138, 268);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(180, 25);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Customer Age:";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(328, 268);
            this.numAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(100, 29);
            this.numAge.TabIndex = 3;
            this.numAge.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // chkValidLicense
            // 
            this.chkValidLicense.AutoSize = true;
            this.chkValidLicense.Location = new System.Drawing.Point(328, 312);
            this.chkValidLicense.Name = "chkValidLicense";
            this.chkValidLicense.Size = new System.Drawing.Size(266, 26);
            this.chkValidLicense.TabIndex = 4;
            this.chkValidLicense.Text = "I have a valid driving license";
            this.chkValidLicense.UseVisualStyleBackColor = true;
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.Location = new System.Drawing.Point(138, 348);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(180, 25);
            this.lblLicenseNumber.TabIndex = 11;
            this.lblLicenseNumber.Text = "Driving License Number:";
            this.lblLicenseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Enabled = false;
            this.txtLicenseNumber.Location = new System.Drawing.Point(328, 348);
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(300, 29);
            this.txtLicenseNumber.TabIndex = 5;
            // 
            // lblDays
            // 
            this.lblDays.Location = new System.Drawing.Point(138, 388);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(180, 25);
            this.lblDays.TabIndex = 13;
            this.lblDays.Text = "Number of Days* (1-28):";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbDays
            // 
            this.cmbDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Location = new System.Drawing.Point(328, 388);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(300, 29);
            this.cmbDays.TabIndex = 6;
            // 
            // lblCarType
            // 
            this.lblCarType.Location = new System.Drawing.Point(138, 428);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(180, 25);
            this.lblCarType.TabIndex = 15;
            this.lblCarType.Text = "Type of Car*:";
            this.lblCarType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCarType
            // 
            this.cmbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarType.FormattingEnabled = true;
            this.cmbCarType.Location = new System.Drawing.Point(328, 428);
            this.cmbCarType.Name = "cmbCarType";
            this.cmbCarType.Size = new System.Drawing.Size(300, 29);
            this.cmbCarType.TabIndex = 7;
            this.cmbCarType.SelectedIndexChanged += new System.EventHandler(this.cmbCarType_SelectedIndexChanged);
            // 
            // lblFuelType
            // 
            this.lblFuelType.Location = new System.Drawing.Point(138, 468);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(180, 25);
            this.lblFuelType.TabIndex = 17;
            this.lblFuelType.Text = "Fuel Type*:";
            this.lblFuelType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpFuelType
            // 
            this.grpFuelType.Controls.Add(this.rbElectric);
            this.grpFuelType.Controls.Add(this.rbHybrid);
            this.grpFuelType.Controls.Add(this.rbDiesel);
            this.grpFuelType.Controls.Add(this.rbPetrol);
            this.grpFuelType.Location = new System.Drawing.Point(328, 468);
            this.grpFuelType.Name = "grpFuelType";
            this.grpFuelType.Size = new System.Drawing.Size(300, 140);
            this.grpFuelType.TabIndex = 8;
            this.grpFuelType.TabStop = false;
            this.grpFuelType.Text = "Select Fuel Type";
            // 
            // rbElectric
            // 
            this.rbElectric.AutoSize = true;
            this.rbElectric.Location = new System.Drawing.Point(20, 105);
            this.rbElectric.Name = "rbElectric";
            this.rbElectric.Size = new System.Drawing.Size(129, 26);
            this.rbElectric.TabIndex = 11;
            this.rbElectric.TabStop = true;
            this.rbElectric.Text = "Full Electric";
            this.rbElectric.UseVisualStyleBackColor = true;
            // 
            // rbHybrid
            // 
            this.rbHybrid.AutoSize = true;
            this.rbHybrid.Location = new System.Drawing.Point(20, 80);
            this.rbHybrid.Name = "rbHybrid";
            this.rbHybrid.Size = new System.Drawing.Size(85, 26);
            this.rbHybrid.TabIndex = 10;
            this.rbHybrid.TabStop = true;
            this.rbHybrid.Text = "Hybrid";
            this.rbHybrid.UseVisualStyleBackColor = true;
            // 
            // rbDiesel
            // 
            this.rbDiesel.AutoSize = true;
            this.rbDiesel.Location = new System.Drawing.Point(20, 55);
            this.rbDiesel.Name = "rbDiesel";
            this.rbDiesel.Size = new System.Drawing.Size(85, 26);
            this.rbDiesel.TabIndex = 9;
            this.rbDiesel.TabStop = true;
            this.rbDiesel.Text = "Diesel";
            this.rbDiesel.UseVisualStyleBackColor = true;
            // 
            // rbPetrol
            // 
            this.rbPetrol.AutoSize = true;
            this.rbPetrol.Location = new System.Drawing.Point(20, 30);
            this.rbPetrol.Name = "rbPetrol";
            this.rbPetrol.Size = new System.Drawing.Size(81, 26);
            this.rbPetrol.TabIndex = 8;
            this.rbPetrol.TabStop = true;
            this.rbPetrol.Text = "Petrol";
            this.rbPetrol.UseVisualStyleBackColor = true;
            // 
            // grpExtras
            // 
            this.grpExtras.Controls.Add(this.chkBreakdownCover);
            this.grpExtras.Controls.Add(this.chkUnlimitedMileage);
            this.grpExtras.Location = new System.Drawing.Point(211, 614);
            this.grpExtras.Name = "grpExtras";
            this.grpExtras.Size = new System.Drawing.Size(383, 100);
            this.grpExtras.TabIndex = 9;
            this.grpExtras.TabStop = false;
            this.grpExtras.Text = "Additional Features";
            // 
            // chkBreakdownCover
            // 
            this.chkBreakdownCover.AutoSize = true;
            this.chkBreakdownCover.Location = new System.Drawing.Point(20, 50);
            this.chkBreakdownCover.Name = "chkBreakdownCover";
            this.chkBreakdownCover.Size = new System.Drawing.Size(300, 26);
            this.chkBreakdownCover.TabIndex = 13;
            this.chkBreakdownCover.Text = "Breakdown Cover (+£2 per day)";
            this.chkBreakdownCover.UseVisualStyleBackColor = true;
            // 
            // chkUnlimitedMileage
            // 
            this.chkUnlimitedMileage.AutoSize = true;
            this.chkUnlimitedMileage.Location = new System.Drawing.Point(20, 25);
            this.chkUnlimitedMileage.Name = "chkUnlimitedMileage";
            this.chkUnlimitedMileage.Size = new System.Drawing.Size(310, 26);
            this.chkUnlimitedMileage.TabIndex = 12;
            this.chkUnlimitedMileage.Text = "Unlimited Mileage (+£10 per day)";
            this.chkUnlimitedMileage.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalculate.Location = new System.Drawing.Point(200, 721);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(260, 35);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate And Save Booking";
            this.btnCalculate.UseVisualStyleBackColor = false;
            // 
            // btnViewBookings
            // 
            this.btnViewBookings.Location = new System.Drawing.Point(480, 721);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Size = new System.Drawing.Size(150, 35);
            this.btnViewBookings.TabIndex = 15;
            this.btnViewBookings.Text = "View All Bookings";
            this.btnViewBookings.UseVisualStyleBackColor = true;
            this.btnViewBookings.Click += new System.EventHandler(this.btnViewBookings_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.pictureBox1.Location = new System.Drawing.Point(161, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 102);
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-12, -36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(184, 132);
            this.pictureBox3.TabIndex = 109;
            this.pictureBox3.TabStop = false;
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblheading.Location = new System.Drawing.Point(295, 36);
            this.lblheading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(341, 38);
            this.lblheading.TabIndex = 116;
            this.lblheading.Text = "---Booking  Details---";
            // 
            // lblValidLicense
            // 
            this.lblValidLicense.Location = new System.Drawing.Point(138, 313);
            this.lblValidLicense.Name = "lblValidLicense";
            this.lblValidLicense.Size = new System.Drawing.Size(180, 25);
            this.lblValidLicense.TabIndex = 9;
            this.lblValidLicense.Text = "Valid Driving License:";
            this.lblValidLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // booking_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(829, 791);
            this.Controls.Add(this.lblheading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnViewBookings);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpExtras);
            this.Controls.Add(this.grpFuelType);
            this.Controls.Add(this.lblFuelType);
            this.Controls.Add(this.cmbCarType);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.cmbDays);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.txtLicenseNumber);
            this.Controls.Add(this.lblLicenseNumber);
            this.Controls.Add(this.chkValidLicense);
            this.Controls.Add(this.lblValidLicense);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "booking_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rental Booking System";
            this.Load += new System.EventHandler(this.booking_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.grpFuelType.ResumeLayout(false);
            this.grpFuelType.PerformLayout();
            this.grpExtras.ResumeLayout(false);
            this.grpExtras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.CheckBox chkValidLicense;
        private System.Windows.Forms.Label lblLicenseNumber;
        private System.Windows.Forms.TextBox txtLicenseNumber;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.ComboBox cmbCarType;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.GroupBox grpFuelType;
        private System.Windows.Forms.RadioButton rbElectric;
        private System.Windows.Forms.RadioButton rbHybrid;
        private System.Windows.Forms.RadioButton rbDiesel;
        private System.Windows.Forms.RadioButton rbPetrol;
        private System.Windows.Forms.GroupBox grpExtras;
        private System.Windows.Forms.CheckBox chkBreakdownCover;
        private System.Windows.Forms.CheckBox chkUnlimitedMileage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnViewBookings;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Label lblValidLicense;
    }
}