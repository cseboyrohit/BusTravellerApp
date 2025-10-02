using System.ComponentModel.DataAnnotations;

namespace BusTravellerApp.Models
{
    public class Booking
    {
        public int Id { get; set; }   // Primary Key
        [Required]
        public string Name { get; set; }   // User Name
        public string Email { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        public DateTime TravelDate { get; set; }
        public string Destination { get; set; }

        [Required, Range(1, 10)]
        public int Passengers { get; set; }
    }
}
