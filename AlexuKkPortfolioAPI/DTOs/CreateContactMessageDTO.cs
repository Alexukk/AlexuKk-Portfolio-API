using System.ComponentModel.DataAnnotations;

namespace AlexuKkPortfolioAPI.DTOs
{
    public class CreateContactMessageDTO
    {
        [Required] public string FullName { get; set; }
        [Required] public string Content { get; set; }
        [Required] public string Subject { get; set; }
        [Required] public string WayToContact { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? TelegramUsername { get; set; }
    }
}
