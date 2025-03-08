using EventTicketSystemApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EventTicketSystemApi.Data
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }
    }
}
