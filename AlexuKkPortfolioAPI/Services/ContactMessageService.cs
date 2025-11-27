using AlexuKkPortfolioAPI.DTOs;
using AlexuKkPortfolioAPI.Data;
using AlexuKkPortfolioAPI.Entities;
using AlexuKkPortfolioAPI.Mapping;
using Microsoft.EntityFrameworkCore;

namespace AlexuKkPortfolioAPI.Services
{
    public class ContactMessageService(AppDBContext context) : IContactMessageService
    {
        public Task<GetContactMessageDTO> CreateMessageAsync(CreateContactMessageDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMessageAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GetContactMessageDTO>> GetAllMessagesAsync()
        {
            var messages = await context.ContactMessages
                .AsNoTracking()
                .ToListAsync();

            return messages.Select(m => m.ToGetContactMessageDTO());
        }

        public Task<GetContactMessageDTO?> GetMessageByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GetContactMessageDTO?> ToggleIsReadAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
