using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportApi.Entities;

namespace TransportApi.CarRepository
{
    public interface ICarService
    {
        Car GetCar(Guid Id);

        IEnumerable<Car> GetCars();
        void CreateCar(Car car);

        void DeleteCar(Guid Id);
    }
}
