using System.ComponentModel.DataAnnotations;

namespace AlexuKkPortfolioAPI.DTOs
{
    public class UpdateStatusDTO
    {
        [Required] public string Status { get; set; }
    }
}
