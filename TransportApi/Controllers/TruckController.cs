using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TransportApi.Dtos;
using TransportApi.Entities;
using TransportApi.TruckRepository;

namespace TransportApi.Controllers
{
    [ApiController]
    [Route("api/trucks")]
    public class TruckController : ControllerBase
    {
        private readonly ITruckService repository;

        public TruckController(ITruckService repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<TruckDto> GetTrucks()
        {
            var cars = repository.GetTrucks().Select(i => i.truckDto());

            return cars;
        }

        [HttpGet("{id}")]
        public ActionResult<TruckDto> GetTruck(Guid id)
        {
            var truck = repository.GetTruck(id).truckDto();

            if (truck is null)
            {
                return NotFound();
            }

            return truck;
        }

        [HttpPost]
        public ActionResult<TruckDto> CreateTruck(CreateTruckDto truckDto)
        {
            Truck truck = new()
            {
                Id = Guid.NewGuid(),
                color = truckDto.color,
                brand = truckDto.brand,
                gearType = truckDto.gearType,
                truckBed = truckDto.truckBed,
                capacity = truckDto.capacity,
                wheel = truckDto.wheel
            };
            repository.CreateTruck(truck);

            return CreatedAtAction(nameof(GetTruck), new { id = truck.Id }, truck.truckDto());
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteTruck(Guid id)
        {
            var existingTruck = repository.GetTruck(id);

            if (existingTruck is null)
            {
                return NotFound();
            }

            repository.DeleteTruck(id);

            return NoContent();

        }
    }
}
