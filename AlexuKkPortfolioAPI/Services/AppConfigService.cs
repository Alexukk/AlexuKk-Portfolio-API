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

        public Task<GetDonationInfoDTO> GetDonationInfo()
        {
            throw new NotImplementedException();
        }

        public Task<GetFlashDetailsDTO> GetFlashDetails()
        {
            throw new NotImplementedException();
        }

        public Task<GetGitHubDTO> GetGitHubDetails()
        {
            throw new NotImplementedException();
        }

        public Task<PatchContactInfoDTO> PatchContactInfo(PatchContactInfoDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<PatchCurrentProjDetailsDTO> PatchCurrentProjDetails(PatchCurrentProjDetailsDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<PatchDonationInfoDTO> PatchDonationinfo(PatchDonationInfoDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<PatchFlashDetailsDTO> PatchFlashDetails(PatchFlashDetailsDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<PatchGitHubDTO> PatchGitHubDetails(PatchGitHubDTO dto)
        {
            throw new NotImplementedException();
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
    }
    
}
