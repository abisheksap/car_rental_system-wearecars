using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
// Name: Abishek Sapkota Sharma
// Student ID: bj19le
namespace last_try
{
    public partial class ViewBookedCars : Form
    {
        private List<Booking> allBookings;

        public ViewBookedCars(List<Booking> bookingList)
        {
            InitializeComponent();
            this.allBookings = bookingList ?? new List<Booking>();

            SetupDataGridView();
            LoadData();
        }
        private void ViewBookedCars_Load(object sender, EventArgs e)
        {
        }
        private void SetupDataGridView()
        {
            dgvBookings.Columns.Clear();

            // Create columns for history view
            dgvBookings.Columns.Add("CreatedDate", "📅 Created");
            dgvBookings.Columns.Add("CustomerName", "👤 Customer");
            dgvBookings.Columns.Add("CarType", "🚗 Car");
            
            dgvBookings.Columns.Add("FuelType", "⛽ Fuel");
            dgvBookings.Columns.Add("License", "📋 License");
            dgvBookings.Columns.Add("Days", "📊 Days");
            dgvBookings.Columns.Add("TotalPrice", "💰 Total (£)");
            dgvBookings.Columns.Add("Status", "⚡ Status");
            dgvBookings.Columns.Add("ReturnedDate", "📅 Returned");

            // Formatting
            dgvBookings.Columns["TotalPrice"].DefaultCellStyle.Format = "F2";
            dgvBookings.Columns["CreatedDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvBookings.Columns["ReturnedDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Styling
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.ReadOnly = true;
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadData()
        {
            dgvBookings.Rows.Clear();

            if (allBookings == null || allBookings.Count == 0)
            {
                dgvBookings.Rows.Add("No booking history found", "", "", "", "", "", "", "", "", "", "");
                return;
            }

            foreach (var booking in allBookings)
            {
                // Format dates properly (same as before)
                object createdDateValue = (booking.CreatedDate == DateTime.MinValue) ?
                                          (object)"N/A" : booking.CreatedDate;

                object pickupDateValue = (booking.PickupDate == DateTime.MinValue) ?
                                         (object)"N/A" : booking.PickupDate;

                object returnDateValue = (booking.ReturnDate == DateTime.MinValue) ?
                                         (object)"N/A" : booking.ReturnDate;

                object returnedDateValue;
                if (booking.Status == "Returned" && booking.ReturnedDate != DateTime.MinValue)
                {
                    returnedDateValue = booking.ReturnedDate;
                }
                else if (booking.Status == "Returned")
                {
                    returnedDateValue = "Returned";
                }
                else
                {
                    returnedDateValue = "-";
                }

                int rowIndex = dgvBookings.Rows.Add(
                    createdDateValue, 
                    $"{booking.FirstName} {booking.Surname}",
                    booking.CarType,
                    booking.FuelType, 
                    booking.LicenseNumber,
                   
                    booking.NumberOfDays,
                    booking.TotalPrice,
                    booking.Status,
                    returnedDateValue   
                );

                
                DataGridViewRow row = dgvBookings.Rows[rowIndex];

                
                if (booking.FuelType == "Petrol")
                    row.Cells["FuelType"].Style.ForeColor = Color.OrangeRed;
                else if (booking.FuelType == "Diesel")
                    row.Cells["FuelType"].Style.ForeColor = Color.DarkBlue;
                else if (booking.FuelType == "Electric")
                    row.Cells["FuelType"].Style.ForeColor = Color.Green;
                else if (booking.FuelType == "Hybrid")
                    row.Cells["FuelType"].Style.ForeColor = Color.Purple;

                // Color for Status (same as before)
                if (booking.Status == "Active")
                {
                    row.Cells["Status"].Style.ForeColor = Color.Green;
                    row.Cells["Status"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    row.DefaultCellStyle.BackColor = Color.FromArgb(230, 255, 230);
                }
                else if (booking.Status == "Returned")
                {
                    row.Cells["Status"].Style.ForeColor = Color.Blue;
                    row.Cells["Status"].Style.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                    row.DefaultCellStyle.BackColor = Color.FromArgb(230, 240, 255);
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Reload from data storage
            allBookings = BookingData.GetAllBookings();
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      

     
        private void dgvBookings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBookings.Rows[e.RowIndex];
                string details = $"BOOKING DETAILS\n\n" +
                               $"Customer: {row.Cells["CustomerName"].Value}\n" +
                               $"Car: {row.Cells["CarType"].Value}\n" +
                               $"License: {row.Cells["License"].Value}\n" +
                               $"Created: {row.Cells["CreatedDate"].Value}\n" +
                           
                               $"Days: {row.Cells["Days"].Value}\n" +
                               $"Total: {row.Cells["TotalPrice"].Value}\n" +
                               $"Status: {row.Cells["Status"].Value}\n" +
                               $"Returned: {row.Cells["ReturnedDate"].Value}";

                MessageBox.Show(details, "Booking Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

       

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
            private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvBookings.SelectedRows[0];

            // Check if it's the "no data" row
            if (selectedRow.Cells[0].Value?.ToString() == "No booking history found")
            {
                MessageBox.Show("Cannot delete placeholder row.", "Invalid Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string license = selectedRow.Cells["License"].Value?.ToString();
            string customerName = selectedRow.Cells["CustomerName"].Value?.ToString();

            if (string.IsNullOrEmpty(license))
                return;

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the booking for:\n\n" +
                $"Customer: {customerName}\n" +
                $"License: {license}\n\n" +
                $"This action cannot be undone!",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Delete from data storage
                    BookingData.DeleteBooking(license);

                    // Remove from grid
                    dgvBookings.Rows.Remove(selectedRow);

                    // Show success message
                    MessageBox.Show("Booking deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh count if you have a status label
                    // lblStatus.Text = $"Total Bookings: {allBookings.Count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting booking: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
    
}