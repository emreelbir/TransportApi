using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportApi.Entities;

namespace TransportApi.CarRepository
{
    public class InMemCarService : ICarService
    {
        private readonly List<Car> cars = new()
        {
            new Car { Id = Guid.NewGuid(), color = "Black", brand = "Ford", gearType = "Automatic", power = 250, capcaity = 5 },
            new Car { Id = Guid.NewGuid(), color = "White", brand = "Acura", gearType = "Manual", power = 180, capcaity = 4 },
            new Car { Id = Guid.NewGuid(), color = "Blue", brand = "Audi", gearType = "Automatic", power = 200, capcaity = 5 }
        };

        public void CreateCar(Car car)
        {
            cars.Add(car);
        }

        public void DeleteCar(Guid Id)
        {
            var index = cars.FindIndex(e => e.Id == Id);
        }

        public Car GetCar(Guid Id)
        {
            return cars.Where(i => i.Id == Id).SingleOrDefault();
        }

        public IEnumerable<Car> GetCars()
        {
            return cars;
        }
    }
}
