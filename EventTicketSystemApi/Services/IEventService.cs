using EventTicketSystemApi.DTOs;
using EventTicketSystemApi.Models;

namespace EventTicketSystemApi.Services
{
    public interface IEventService
    {
        Task<object> GetEventsAsync(int page, int pageSize);
        Task<EventDTO> CreateEventAsync(EventDTO @eventDto);
        Task<EventDTO> GetEventByIdAsync(int id);
    }
}
