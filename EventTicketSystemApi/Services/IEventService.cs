using EventTicketSystemApi.DTOs;
using EventTicketSystemApi.Models;

namespace EventTicketSystemApi.Services
{
    public interface IEventService
    {
        Task<IEnumerable<EventDTO>> GetAllAsync();
        Task<EventDTO> CreateEventAsync(EventDTO @eventDto);
        Task<EventDTO> GetEventByIdAsync(int id);
    }
}
