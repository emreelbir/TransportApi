using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportApi.CarRepository;
using TransportApi.Dtos;
using TransportApi.Entities;

namespace TransportApi.Controllers
{
    [ApiController]
    [Route("Cars")]
    public class CarContoller : ControllerBase
    {
        private readonly ICarService repository;

        public CarContoller(ICarService repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public IEnumerable<CarDto> GetCars()
        {
            var cars = repository.GetCars().Select(i => i.carDto());

            return cars;
        }

        [HttpGet("{id}")]
        public ActionResult<CarDto> GetCar(Guid id)
        {
            var car = repository.GetCar(id).carDto();

            if (car is null)
            {
                return NotFound();
            }

            return car;
        }
        [HttpPost]
        public ActionResult<CarDto> CreateItem(CreateCarDto carDto)
        {
            Car car = new()
            {
                Id = Guid.NewGuid(),
                color = carDto.color,
                brand = carDto.brand,
                gearType = carDto.gearType,
                power = carDto.power,
                capcaity = carDto.capcaity
            };
            repository.CreateCar(car);

            return CreatedAtAction(nameof(GetCar), new { id = car.Id }, car.carDto());
        }

         [HttpDelete("{id}")]
        public ActionResult DeleteCar(Guid id)
        {
            var existingCar = repository.GetCar(id);

            if(existingCar is null)
            {
                return NotFound();
            }

            repository.DeleteCar(id);

            return NoContent();

        }
    }
}
