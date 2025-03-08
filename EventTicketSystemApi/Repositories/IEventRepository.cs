using EventTicketSystemApi.Models;

namespace EventTicketSystemApi.Repositories

{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetAllAsync();
        Task<Event> CreateEventAsync(Event @event);
        Task<Event?> GetByIdAsync(int id);
    }
}
