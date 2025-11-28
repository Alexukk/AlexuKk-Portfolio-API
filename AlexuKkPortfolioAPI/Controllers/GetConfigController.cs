using AlexuKkPortfolioAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AlexuKkPortfolioAPI.DTOs;
using AlexuKkPortfolioAPI.DTOs.AppConfigDTOs;


namespace AlexuKkPortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetConfigController(IAppConfigService AppConfigService) : ControllerBase
    {

        [HttpGet("/GitHub")]
        public async Task<GetGitHubDTO> GetGitHubInfo()
        {
            var info = await AppConfigService.GetGitHubDetails();
            return info;
        }

        [HttpGet("/ContactInfo")]

        public async Task<GetContactInfoDto> GetContactsInfo()
        {
            var info = await AppConfigService.GetContactInfo();
            return info;
        }

        [HttpGet("/DonationsInfo")]

        public async Task<GetDonationInfoDTO> GetDonationsInfo()
        {
            var info = await AppConfigService.GetDonationInfo();
            return info;
        }

        [HttpGet("/FlashMessage")]
        public async Task<ToGetFlashDetailsDTO> GetFlashInfo()
        {
            var info = await AppConfigService.GetFlashDetails();
            return info;
        }

        [HttpGet("/CurrentProject")]
        public async Task<GetCurrentProjDetailsDTO> GetCurrentProjDetails()
        {
            var info = await AppConfigService.GetCurrentProjDetails();
            return info;
        }
    }
}
