using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using assetsbackend.Domain.Entity;
using assetsbackend.Infrastructure;

namespace assetsbackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly AppDbContext __context;
        public CommentController(AppDbContext context)
        {
            __context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddComment([FromBody] Comment comment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            __context.Comments.Add(comment);
            await __context.SaveChangesAsync();

            return Ok(comment);
        }

        [HttpGet]
        public async Task<IActionResult> GetComments()
        {
            var comments = await __context.Comments.ToListAsync();
            return Ok(comments);
        }
    }
}
