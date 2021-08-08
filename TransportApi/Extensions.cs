using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportApi.Dtos;
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
        public static TruckDto truckDto(this Truck truck)
        {
            return new TruckDto
            {
                Id = truck.Id,
                brand = truck.brand,
                color = truck.color,
                gearType = truck.gearType,
                wheel = truck.wheel,
                truckBed = truck.truckBed,
                capacity = truck.capacity
            };
        }
        public static FlightDto FlightDto(this Flight flight)
        {
            return new FlightDto
            {
                Id = flight.Id,
                brand = flight.brand,
                color = flight.color,
                power = flight.power,
                aspectRatio = flight.aspectRatio,
                capacity = flight.capacity,
               motorType = flight.motorType,
            };
        }
    }
}
