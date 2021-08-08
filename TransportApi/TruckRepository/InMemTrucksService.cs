using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportApi.Entities;

namespace TransportApi.TruckRepository
{
    public class InMemTrucksService : ITruckService
    {
        private readonly List<Truck> trucks = new()
        {
            new Truck { Id = Guid.NewGuid(), brand = "Chevrolet",color = "Black" , gearType = "automatic",capacity= 4,truckBed= "lower truck bed",wheel=8 },
            new Truck { Id = Guid.NewGuid(), brand = "Ford", color = "Blue", gearType = "maual", capacity = 4, truckBed = "medium truck bed", wheel = 6 },
            new Truck { Id = Guid.NewGuid(), brand = "Isuzu", color = "White", gearType = "automatic", capacity = 4, truckBed = "lower truck bed", wheel = 4 }
        };

        public void CreateTruck(Truck truck)
        {
            trucks.Add(truck);
        }

        public void DeleteTruck(Guid id)
        {

            var index = trucks.FindIndex(e => e.Id == id);
        }

        public Truck GetTruck(Guid Id)
        {
            return trucks.Where(i => i.Id == Id).SingleOrDefault();
        }

        public IEnumerable<Truck> GetTrucks()
        {
            return trucks;
        }
    }
}
