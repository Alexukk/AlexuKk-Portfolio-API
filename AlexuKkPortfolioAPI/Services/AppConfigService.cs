using AlexuKkPortfolioAPI.DTOs.AppConfigDTOs;
using Microsoft.EntityFrameworkCore;

namespace AlexuKkPortfolioAPI.Services
{
    public class AppConfigService(DbContext context) : IAppConfigService
    {
        public Task<GetContactInfoDto> GetContactInfo()
        {
            throw new NotImplementedException();
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
