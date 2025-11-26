using AlexuKkPortfolioAPI.Data;
using AlexuKkPortfolioAPI.DTOs;
using AlexuKkPortfolioAPI.Enities;
using AlexuKkPortfolioAPI.Mapping;
using Microsoft.EntityFrameworkCore;

namespace AlexuKkPortfolioAPI.Services
{
    public class PostService(AppDBContext context) : IPostService
    {
        public Task<GetPostDTO> CreatePostAsync(CreatePostDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePostAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GetPostDTO>> GetAllPostsAsync()
        {
            var posts = await context.Posts.Select(p => p.ToGetPostDTO()).ToListAsync();
            return posts;
        }

        public async Task<GetPostDTO?> GetPostByIdAsync(int id)
        {
            var post = await context.Posts
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync();

            if (post is null)
            {
                return null;
            }
                return post.ToGetPostDTO();
        }
    }
}
