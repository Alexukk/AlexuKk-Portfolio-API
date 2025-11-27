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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMessageById(int id)
        {
            var message = await contactMessageService.GetMessageByIdAsync(id);

            if (message == null)
            {
                return NotFound($"No such message with an Id {id}");
            }
            return Ok(message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContactMessage([FromBody] CreateContactMessageDTO message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await contactMessageService.CreateMessageAsync(message);

            return CreatedAtAction(nameof(GetMessageById), new { id = result.Id }, result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactMessage(int id)
        {
            bool result = await contactMessageService.DeleteMessageAsync(id);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> ToggleIsReadAsyn(int id)
        {
            var message = await contactMessageService.ToggleIsReadAsync(id);
            if (message == null)
            {
                return NotFound($"No such message with an Id {id}");
            }
            return Ok(message);
        }
    }
}