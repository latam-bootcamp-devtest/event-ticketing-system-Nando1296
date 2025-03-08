using EventTicketSystemApi.Data;
using EventTicketSystemApi.Models;
using Microsoft.EntityFrameworkCore;


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

        public async Task<object> GetAllAsync(int page, int pageSize)
        {
            var query = _context.Events
                .Where(e => e.Date >= DateTime.Now)
                .OrderBy(e => e.Date);

            var totalEvents = await query.CountAsync();

            var totalPages = (int)Math.Ceiling(totalEvents / (double)pageSize);

            var events = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new
            {
                CurrentPage = page,
                PageSize = pageSize,
                totalPages = totalPages,
                totalEvents = totalEvents,
                Events = events
            };

        }

        public async Task<Event?> GetByIdAsync(int id) => await _context.Events.FindAsync(id);
    }
}
