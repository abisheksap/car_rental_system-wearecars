using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
// Name: Abishek Sapkota Sharma
// Student ID: bj19le
namespace last_try
{
    public static class BookingData
    {
        // FILE PATH - Change this if needed
        private static string dataFilePath = "bookings.dat";
        private static List<Booking> allBookings = new List<Booking>();

       
        public static int GetTotalBookings
        {
            get { return allBookings.Count; }
        }
        // In your BookingData class, add this method:
        public static void DeleteBooking(string licenseNumber)
        {
            try
            {
                Console.WriteLine($"=== Deleting booking for: {licenseNumber} ===");

                // First load the current bookings
                LoadBookings();

                // Find and remove the booking
                var bookingToRemove = allBookings.FirstOrDefault(b =>
                    b.LicenseNumber != null &&
                    b.LicenseNumber.Equals(licenseNumber, StringComparison.OrdinalIgnoreCase));

                if (bookingToRemove != null)
                {
                    allBookings.Remove(bookingToRemove);
                    SaveBookings();
                    Console.WriteLine($"Booking with license {licenseNumber} deleted successfully.");
                }
                else
                {
                    Console.WriteLine($"Booking not found for license: {licenseNumber}");
                    throw new ArgumentException($"Booking with license number '{licenseNumber}' not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting booking: {ex.Message}");
                throw;
            }
        }
        public static void Initialize()
        {
            try
            {
                Console.WriteLine($"Looking for data file at: {GetFullPath()}");

                if (File.Exists(dataFilePath))
                {
                    Console.WriteLine("Data file found. Loading...");
                    LoadBookings();
                }
                else
                {
                    Console.WriteLine("No data file found. Creating new file...");
                    // Create empty file
                    File.WriteAllText(dataFilePath, "");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Initialize error: {ex.Message}");
            }
        }

        // Helper method to get full path
        private static string GetFullPath()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), dataFilePath);
        }

        public static List<Booking> LoadBookings()
        {
            allBookings.Clear();

            Console.WriteLine($"Trying to load from: {GetFullPath()}");

            if (!File.Exists(dataFilePath))
            {
                Console.WriteLine("File does not exist.");
                return allBookings;
            }

            try
            {
                string[] lines = File.ReadAllLines(dataFilePath);
                Console.WriteLine($"Found {lines.Length} lines in file");

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split('|');

                    // Check if we have enough parts
                    if (parts.Length >= 7) // At least 7 required fields
                    {
                        Booking booking = new Booking
                        {
                            FirstName = parts[0],
                            Surname = parts[1],
                            CarType = parts[2],
                            LicenseNumber = parts[3],
                            NumberOfDays = int.Parse(parts[4]),
                            TotalPrice = decimal.Parse(parts[5]),
                            Status = parts[6]
                        };

                        

                        // Load dates
                        if (parts.Length > 7 && !string.IsNullOrEmpty(parts[7]) && DateTime.TryParse(parts[7], out DateTime pickupDate))
                            booking.PickupDate = pickupDate;
                        else
                            booking.PickupDate = DateTime.Now;


                        if (parts.Length > 8 && !string.IsNullOrEmpty(parts[8]) && DateTime.TryParse(parts[8], out DateTime returnDate))
                            booking.ReturnDate = returnDate;
                        else
                            booking.ReturnDate = DateTime.Now.AddDays(booking.NumberOfDays);

                        if (parts.Length > 9 && !string.IsNullOrEmpty(parts[9]) && DateTime.TryParse(parts[9], out DateTime createdDate))
                            booking.CreatedDate = createdDate;
                        else
                            booking.CreatedDate = DateTime.Now;

                        if (parts.Length > 10 && !string.IsNullOrEmpty(parts[10]) && DateTime.TryParse(parts[10], out DateTime returnedDate))
                            booking.ReturnedDate = returnedDate;
                        else
                            booking.ReturnedDate = DateTime.MinValue;
                        // Load FuelType (field 11 if exists)
                        if (parts.Length > 11 && !string.IsNullOrEmpty(parts[11]))
                        {
                            booking.FuelType = parts[11];
                            Console.WriteLine($"Loaded FuelType: {booking.FuelType} for {booking.LicenseNumber}");
                        }
                        else
                        {
                            booking.FuelType = "Petrol"; // Default only if not in data
                            Console.WriteLine($"Set default FuelType: Petrol for {booking.LicenseNumber}");
                        }

                        allBookings.Add(booking);
                        Console.WriteLine($"Loaded: {booking.LicenseNumber} - {booking.Status} - Fuel: {booking.FuelType}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Load error: {ex.Message}");
            }

            return allBookings;
        }

        public static void SaveBookings()
        {
            try
            {
                Console.WriteLine($"Saving to: {GetFullPath()}");
                Console.WriteLine($"Saving {allBookings.Count} bookings");

                using (StreamWriter writer = new StreamWriter(dataFilePath))
                {
                    foreach (Booking booking in allBookings)
                    {
                        // Format dates properly
                        string pickupDateStr = booking.PickupDate != DateTime.MinValue ?
                            booking.PickupDate.ToString("yyyy-MM-dd HH:mm:ss") : "";

                        string returnDateStr = booking.ReturnDate != DateTime.MinValue ?
                            booking.ReturnDate.ToString("yyyy-MM-dd HH:mm:ss") : "";

                        string createdDateStr = booking.CreatedDate != DateTime.MinValue ?
                            booking.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss") : "";

                        string returnedDateStr = booking.ReturnedDate != DateTime.MinValue ?
                            booking.ReturnedDate.ToString("yyyy-MM-dd HH:mm:ss") : "";

                        // Save ALL 12 fields (including FuelType at the end)
                        string line = $"{booking.FirstName}|{booking.Surname}|" +
                                     $"{booking.CarType}|{booking.LicenseNumber}|{booking.NumberOfDays}|" +
                                     $"{booking.TotalPrice}|{booking.Status}|{pickupDateStr}|" +
                                     $"{returnDateStr}|{createdDateStr}|{returnedDateStr}|" +
                                     $"{booking.FuelType}";  // Add FuelType at the end

                        writer.WriteLine(line);
                        Console.WriteLine($"Saved: {booking.LicenseNumber} - {booking.Status} - Fuel: {booking.FuelType}");
                    }
                }

                Console.WriteLine("Save complete!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Save error: {ex.Message}");
            }
        }
        public static void MarkAsReturned(string licenseNumber)
        {
            try
            {
                Console.WriteLine($"=== MarkAsReturned for: {licenseNumber} ===");

                // Load current data
                LoadBookings();

                var booking = allBookings.FirstOrDefault(b => b.LicenseNumber == licenseNumber);
                if (booking != null)
                {
                    Console.WriteLine($"Found booking. Old status: {booking.Status}, FuelType: {booking.FuelType}");

                    // Only update status and ReturnedDate - keep everything else
                    booking.Status = "Returned";
                    booking.ReturnedDate = DateTime.Now;

                    Console.WriteLine($"New status: {booking.Status}, ReturnedDate: {booking.ReturnedDate}, FuelType still: {booking.FuelType}");

                    SaveBookings(); // This will save ALL fields including the preserved FuelType

                    Console.WriteLine("Booking marked as returned and saved.");
                }
                else
                {
                    Console.WriteLine($"Booking not found for license: {licenseNumber}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in MarkAsReturned: {ex.Message}");
            }
        }
        public static List<Booking> GetActiveBookings()
        {
            return allBookings.Where(b => b.Status == "Active").ToList();
        }

        // Get all bookings
        public static List<Booking> GetAllBookings()
        {
            return allBookings.OrderByDescending(b => b.CreatedDate).ToList();
        }

       
        public static void AddBooking(Booking booking)
        {
            // Ensure FuelType has a value
            if (string.IsNullOrEmpty(booking.FuelType))
            {
                booking.FuelType = "Petrol"; // Default
            }

            allBookings.Add(booking);
            SaveBookings(); // This will save with FuelType
            Console.WriteLine($"Added booking with FuelType: {booking.FuelType}");
        }
    }
}