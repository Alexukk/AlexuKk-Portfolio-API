using AlexuKkPortfolioAPI.DTOs;
using AlexuKkPortfolioAPI.Entities;

namespace AlexuKkPortfolioAPI.Mapping
{
    public static class ContactMessageMapping
    {
        public static GetContactMessageDTO ToGetContactMessageDTO(this ContactMessage entity)
        {
            return new GetContactMessageDTO
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


        public static ContactMessage ToEntity(this CreateContactMessageDTO dto)
        {
            return new ContactMessage
            {
                FullName = dto.FullName,
                Content = dto.Content,
                Subject = dto.Subject,
                WayToContact = dto.WayToContact,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
                TelegramUsername = dto.TelegramUsername,
                CreatedAt = DateTime.UtcNow,
                IsRead = false

            };
        }
    }

}
