using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
// Name: Abishek Sapkota Sharma
// Student ID: bj19le
namespace last_try
{
    public partial class DisplayBookingsForm : Form
    {
        private List<string> bookings;

        public DisplayBookingsForm(List<Booking> bookingList)
        {
            InitializeComponent();
            bookings = ConvertBookingsToStringList(bookingList);


            // Wire up events
            btnClose.Click += btnClose_Click;
            btnPrint.Click += btnPrint_Click;
            btnClearAll.Click += btnClearAll_Click;
            this.Load += DisplayBookingsForm_Load;
            this.Resize += DisplayBookingsForm_Resize;

            LoadBookings();
        }

        // ADD this method in DisplayBookingsForm class:
        private List<string> ConvertBookingsToStringList(List<Booking> bookingList)
        {
            List<string> result = new List<string>();
            foreach (var booking in bookingList)
            {
                result.Add($"{booking.FirstName} {booking.Surname} - {booking.CarType} ({booking.LicenseNumber}) for {booking.NumberOfDays} days - ${booking.TotalPrice} - Status: {booking.Status}");
            }
            return result;
        }

        private void LoadBookings()
        {
            // Clear existing items
            rtbBookings.Clear();

            if (bookings == null || bookings.Count == 0)
            {
                rtbBookings.Text = "No bookings available.";
                lblCount.Text = "Total Bookings: 0";
                btnClearAll.Enabled = false;
                btnPrint.Enabled = false;
                return;
            }

            // Update count label
            lblCount.Text = $"Total Bookings: {bookings.Count}";

            // Set up RichTextBox formatting
            rtbBookings.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            rtbBookings.SelectionColor = Color.DarkBlue;
            rtbBookings.AppendText("CAR RENTAL SYSTEM - ALL BOOKINGS\n");
            rtbBookings.AppendText(new string('=', 80) + "\n\n");

            // Add each booking with formatting
            for (int i = 0; i < bookings.Count; i++)
            {
                // Booking header
                rtbBookings.SelectionFont = new Font("Consolas", 11, FontStyle.Bold);
                rtbBookings.SelectionColor = Color.DarkGreen;
                rtbBookings.AppendText($"BOOKING #{i + 1}\n");
                rtbBookings.AppendText(new string('-', 60) + "\n");

                // Booking details
                rtbBookings.SelectionFont = new Font("Consolas", 10, FontStyle.Regular);
                rtbBookings.SelectionColor = Color.Black;
                rtbBookings.AppendText(bookings[i] + "\n\n");

                // Separator between bookings
                rtbBookings.SelectionFont = new Font("Consolas", 8, FontStyle.Regular);
                rtbBookings.SelectionColor = Color.Gray;
                rtbBookings.AppendText(new string('▬', 80) + "\n\n");
            }

            // Scroll to top
            rtbBookings.SelectionStart = 0;
            rtbBookings.ScrollToCaret();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a print dialog
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();

                printDocument.PrintPage += (s, ev) =>
                {
                    // Create font for printing
                    Font printFont = new Font("Consolas", 10);

                    // Calculate how many lines per page
                    float linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
                    float yPos = ev.MarginBounds.Top;
                    int count = 0;

                    // Get all text lines
                    string[] lines = rtbBookings.Text.Split('\n');

                    // Print each line
                    foreach (string line in lines)
                    {
                        if (count >= linesPerPage)
                        {
                            ev.HasMorePages = true;
                            return;
                        }

                        yPos = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics));
                        ev.Graphics.DrawString(line, printFont, Brushes.Black,
                                              ev.MarginBounds.Left, yPos, new StringFormat());
                        count++;
                    }

                    ev.HasMorePages = false;
                };

                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Print Error: {ex.Message}", "Print Failed",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete ALL bookings?\nThis action cannot be undone.",
                "Confirm Delete All",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bookings.Clear();
                LoadBookings();

                // Notify main form to clear its list too
                this.DialogResult = DialogResult.Yes;
                MessageBox.Show("All bookings have been cleared.",
                              "Bookings Cleared",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DisplayBookingsForm_Load(object sender, EventArgs e)
        {
            // Center buttons at the bottom
            CenterBottomButtons();
        }

        private void CenterBottomButtons()
        {
            int totalWidth = btnClose.Width + btnPrint.Width + btnClearAll.Width + 40;
            int startX = (this.ClientSize.Width - totalWidth) / 2;

            btnClose.Location = new Point(startX, btnClose.Location.Y);
            btnPrint.Location = new Point(startX + btnClose.Width + 20, btnPrint.Location.Y);
            btnClearAll.Location = new Point(startX + btnClose.Width + btnPrint.Width + 40, btnClearAll.Location.Y);
        }

        private void DisplayBookingsForm_Resize(object sender, EventArgs e)
        {
            // Adjust RichTextBox size when form is resized
            rtbBookings.Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 130);

            // Reposition buttons
            CenterBottomButtons();
        }
    }
}

