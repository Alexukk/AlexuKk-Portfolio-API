using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AlexuKkPortfolioAPI.Services;
using AlexuKkPortfolioAPI.DTOs;

namespace AlexuKkPortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController(IPostService postService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllPosts()
        {
            var posts = await postService.GetAllPostsAsync();
           
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPostById(int id)
        {
            var post = await postService.GetPostByIdAsync(id);
            if (post is null)
            {
                return NotFound();
            }
            return Ok(post);
        }


        [HttpPost]
        public async Task<IActionResult> CreatePost ([FromBody] CreatePostDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdPost = await postService.CreatePostAsync(dto);
            return CreatedAtAction(nameof(GetPostById), new { id = createdPost.Id }, createdPost);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var result = await postService.DeletePostAsync(id);
            if (!result)
            {
                return NotFound("Post with this id doesn't exist");
            }
            return NoContent();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePost(int id, [FromBody] UpdatePostDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var updatedPost = await postService.UpdatePostAsync(id, dto);
            if (updatedPost is null)
            {
                return NotFound($"No such post with id {id}");
            }
            return Ok(updatedPost);
        }


        [HttpPatch("{id}/status")]
        public async Task<IActionResult> UpdateStatus(int id, [FromBody] UpdateStatusDTO status)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var updatedPost = await postService.UpdateStatusAsync(id, status);
            if (updatedPost is null)
            {
                return NotFound($"No such post with id {id}");
            }
            return Ok(updatedPost);
        }
    }
}
