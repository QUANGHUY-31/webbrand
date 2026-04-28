using assetsbackend;
using Microsoft.AspNetCore.Mvc;
using assetsbackend.Domain.Entity;
using assetsbackend.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace assetsbackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly AppDbContext __context;
        public BookingController(AppDbContext context)
        {
            __context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await __context.Bookings.ToListAsync();
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Booking booking)
        {
            __context.Bookings.Add(booking);
            booking.Id = 0;
            await __context.SaveChangesAsync();
            return Ok(booking);
        }
    }
}
