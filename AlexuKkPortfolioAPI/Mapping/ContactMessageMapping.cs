namespace AlexuKkPortfolioAPI.Mapping
{
    public static class ContactMessageMapping
    {
        public static DTOs.GetContactMessageDTO ToGetContactMessageDTO(this Entities.ContactMessage entity)
        {
            return new DTOs.GetContactMessageDTO
            {
                Id = entity.Id,
                FullName = entity.FullName,
                Content = entity.Content,
                Subject = entity.Subject,
                WayToContact = entity.WayToContact,
                PhoneNumber = entity.PhoneNumber,
                Email = entity.Email,
                TelegramUsername = entity.TelegramUsername,
                CreatedAt = entity.CreatedAt,
                IsRead =  entity.IsRead
            };
        }
    }
}
