using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportApi.Entities;

namespace TransportApi
{
    public static class Extensions
    {
        public static CarDto carDto(this Car car)
        {
            return new CarDto
            {
                Id = car.Id,
                brand = car.brand,
                color = car.color,
                gearType = car.gearType,
                power = car.power,
                capcaity = car.capcaity

            };
        }
    }
}
