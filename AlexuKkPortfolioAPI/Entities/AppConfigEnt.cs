namespace AlexuKkPortfolioAPI.Entities
{
    public class AppConfigEnt
    {
        public int Id { get; set; }

        // GitHub content
        public string GitHubURL { get; set; }
        public string GitHubUseraname { get; set; }

        // Flash message
        public string? FlashTitle { get; set; }
        public string? FlashContent { get; set; }

        // Current Project
        public string? ProjTitle { get; set; }
        public string? ProjContent { get; set; }
        public string? ProjURL { get; set; }

        // Contact info
        public string TelegramUsername { get; set; }
        public string Email { get; set; }
        public string LinkedInUrl { get; set; }

        // Donations (Buy me a coffee or smth)
        public string? DonationURL { get; set; }
    }
}
