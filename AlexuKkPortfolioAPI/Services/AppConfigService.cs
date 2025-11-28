using AlexuKkPortfolioAPI.DTOs.AppConfigDTOs;
using Microsoft.EntityFrameworkCore;
using AlexuKkPortfolioAPI.Data;
using AlexuKkPortfolioAPI.Mapping;


namespace AlexuKkPortfolioAPI.Services
{
    public class AppConfigService(AppDBContext context) : IAppConfigService
    {
        public async Task<GetContactInfoDto> GetContactInfo()
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

            return config.ToGetContactsDTO();

        }

        public Task<GetCurrentProjDetails> GetCurrentProjDetails()
        {
            throw new NotImplementedException();
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
    }
}
