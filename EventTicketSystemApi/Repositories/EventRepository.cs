using EventTicketSystemApi.Data;
using EventTicketSystemApi.Models;

namespace EventTicketSystemApi.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly TicketDbContext _context;

        public EventRepository(TicketDbContext context)
        {
            _context = context;
        }

        public async Task<Event> CreateEventAsync(Event ev)
        {
            _context.Events.Add(ev);
            await _context.SaveChangesAsync();
            return ev;
        }

        public Task<IEnumerable<Event>> GetEventAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Event?> GetByIdAsync(int id) => await _context.Events.FindAsync(id);
    }
}
