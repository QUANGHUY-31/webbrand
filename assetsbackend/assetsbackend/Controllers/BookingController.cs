using assetsbackend;
using Microsoft.AspNetCore.Mvc;
using assetsbackend.Models;

namespace assetsbackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        static List<Booking> bookings = new List<Booking>(); // 👈 THÊM DÒNG NÀY

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(bookings);
        }

        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            booking.Id = bookings.Count + 1;
            bookings.Add(booking);
            return Ok(booking);
        }
    }
}
