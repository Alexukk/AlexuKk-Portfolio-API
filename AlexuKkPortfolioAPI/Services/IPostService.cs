using AlexuKkPortfolioAPI.DTOs;

namespace AlexuKkPortfolioAPI.Services
{
    public interface IPostService
    {
        Task<GetPostDTO> CreatePostAsync(CreatePostDTO dto);
        Task<IEnumerable<GetPostDTO>> GetAllPostsAsync();
        Task<GetPostDTO?> GetPostByIdAsync(int id);
        Task<bool> DeletePostAsync(int id);
        Task<GetPostDTO> UpdatePostAsync(int id, UpdatePostDTO dto);
    }
}
