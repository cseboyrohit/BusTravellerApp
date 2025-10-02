using Microsoft.EntityFrameworkCore;
using BusTravellerApp.Models;

namespace BusTravellerApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
