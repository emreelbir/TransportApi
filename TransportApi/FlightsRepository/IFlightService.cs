using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportApi.Dtos;
using TransportApi.Entities;

namespace TransportApi.FlightsRepository
{
    public interface IFlightService
    {
        Flight GetFlight(Guid Id);

        IEnumerable<Flight> GetFlights();

        void DeleteFlight(Guid id);
        void CreateFlight(Flight flight);
    }
}
