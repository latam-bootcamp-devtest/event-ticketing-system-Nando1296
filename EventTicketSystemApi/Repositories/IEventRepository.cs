using EventTicketSystemApi.Models;

namespace EventTicketSystemApi.Repositories

{
    public interface IEventRepository
    {
        Task<object> GetAllAsync(int page, int pagesSize);
        Task<Event> CreateEventAsync(Event @event);
        Task<Event?> GetByIdAsync(int id);
    }
}
