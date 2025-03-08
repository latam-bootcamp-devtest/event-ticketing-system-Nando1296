using EventTicketSystemApi.DTOs;
using EventTicketSystemApi.Models;
using EventTicketSystemApi.Repositories;

namespace EventTicketSystemApi.Services
{
    public class EventService: IEventService
    {
        private readonly IEventRepository _repository;

        public EventService(IEventRepository repository)
        {
            _repository = repository;
        }

        public async Task<EventDTO> CreateEventAsync(EventDTO @eventDto)
        {
            if (@eventDto.Date < DateTime.UtcNow || @eventDto.AvailableSeats < 0)
                throw new BadHttpRequestException("Invalid event data");

            var newEvent = new Event 
            { 
                Name = @eventDto.Name,
                Date = @eventDto.Date,
                AvailableSeats = @eventDto.AvailableSeats
            };

            await _repository.CreateEventAsync(newEvent);

            return new EventDTO(newEvent);
        }

        public async Task<object> GetEventsAsync(int page, int pageSize)
        {
            return await _repository.GetAllAsync(page, pageSize);
        }
        

        public async Task<EventDTO?> GetEventByIdAsync(int id)
        {
            var ev = await _repository.GetByIdAsync(id);
            if (ev == null) return null;

            return new EventDTO(ev);
        }
    }
}
