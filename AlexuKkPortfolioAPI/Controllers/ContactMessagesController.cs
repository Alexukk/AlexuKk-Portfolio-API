using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AlexuKkPortfolioAPI.Services;
using AlexuKkPortfolioAPI.DTOs;


namespace AlexuKkPortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactMessagesController(IContactMessageService contactMessageService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllMessages()
        {
            var messages = await contactMessageService.GetAllMessagesAsync();

            return Ok(messages);
        }
    }
}