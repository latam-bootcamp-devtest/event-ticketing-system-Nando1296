using EventTicketSystemApi.Models;

namespace EventTicketSystemApi.DTOs
{
    public class ResponseEventDTO
    {
        public int EventId { get; set; }
        public String Name { get; set; }
        public DateTime Date { get; set; }
        public int AvaibleSeats { get; set; }

        public ResponseEventDTO() { }

        public ResponseEventDTO(Event ev)
        {
            EventId = ev.EventId;
            Name = ev.Name;
            Date = ev.Date;
            AvaibleSeats = ev.AvailableSeats;
        }
    }
}
