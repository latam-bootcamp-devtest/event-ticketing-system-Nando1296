using EventTicketSystemApi.Models;

namespace EventTicketSystemApi.Repositories

{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetEventAsync();
        Task<Event> CreateEventAsync(Event @event);
        Task<Event?> GetByIdAsync(int id);
    }
}
