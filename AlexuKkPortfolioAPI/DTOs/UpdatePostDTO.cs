using System.ComponentModel.DataAnnotations;

namespace AlexuKkPortfolioAPI.DTOs
{
    public class UpdatePostDTO
    {
        [Required] public string Title { get; set; }
        [Required] public string Content { get; set; }
        [Required] public string Status { get; set; }
    }
}
