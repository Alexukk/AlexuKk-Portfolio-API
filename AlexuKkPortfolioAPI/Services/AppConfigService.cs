using AlexuKkPortfolioAPI.DTOs.AppConfigDTOs;
using Microsoft.EntityFrameworkCore;
using AlexuKkPortfolioAPI.Data;
using AlexuKkPortfolioAPI.Mapping;
using AlexuKkPortfolioAPI.Entities;


namespace AlexuKkPortfolioAPI.Services
{
    public class AppConfigService(AppDBContext context) : IAppConfigService
    {
        public async Task<GetContactInfoDto> GetContactInfo()
        {
            var config = await GetEntity();

            return config.ToGetContactsDTO();

        }

        public async Task<GetCurrentProjDetailsDTO> GetCurrentProjDetails()
        {
            var config = await GetEntity();

            return config.ToGetCurrentProjDTO();
            
        }

        public async Task<GetDonationInfoDTO> GetDonationInfo()
        {
            var config = await GetEntity();

            return config.ToGetDonationsDTO();
        }

        public async Task<ToGetFlashDetailsDTO> GetFlashDetails()
        {
            var config = await GetEntity();

            return config.GetFlashDetailsDTO();
        }

        public async Task<GetGitHubDTO> GetGitHubDetails()
        {
            var config = await GetEntity();

            return config.ToGetGitHubDTO();
        }

        public async Task<GetContactInfoDto?> PatchContactInfo(PatchContactInfoDTO dto)
        {
            var config = await GetEntityWithTracking();

            bool isUpdated = false;


            if (dto.Email != null)
            {
                config.Email = dto.Email;
                isUpdated = true;
            }

            if (dto.TelegramUsername != null)
            {
                config.TelegramUsername = dto.TelegramUsername;
                isUpdated = true;
            }

            if (dto.LinkedInUrl != null)
            {
                config.LinkedInUrl = dto.LinkedInUrl;
                isUpdated = true;
            }

            if (!isUpdated)
            {
                return null;
            }
            await context.SaveChangesAsync();

            return config.ToGetContactsDTO();
        }

        public async Task<GetCurrentProjDetailsDTO?> PatchCurrentProjDetails(PatchCurrentProjDetailsDTO dto)
        {
            var config = await GetEntityWithTracking();

            bool isUpdated = false;


            if (dto.ProjContent != null)
            {
                config.ProjContent = dto.ProjContent;
                isUpdated = true;
            }

            if (dto.ProjTitle != null)
            {
                config.ProjTitle= dto.ProjTitle;
                isUpdated = true;
            }

            if (dto.ProjURL != null)
            {
                config.ProjURL = dto.ProjURL;
                isUpdated = true;
            }

            if (!isUpdated)
            {
                return null;
            }
            await context.SaveChangesAsync();

            return config.ToGetCurrentProjDTO();
        }

        public async Task<GetDonationInfoDTO?> PatchDonationinfo(PatchDonationInfoDTO dto)
        {
            var config = await GetEntityWithTracking();

            bool isUpdated = false;


            if (dto.DonationURL != null)
            {
                config.DonationURL = dto.DonationURL;
                isUpdated = true;
            }

            if (!isUpdated)
            {
                return null;
            }
            await context.SaveChangesAsync();

            return config.ToGetDonationsDTO();
        }

        public async Task<ToGetFlashDetailsDTO?> PatchFlashDetails(PatchFlashDetailsDTO dto)
        {
            var config = await GetEntityWithTracking();

            bool isUpdated = false;


            if (dto.FlashContent != null)
            {
                config.FlashContent = dto.FlashContent;
                isUpdated = true;
            }

            if (dto.FlashTitle != null)
            {
                config.FlashTitle = dto.FlashTitle;
                isUpdated = true;
            }

            if (!isUpdated)
            {
                return null;
            }
            await context.SaveChangesAsync();

            return config.GetFlashDetailsDTO();
        }

        public async Task<GetGitHubDTO?> PatchGitHubDetails(PatchGitHubDTO dto)
        {
            var config = await GetEntityWithTracking();

            bool isUpdated = false;


            if (dto.GitHubUseraname != null)
            {
                config.GitHubUseraname= dto.GitHubUseraname;
                isUpdated = true;
            }

            if (dto.GitHubURL != null)
            {
                config.GitHubURL = dto.GitHubURL;
                isUpdated = true;
            }


            if (!isUpdated)
            {
                return null;
            }
            await context.SaveChangesAsync();

            return config.ToGetGitHubDTO();
        }



        private async Task<AppConfigEnt> GetEntity()
        {

            var config = await context.AppConfigurations
                .AsNoTracking()
                .Where(c => c.Id == 1)
                .FirstOrDefaultAsync();


            if (config == null)
            {

                config = AppDBContext.GetConfigSeedData();

                context.AppConfigurations.Add(config);
                await context.SaveChangesAsync();
            }

            return config;

        }

        private async Task<AppConfigEnt> GetEntityWithTracking()
        {

            var config = await context.AppConfigurations
                .Where(c => c.Id == 1)
                .FirstOrDefaultAsync();


            if (config == null)
            {

                config = AppDBContext.GetConfigSeedData();

                context.AppConfigurations.Add(config);
                await context.SaveChangesAsync();
            }

            return config;

        }
    }
    
}
