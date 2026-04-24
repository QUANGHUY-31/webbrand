using Microsoft.AspNetCore.Mvc;
using assetsbackend.Models;

namespace assetsbackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private static List<Comment> comments = new List<Comment>();

        [HttpPost]
        public IActionResult AddComment([FromBody] Comment comment)
        {
            comments.Add(comment);

            return Ok(new
            {
                message = "Comment added!",
                data = comment
            });
        }

        [HttpGet]
        public IActionResult GetComments()
        {
            return Ok(comments);
        }
    }
}
