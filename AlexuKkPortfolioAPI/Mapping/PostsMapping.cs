using AlexuKkPortfolioAPI.DTOs;
using AlexuKkPortfolioAPI.Enities;

namespace AlexuKkPortfolioAPI.Mapping
{
    public static class PostsMapping
    {
        public static GetPostDTO ToGetPostDTO(this Post post)
        {
            return new GetPostDTO
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                Status = post.Status,
                CreatedAt = post.CreatedAt,
                UpdatedAt = post.UpdatedAt
            };
        }
    }
}
