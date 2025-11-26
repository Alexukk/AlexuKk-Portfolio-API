using AlexuKkPortfolioAPI.Data;
using AlexuKkPortfolioAPI.DTOs;
using AlexuKkPortfolioAPI.Enities;
using AlexuKkPortfolioAPI.Mapping;
using Microsoft.EntityFrameworkCore;

namespace AlexuKkPortfolioAPI.Services
{
    public class PostService(AppDBContext context) : IPostService
    {
        public async Task<GetPostDTO?> CreatePostAsync(CreatePostDTO dto)
        {
            if (dto is null)
            {
                return null;
            }
            var post = dto.ToEntity();
            await context.Posts.AddAsync(post);
            await context.SaveChangesAsync();
            return post.ToGetPostDTO();

        }

        public async Task<bool> DeletePostAsync(int id)
        {
            var post = await context.Posts.Where(p => p.Id == id).FirstOrDefaultAsync();
            if (post is null)
            {
                return true;
            }
            context.Posts.Remove(post);
            await context.SaveChangesAsync();
            return true;
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

        public async Task<GetPostDTO?> UpdatePostAsync(int id, UpdatePostDTO dto)
        {
            var post = await context.Posts.Where(p => p.Id == id).FirstOrDefaultAsync();
            if (post is null)
            {
                return null;
            }

            post.Title = dto.Title;
            post.Content = dto.Content;
            post.Status = dto.Status;
            post.UpdatedAt = DateTime.UtcNow;
            await context.SaveChangesAsync();
            return post.ToGetPostDTO();
        }

        public async Task<GetPostDTO?> UpdateStatusAsync(int id, UpdateStatusDTO status)
        {
            var post = await context.Posts.Where(p => p.Id == id).FirstOrDefaultAsync();
            if (post is null)
            {
                return null;
            }

            post.Status = status.Status;
            post.UpdatedAt = DateTime.UtcNow;
            await context.SaveChangesAsync();
            return post.ToGetPostDTO();

        }
    }
}
