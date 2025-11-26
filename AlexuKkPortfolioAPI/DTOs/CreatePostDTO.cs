namespace AlexuKkPortfolioAPI.DTOs
{
    public class CreatePostDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Status { get; set; } = "primary";
    }
}
