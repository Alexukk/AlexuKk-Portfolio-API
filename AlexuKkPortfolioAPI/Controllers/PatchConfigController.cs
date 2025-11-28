using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AlexuKkPortfolioAPI.DTOs;
using AlexuKkPortfolioAPI.Services;
using AlexuKkPortfolioAPI.DTOs.AppConfigDTOs;

namespace AlexuKkPortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatchConfigController(IAppConfigService AppConfigService) : ControllerBase
    {
        [HttpPatch("/GitHub")]
        public async Task<IActionResult> PatchGitHubInfo([FromBody] PatchGitHubDTO dto)
        {
            var result = await AppConfigService.PatchGitHubDetails(dto);
            if (result == null)
            {
                return NoContent();
            }
            return Ok(result);
        }

        [HttpPatch("/ContactInfo")]
        public async Task<IActionResult> PatchContactInfo([FromBody] PatchContactInfoDTO dto)
        {
            var result = await AppConfigService.PatchContactInfo(dto);
            if (result == null)
            {
                return NoContent();
            }
            return Ok(result);
        }

        [HttpPatch("/DonationsInfo")]
        public async Task<IActionResult> PatchDonationsInfo([FromBody] PatchDonationInfoDTO dto)
        {
            var result = await AppConfigService.PatchDonationinfo(dto);
            if (result == null)
            {
                return NoContent();
            }
            return Ok(result);
        }

        [HttpPatch("/FlashMessage")]
        public async Task<IActionResult> PatchFlashInfo([FromBody] PatchFlashDetailsDTO dto)
        {
            var result = await AppConfigService.PatchFlashDetails(dto);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPatch("/CurrentProject")]
        public async Task<IActionResult> PatchCurrentProjInfo([FromBody] PatchCurrentProjDetailsDTO dto)
        {
            var result = await AppConfigService.PatchCurrentProjDetails(dto);
            if (result == null)
            {
                return NoContent();
            }
            return Ok(result);
        }
    }
}
