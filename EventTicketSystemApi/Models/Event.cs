namespace EventTicketSystemApi.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int AvailableSeats { get; set; }
    }
}
