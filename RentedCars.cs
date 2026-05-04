using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
// Name: Abishek Sapkota Sharma
// Student ID: bj19le
namespace last_try
{
    public partial class RentedCars : Form
    {
        private List<Booking> activeBookings;

        public RentedCars(List<Booking> bookingList)
        {
            InitializeComponent();
            this.activeBookings = bookingList ?? new List<Booking>();

            SetupDataGridView();
            LoadData();
        }

        private void SetupDataGridView()
        {
            dgvRentedCars.Columns.Clear();

            // Create columns
            dgvRentedCars.Columns.Add("CustomerName", "👤 Customer Name");
            dgvRentedCars.Columns.Add("CarType", "🚗 Car Type");
            dgvRentedCars.Columns.Add("License", "📋 License");

            dgvRentedCars.Columns.Add("Days", "📊 Days");
            dgvRentedCars.Columns.Add("TotalPrice", "💰 Total (£)");
            dgvRentedCars.Columns.Add("Status", "⚡ Status");

            // Formatting
            dgvRentedCars.Columns["TotalPrice"].DefaultCellStyle.Format = "F2";


            // Styling
            dgvRentedCars.RowHeadersVisible = false;
            dgvRentedCars.ReadOnly = true;
            dgvRentedCars.AllowUserToAddRows = false;
            dgvRentedCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentedCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadData()
        {
            dgvRentedCars.Rows.Clear();

            if (activeBookings == null || activeBookings.Count == 0)
            {
                dgvRentedCars.Rows.Add("No active rentals found", "", "", "", "", "", "", "");
                lblStatus.Text = "Active Rentals: 0";
                return;
            }

            foreach (var booking in activeBookings)
            {
                int rowIndex = dgvRentedCars.Rows.Add(
                    $"{booking.FirstName} {booking.Surname}",
                    booking.CarType,
                    booking.LicenseNumber,

                    booking.NumberOfDays,
                    booking.TotalPrice,
                    booking.Status
                );


                if (booking.Status == "Active")
                {
                    dgvRentedCars.Rows[rowIndex].Cells["Status"].Style.ForeColor = Color.Green;
                    dgvRentedCars.Rows[rowIndex].Cells["Status"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }

            lblStatus.Text = $"Active Rentals: {activeBookings.Count}";
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            if (dgvRentedCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a rental to return.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = dgvRentedCars.SelectedRows[0];
            string license = selectedRow.Cells["License"].Value?.ToString();

            if (string.IsNullOrEmpty(license))
                return;

            // Confirm return
            DialogResult result = MessageBox.Show(
                $"Mark this rental as returned?\nLicense: {license}",
                "Confirm Return",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Update in data storage
                    BookingData.MarkAsReturned(license);

                    // Remove from grid (immediate feedback)
                    dgvRentedCars.Rows.Remove(selectedRow);

                    // Update status label
                    UpdateStatusCount();

                    MessageBox.Show("Car marked as returned!\nIt will now appear in the History tab.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateStatusCount()
        {
            int count = dgvRentedCars.Rows.Count;
            if (count > 0 && dgvRentedCars.Rows[0].Cells[0].Value?.ToString() == "No active rentals found")
                count = 0;

            lblStatus.Text = $"Active Rentals: {count}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Reload from data storage
            activeBookings = BookingData.GetActiveBookings();
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRentedCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

