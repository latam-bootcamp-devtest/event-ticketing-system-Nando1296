using EventTicketSystemApi.Models;

namespace EventTicketSystemApi.DTOs
{
    public class EventDTO
    {
        public int EventId { get; set; }
        public String Name { get; set; }
        public DateTime Date { get; set; }
        public int AvailableSeats { get; set; }

        public EventDTO() { }

        public EventDTO( string name, DateTime date, int availableSeats)
        {
            Name = name;
            Date = date;
            AvailableSeats = availableSeats;
        }

        public EventDTO(Event ev){
            EventId = ev.EventId;
            Name = ev.Name;
            Date = ev.Date;
            AvailableSeats = ev.AvailableSeats;
        }
    }
}
