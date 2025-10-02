using BusTravellerApp.Data;
using BusTravellerApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusTravellerApp.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Bookings.Add(booking);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(booking);
        }
        public IActionResult Success()
        {
            return View();
        }
    }
}
