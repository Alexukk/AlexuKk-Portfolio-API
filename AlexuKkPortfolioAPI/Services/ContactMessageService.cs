using AlexuKkPortfolioAPI.DTOs;
using AlexuKkPortfolioAPI.Data;
using AlexuKkPortfolioAPI.Entities;
using AlexuKkPortfolioAPI.Mapping;
using Microsoft.EntityFrameworkCore;

namespace AlexuKkPortfolioAPI.Services
{
    public class ContactMessageService(AppDBContext context) : IContactMessageService
    {
        public async Task<GetContactMessageDTO> CreateMessageAsync(CreateContactMessageDTO dto)
        {
            var newContactMessage = dto.ToEntity();

            await context.ContactMessages.AddAsync(newContactMessage);
            await context.SaveChangesAsync();
            return newContactMessage.ToGetContactMessageDTO();
        }

        public async Task<bool> DeleteMessageAsync(int id)
        {
            var messageToDelete = await context.ContactMessages.FindAsync(id);
            if (messageToDelete == null) 
            {
                return true;
            }

            context.ContactMessages.Remove(messageToDelete);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<GetContactMessageDTO>> GetAllMessagesAsync()
        {
            var messages = await context.ContactMessages
                .AsNoTracking()
                .ToListAsync();

            return messages.Select(m => m.ToGetContactMessageDTO());
        }

        public async Task<GetContactMessageDTO?> GetMessageByIdAsync(int id)
        {
            var message = await context.ContactMessages.FindAsync(id);

            if (message == null) 
            {
                return null;
            }

            return message.ToGetContactMessageDTO();
        }

        public Task<GetContactMessageDTO?> ToggleIsReadAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
