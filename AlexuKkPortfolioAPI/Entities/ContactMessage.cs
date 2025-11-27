namespace AlexuKkPortfolioAPI.Entities
{
    public class ContactMessage
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Content { get; set; }
        public string Subject { get; set; }
        public string WayToContact { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? TelegramUsername { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsRead { get; set; } = false;

    }
}
