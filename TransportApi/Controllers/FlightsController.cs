using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TransportApi.Dtos;
using TransportApi.Entities;
using TransportApi.FlightsRepository;

namespace TransportApi.Controllers
{
    [Route("api/flights")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService repository;

        public FlightsController(IFlightService repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<FlightDto> GetFlights()
        {
            var flight = repository.GetFlights().Select(i => i.FlightDto());

            return flight;
        }
        [HttpGet("{id}")]
        public ActionResult<FlightDto> GetFlight(Guid id)
        {
            var flight = repository.GetFlight(id).FlightDto();

            if (flight is null)
            {
                return NotFound();
            }

            return flight;
        }

        [HttpPost]
        public ActionResult<FlightDto> CreateFlight(CreateFlightDto flightDto)
        {
            Flight flight = new()
            {
                Id = Guid.NewGuid(),
                color = flightDto.color,
                brand = flightDto.brand,
                aspectRatio = flightDto.aspectRatio,
                power = flightDto.power,
                capacity = flightDto.capacity,
                motorType = flightDto.motorType
            };
            repository.CreateFlight(flight);

            return CreatedAtAction(nameof(GetFlight), new { id = flight.Id }, flight.FlightDto());
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteFlight(Guid id)
        {
            var existingTruck = repository.GetFlight(id);

            if (existingTruck is null)
            {
                return NotFound();
            }

            repository.DeleteFlight(id);

            return NoContent();

        }
    }
}
