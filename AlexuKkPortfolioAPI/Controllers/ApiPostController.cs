using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AlexuKkPortfolioAPI.Services;

namespace AlexuKkPortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiPostController(IPostService postService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllPosts()
        {
            var posts = await postService.GetAllPostsAsync();
           
            return Ok(posts);
        }
    }
}
