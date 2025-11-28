using AlexuKkPortfolioAPI.DTOs;
using AlexuKkPortfolioAPI.Data;
using AlexuKkPortfolioAPI.DTOs.AppConfigDTOs;
using AlexuKkPortfolioAPI.Entities;

namespace AlexuKkPortfolioAPI.Mapping
{
    public static class AppConfigMapping
    {
        public static GetContactInfoDto ToGetContactsDTO(this AppConfigEnt ent)
        {
            return new GetContactInfoDto
            {
                TelegramUsername = ent.TelegramUsername,
                Email = ent.Email,
                LinkedInUrl = ent.LinkedInUrl,
            };
        }
    }
}
