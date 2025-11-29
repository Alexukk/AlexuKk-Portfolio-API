using AlexuKkPortfolioAPI.Entities;
using AlexuKkPortfolioAPI.DTOs;


namespace AlexuKkPortfolioAPI.Services
{
    public interface IAuthService
    {
        Task<string> Login(LoginDTO dto);

        Task<User> Register(LoginDTO dto);
    }
}
