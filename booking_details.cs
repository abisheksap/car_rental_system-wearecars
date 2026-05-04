using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
// Name: Abishek Sapkota Sharma
// Student ID: bj19le
namespace last_try

{
    public partial class booking_details : Form
    {


        public booking_details()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Set form properties
            this.Text = "Car Rental Booking System";
            this.Size = new Size(847, 838);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Setup combo boxes
            SetupComboBoxes();

            // Setup events
            SetupEvents();

            // Set default values
            SetDefaults();
        }

        private string GetSelectedFuelType()
        {
            if (rbPetrol.Checked) return "Petrol";
            else if (rbDiesel.Checked) return "Diesel";
            else if (rbHybrid.Checked) return "Hybrid";
            else if (rbElectric.Checked) return "Full Electric";
            return "Petrol";
        }

        private void SetupComboBoxes()
        {
            // Clear and add items to cmbDays
            cmbDays.Items.Clear();
            for (int i = 1; i <= 28; i++)
            {
                cmbDays.Items.Add(i);
            }
            cmbDays.SelectedIndex = 0;

            // Clear and add items to cmbCarType
            cmbCarType.Items.Clear();
            cmbCarType.Items.AddRange(new string[] { "City car", "Family car", "Sports car", "SUV" });
            cmbCarType.SelectedIndex = 0;
        }

        private void SetupEvents()
        {
            // CheckBox events
            chkValidLicense.CheckedChanged += ChkValidLicense_CheckedChanged;

            // Button events
            btnCalculate.Click += BtnCalculate_Click;
            btnViewBookings.Click += BtnViewBookings_Click;

            // Validation events
            txtFirstName.Validating += TextBox_Validating;
            txtSurname.Validating += TextBox_Validating;
            txtAddress.Validating += TextBox_Validating;
            txtLicenseNumber.Validating += LicenseNumber_Validating;
        }

        private void SetDefaults()
        {
            numAge.Value = 25;
            rbPetrol.Checked = true;
            txtLicenseNumber.Enabled = false;
        }

        // ================= EVENT HANDLERS =================

        private void ChkValidLicense_CheckedChanged(object sender, EventArgs e)
        {
            // Enable/disable license number field based on checkbox
            txtLicenseNumber.Enabled = chkValidLicense.Checked;

            if (!chkValidLicense.Checked)
            {
                txtLicenseNumber.Clear();
                errorProvider1.SetError(txtLicenseNumber, "");
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Clear previous errors
            errorProvider1.Clear();

            // Validate all inputs
            if (!ValidateAllInputs())
                return;

            // Calculate total price
            decimal totalPrice = CalculateTotalPrice();

            // Create Booking object
            Booking booking = new Booking
            {
                FirstName = txtFirstName.Text,
                Surname = txtSurname.Text,
                Address = txtAddress.Text,
                Age = (int)numAge.Value,
                LicenseNumber = txtLicenseNumber.Text,
                NumberOfDays = Convert.ToInt32(cmbDays.SelectedItem.ToString()), // FIXED
                CarType = cmbCarType.SelectedItem.ToString(),
                FuelType = GetSelectedFuelType(),
                UnlimitedMileage = chkUnlimitedMileage.Checked,
                BreakdownCover = chkBreakdownCover.Checked,
                TotalPrice = totalPrice
            };

            // Add to BookingData
            BookingData.AddBooking(booking);

            // Show confirmation
            string summary = CreateBookingSummary(totalPrice);
            MessageBox.Show(summary, "Booking Confirmed",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form for next booking
            ClearForm();

            // Return OK to indicate booking was created
            this.DialogResult = DialogResult.OK;
        }

        private void BtnViewBookings_Click(object sender, EventArgs e)
        {
            // Check if there are any bookings
            if (BookingData.GetAllBookings().Count == 0)
            {
                MessageBox.Show("No bookings found. Please make a booking first.",
                              "No Bookings",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Create a new form to display all bookings
            // PASS BookingData.Bookings (which is List<Booking>) 
            DisplayBookingsForm displayForm = new DisplayBookingsForm(BookingData.GetAllBookings());
            displayForm.ShowDialog();
        }

        private void TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox == null) return;

            // Skip validation if field is disabled
            if (!textBox.Enabled) return;

            // Validate based on which textbox
            if (textBox == txtFirstName || textBox == txtSurname || textBox == txtAddress)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    string fieldName = GetFieldName(textBox);
                    errorProvider1.SetError(textBox, $"{fieldName} is required");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(textBox, "");
                }
            }
        }

        private void LicenseNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (chkValidLicense.Checked && string.IsNullOrWhiteSpace(txtLicenseNumber.Text))
            {
                errorProvider1.SetError(txtLicenseNumber, "License number is required when license is checked");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtLicenseNumber, "");
            }
        }

        // ================= HELPER METHODS =================

        private bool ValidateAllInputs()
        {
            bool isValid = true;

            // Validate First Name
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "First name is required");
                isValid = false;
            }

            // Validate Surname
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                errorProvider1.SetError(txtSurname, "Surname is required");
                isValid = false;
            }

            // Validate Address
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "Address is required");
                isValid = false;
            }

            // Validate Age
            if (numAge.Value < 18)
            {
                errorProvider1.SetError(numAge, "Must be 18 or older to rent a car");
                isValid = false;
            }

            // Validate Driving License
            if (!chkValidLicense.Checked)
            {
                MessageBox.Show("Valid driving license is required to proceed with booking.",
                              "License Required",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkValidLicense.Focus();
                return false;
            }

            // Validate License Number (if license is checked)
            if (chkValidLicense.Checked && string.IsNullOrWhiteSpace(txtLicenseNumber.Text))
            {
                errorProvider1.SetError(txtLicenseNumber, "License number is required");
                isValid = false;
            }

            // Validate Days selection
            if (cmbDays.SelectedItem == null)
            {
                errorProvider1.SetError(cmbDays, "Please select number of days");
                isValid = false;
            }

            // Validate Car Type selection
            if (cmbCarType.SelectedItem == null)
            {
                errorProvider1.SetError(cmbCarType, "Please select car type");
                isValid = false;
            }

            // Validate Fuel Type selection
            if (!rbPetrol.Checked && !rbDiesel.Checked && !rbHybrid.Checked && !rbElectric.Checked)
            {
                errorProvider1.SetError(grpFuelType, "Please select fuel type");
                isValid = false;
            }

            return isValid;
        }

        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            // Get number of days
            int days = Convert.ToInt32(cmbDays.SelectedItem);

            // Base price: £25 per day
            totalPrice = 25 * days;

            // Car type extra charge
            string carType = cmbCarType.SelectedItem.ToString();
            totalPrice += GetCarTypeExtra(carType); // Use the helper method

            // Fuel type extra charge
            if (rbHybrid.Checked)
                totalPrice += 30;
            else if (rbElectric.Checked)
                totalPrice += 50;
            // Petrol and Diesel have no extra charge

            // Optional extras
            if (chkUnlimitedMileage.Checked)
                totalPrice += 10 * days;

            if (chkBreakdownCover.Checked)
                totalPrice += 2 * days;

            return totalPrice;
        }

        private string CreateBookingSummary(decimal totalPrice)
        {
            // Get car type (FIXED: Define carType here)
            string carType = cmbCarType.SelectedItem.ToString();

            // Get fuel type
            string fuelType = GetSelectedFuelType();  // Use the helper method

            // Get extras
            List<string> extras = new List<string>();
            if (chkUnlimitedMileage.Checked) extras.Add("Unlimited Mileage");
            if (chkBreakdownCover.Checked) extras.Add("Breakdown Cover");
            string extrasText = extras.Count > 0 ? string.Join(", ", extras) : "None";

            int days = Convert.ToInt32(cmbDays.SelectedItem);

            return $"=== CAR RENTAL BOOKING CONFIRMED ===\n\n" +
                   $"Customer Details:\n" +
                   $"-----------------\n" +
                   $"Name: {txtFirstName.Text} {txtSurname.Text}\n" +
                   $"Address: {txtAddress.Text}\n" +
                   $"Age: {numAge.Value}\n" +
                   $"License No: {txtLicenseNumber.Text}\n\n" +
                   $"Rental Details:\n" +
                   $"---------------\n" +
                   $"Days: {days}\n" +
                   $"Car Type: {carType}\n" +
                   $"Fuel Type: {fuelType}\n" +
                   $"Extras: {extrasText}\n\n" +
                   $"Price Breakdown:\n" +
                   $"----------------\n" +
                   $"Base ({days} days × £25): £{25 * days:F2}\n" +
                   $"Car Type ({carType}): £{GetCarTypeExtra(carType):F2}\n" +
                   $"Fuel Type ({fuelType}): £{GetFuelTypeExtra(fuelType):F2}\n" +
                   $"Extras: £{CalculateExtrasPrice(days):F2}\n" +
                   $"----------------\n" +
                   $"TOTAL PRICE: £{totalPrice:F2}\n\n" +
                   $"Booking Date: {DateTime.Now:dd/MM/yyyy HH:mm}";
        }
        private decimal GetCarTypeExtra(string carType)
        {
            switch (carType)
            {
                case "City car": return 0;
                case "Family car": return 50;
                case "Sports car": return 75;
                case "SUV": return 65;
                default: return 0;
            }
        }

        private decimal GetFuelTypeExtra(string fuelType)
        {
            switch (fuelType)
            {
                case "Petrol": return 0;
                case "Diesel": return 0;
                case "Hybrid": return 30;
                case "Full Electric": return 50;
                default: return 0;
            }
        }

        private decimal CalculateExtrasPrice(int days)
        {
            decimal extrasPrice = 0;
            if (chkUnlimitedMileage.Checked) extrasPrice += 10 * days;
            if (chkBreakdownCover.Checked) extrasPrice += 2 * days;
            return extrasPrice;
        }

        private void ClearForm()
        {
            // Clear text boxes
            txtFirstName.Clear();
            txtSurname.Clear();
            txtAddress.Clear();
            txtLicenseNumber.Clear();

            // Reset to defaults
            numAge.Value = 25;
            chkValidLicense.Checked = false;
            txtLicenseNumber.Enabled = false;
            cmbDays.SelectedIndex = 0;
            cmbCarType.SelectedIndex = 0;
            rbPetrol.Checked = true;
            chkUnlimitedMileage.Checked = false;
            chkBreakdownCover.Checked = false;

            // Clear errors
            errorProvider1.Clear();

            // Set focus to first field
            txtFirstName.Focus();
        }

        private string GetFieldName(TextBox textBox)
        {
            if (textBox == txtFirstName) return "First name";
            if (textBox == txtSurname) return "Surname";
            if (textBox == txtAddress) return "Address";
            if (textBox == txtLicenseNumber) return "License number";
            return "Field";
        }

        private void cmbCarType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void booking_details_Load(object sender, EventArgs e)
        {

        }

        private void btnViewBookings_Click_1(object sender, EventArgs e)
        {

        }


    }
}
