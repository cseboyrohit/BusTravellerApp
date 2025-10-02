using System.ComponentModel.DataAnnotations;

namespace BusTravellerApp.Models
{
    public class Destination
    {
        public int Id { get; set; }   // Primary Key

        [Required]
        [StringLength(100)]
        public string Name { get; set; }   // StoreName

        [Required]
        [StringLength(100)]
        public string Location { get; set; }  //  store location

        [Url]
        public string ImagePath { get; set; }  // use for store "/img/card.jpg"

        [Range(0, 5)]
        public double Rating { get; set; }
    }
}
