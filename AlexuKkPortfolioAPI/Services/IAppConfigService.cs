using AlexuKkPortfolioAPI.DTOs.AppConfigDTOs;
using AlexuKkPortfolioAPI.Data;

namespace AlexuKkPortfolioAPI.Services
{
    public interface IAppConfigService
    {
        Task<GetGitHubDTO> GetGitHubDetails();
        Task<GetGitHubDTO?> PatchGitHubDetails(PatchGitHubDTO dto);
        Task<ToGetFlashDetailsDTO> GetFlashDetails();
        Task<ToGetFlashDetailsDTO?> PatchFlashDetails(PatchFlashDetailsDTO dto);
        Task<GetCurrentProjDetailsDTO> GetCurrentProjDetails();
        Task<GetCurrentProjDetailsDTO?> PatchCurrentProjDetails(PatchCurrentProjDetailsDTO dto);
        Task<GetContactInfoDto> GetContactInfo();
        Task<GetContactInfoDto?> PatchContactInfo(PatchContactInfoDTO dto);
        Task<GetDonationInfoDTO> GetDonationInfo();
        Task<GetDonationInfoDTO?> PatchDonationinfo(PatchDonationInfoDTO dto);
    }
}
