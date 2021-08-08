using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportApi.Entities;

namespace TransportApi.TruckRepository
{
    public interface ITruckService
    {
        Truck GetTruck(Guid Id);

        IEnumerable<Truck> GetTrucks();

        void CreateTruck(Truck truck);

        void DeleteTruck(Guid id);
       
    }
}
