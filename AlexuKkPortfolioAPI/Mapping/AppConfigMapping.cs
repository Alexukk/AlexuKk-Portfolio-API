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

        public static GetCurrentProjDetailsDTO ToGetCurrentProjDTO(this AppConfigEnt ent)
        {
            return new GetCurrentProjDetailsDTO
            {
                ProjTitle = ent.ProjTitle,
                ProjContent = ent.ProjContent,
                ProjURL = ent.ProjURL

            };
        }
        public static GetDonationInfoDTO ToGetDonationsDTO(this AppConfigEnt ent) 
        {
            return new GetDonationInfoDTO
            {
                DonationURL = ent.DonationURL
            };
        }

        public static ToGetFlashDetailsDTO GetFlashDetailsDTO(this AppConfigEnt ent) 
        {
            return new ToGetFlashDetailsDTO
            {
                FlashTitle = ent.FlashTitle,
                FlashContent = ent.FlashContent
            };
        }

        public static GetGitHubDTO ToGetGitHubDTO(this AppConfigEnt ent)
        {
            return new GetGitHubDTO
            {
                GitHubUseraname = ent.GitHubUseraname,
                GitHubURL = ent.GitHubURL,
            };
        }

    }
}
