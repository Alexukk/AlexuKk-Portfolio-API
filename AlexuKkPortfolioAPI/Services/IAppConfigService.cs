using AlexuKkPortfolioAPI.DTOs.AppConfigDTOs;
using AlexuKkPortfolioAPI.Data;

namespace AlexuKkPortfolioAPI.Services
{
    public interface IAppConfigService
    {
        Task<GetGitHubDTO> GetGitHubDetails();
        Task<PatchGitHubDTO> PatchGitHubDetails(PatchGitHubDTO dto);
        Task<GetFlashDetailsDTO> GetFlashDetails();
        Task<PatchFlashDetailsDTO> PatchFlashDetails(PatchFlashDetailsDTO dto);
        Task<GetCurrentProjDetailsDTO> GetCurrentProjDetails();
        Task<PatchCurrentProjDetailsDTO> PatchCurrentProjDetails(PatchCurrentProjDetailsDTO dto);
        Task<GetContactInfoDto> GetContactInfo();
        Task<PatchContactInfoDTO> PatchContactInfo(PatchContactInfoDTO dto);
        Task<GetDonationInfoDTO> GetDonationInfo();
        Task<PatchDonationInfoDTO> PatchDonationinfo(PatchDonationInfoDTO dto);
    }
}
