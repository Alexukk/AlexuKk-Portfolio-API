using System.ComponentModel.DataAnnotations;

namespace AlexuKkPortfolioAPI.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Username { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; } = Array.Empty<byte>();

        [Required]
        public byte[] PasswordSalt { get; set; } = Array.Empty<byte>();

        [Required]
        [MaxLength(10)]
        public string Role { get; set; } = "Admin";
    }
}
