using AlexuKkPortfolioAPI.DTOs;
using System.Collections.Generic;

namespace AlexuKkPortfolioAPI.Services
{
    public interface IContactMessageService
    {
        Task<IEnumerable<GetContactMessageDTO>> GetAllMessagesAsync();

        Task<GetContactMessageDTO?> GetMessageByIdAsync(int id);

        Task<bool> DeleteMessageAsync(int id);

        Task<GetContactMessageDTO> CreateMessageAsync(CreateContactMessageDTO dto);
        Task<GetContactMessageDTO?> ToggleIsReadAsync(int id);

    }
}