﻿using EventTicketSystemApi.DTOs;
using EventTicketSystemApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace EventTicketSystemApi.Controllers
{
    [ApiController]
    [Route("/api/events")]
    public class EventController : Controller
    {
        private readonly IEventService _service;
        public EventController(IEventService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventDTO>>> GetAll()
        {
            var events = await _service.GetEventsAsync();
            return Ok(events);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EventDTO>> GetById(int id)
        {
            var ev = await _service.GetEventByIdAsync(id);
            if (ev == null) return NotFound();

            return Ok(ev);
        }


        [HttpPost]

        public async Task<IActionResult> CreateEvent(EventDTO @eventDto)
        {
            var createdEvent = await _service.CreateEventAsync(@eventDto);
            return CreatedAtAction(nameof(GetById), new { id = createdEvent.EventId }, createdEvent);
        }
    }
}
