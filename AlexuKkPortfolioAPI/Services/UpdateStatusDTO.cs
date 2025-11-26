using System.ComponentModel.DataAnnotations;

namespace AlexuKkPortfolioAPI.Services
{
    public class UpdateStatusDTO
    {
        [Required] public string Status { get; set; }
    }
}
