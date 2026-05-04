using System;
using System.Drawing;
using System.Windows.Forms;

// Name: Abishek Sapkota Sharma
// Student ID: bj19le
namespace last_try
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            SetupForm();
        }
        
        private void SetupForm()
        {
    
            // Button Panel
            Panel buttonPanel = new Panel();
            buttonPanel.Location = new Point(150, 120);
            buttonPanel.Size = new Size(300, 200);
            buttonPanel.BackColor = Color.White;
            buttonPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(buttonPanel);
            
            // Rented Cars Button
            Button btnRentedCars = new Button();
            btnRentedCars.Name = "btnRentedCars";
            btnRentedCars.Text = "Rented Cars";
            btnRentedCars.Location = new Point(50, 20);
            btnRentedCars.Size = new Size(200, 40);
            btnRentedCars.Font = new Font("Arial", 11, FontStyle.Bold);
            btnRentedCars.BackColor = Color.LightSkyBlue;
            btnRentedCars.Click += BtnRentedCars_Click;
            buttonPanel.Controls.Add(btnRentedCars);
            
            // View Booked Cars Button
            Button btnViewBookedCars = new Button();
            btnViewBookedCars.Name = "btnViewBookedCars";
            btnViewBookedCars.Text = "View Booked Cars";
            btnViewBookedCars.Location = new Point(50, 80);
            btnViewBookedCars.Size = new Size(200, 40);
            btnViewBookedCars.Font = new Font("Arial", 11, FontStyle.Bold);
            btnViewBookedCars.BackColor = Color.LightGreen;
            btnViewBookedCars.Click += BtnViewBookedCars_Click;
            buttonPanel.Controls.Add(btnViewBookedCars);
            
            // New Booking Button
            Button btnNewBooking = new Button();
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Text = "New Booking";
            btnNewBooking.Location = new Point(50, 140);
            btnNewBooking.Size = new Size(200, 40);
            btnNewBooking.Font = new Font("Arial", 11, FontStyle.Bold);
            btnNewBooking.BackColor = Color.LightYellow;
            btnNewBooking.Click += BtnNewBooking_Click;
            buttonPanel.Controls.Add(btnNewBooking);
            
            // Exit Button
            Button btnExit = new Button();
            btnExit.Name = "btnExit";
            btnExit.Text = "Exit";
            btnExit.Location = new Point(250, 330);
            btnExit.Size = new Size(100, 35);
            btnExit.Font = new Font("Arial", 10, FontStyle.Regular);
            btnExit.BackColor = Color.LightCoral;
            btnExit.Click += BtnExit_Click;
            this.Controls.Add(btnExit);
            
            // Status Label
            
        }
        
        private void UpdateBookingCount()
        {
            Label lblStatus = this.Controls.Find("lblStatus", true)[0] as Label;
            if (lblStatus != null)
            {
                lblStatus.Text = $"Total Bookings: {BookingData.GetTotalBookings}";
            }
        }
        
        // Event Handlers
        private void BtnRentedCars_Click(object sender, EventArgs e)
        {
            try
            {
                var activeBookings = BookingData.GetActiveBookings();
                
                if (activeBookings.Count == 0)
                {
                    MessageBox.Show("No active rentals found.", 
                                  "No Rentals", 
                                  MessageBoxButtons.OK, 
                                  MessageBoxIcon.Information);
                    return;
                }
                
                // Pass List<Booking> to RentedCars form
                RentedCars rentedCarsForm = new RentedCars(activeBookings);
                rentedCarsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BtnViewBookedCars_Click(object sender, EventArgs e)
        {
            try
            {
                if (BookingData.GetAllBookings().Count == 0)
                {
                    MessageBox.Show("No bookings found.", "No Bookings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Pass List<Booking> to ViewBookedCars form
                ViewBookedCars viewBookingsForm = new ViewBookedCars(BookingData.GetAllBookings());

                DialogResult result = viewBookingsForm.ShowDialog();
                
                if (result == DialogResult.Yes)
                {
                    UpdateBookingCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BtnNewBooking_Click(object sender, EventArgs e)
        {
            try
            {
                booking_details bookingForm = new booking_details();
                DialogResult result = bookingForm.ShowDialog();
                
                if (result == DialogResult.OK)
                {
                    UpdateBookingCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                BookingData.SaveBookings();
                Application.Exit();
            }
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }
    }
}