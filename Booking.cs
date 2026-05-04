using System;
// Name: Abishek Sapkota Sharma
// Student ID: bj19le
namespace last_try
{
    public class Booking
    {
        // Basic Information
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string CarType { get; set; }
        public string LicenseNumber { get; set; }
        public int NumberOfDays { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = "Active";
        public DateTime PickupDate { get; set; } = DateTime.Now;
        public DateTime ReturnDate { get; set; } = DateTime.Now;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ReturnedDate { get; set; } = DateTime.MinValue;
        
        // NEW properties you're trying to add:
        public string Address { get; set; }  // string
        public int Age { get; set; }  // int
        public string FuelType { get; set; }  // string
        public bool UnlimitedMileage { get; set; }  // bool
        public bool BreakdownCover { get; set; }  // bool

        public string GetSummary()
        {
            return $"{FirstName} {Surname} - {CarType} ({LicenseNumber}) for {NumberOfDays} days - ${TotalPrice} - Status: {Status}";
        }
        // Calculated Properties
        public string CustomerName => $"{FirstName} {Surname}";

        // Default constructor
        public Booking()
        {
            PickupDate = DateTime.Now;
            ReturnDate = DateTime.Now;
            CreatedDate = DateTime.Now;
            Status = "Active";
        }

        // Constructor with main details
        public Booking(string firstName, string surname, string carType,
                      string licenseNumber, int days, decimal price)
        {
            FirstName = firstName;
            Surname = surname;
            CarType = carType;
            LicenseNumber = licenseNumber;
            NumberOfDays = days;
            TotalPrice = price;
            Status = "Active";
            PickupDate = DateTime.Now;
            ReturnDate = DateTime.Now.AddDays(days);
            CreatedDate = DateTime.Now;
            ReturnedDate = DateTime.MinValue;
        }
    }
}