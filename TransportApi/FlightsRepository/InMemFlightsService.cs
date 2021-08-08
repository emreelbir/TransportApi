using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportApi.Entities;

namespace TransportApi.FlightsRepository
{
    public class InMemFlightsService : IFlightService
    {
        private readonly List<Flight> flights = new()
        {
            new Flight { Id = Guid.NewGuid(), aspectRatio = "propelled" ,brand ="Thy",capacity= 20,color="black",motorType="Manual",power= 1000},
            new Flight { Id = Guid.NewGuid(), aspectRatio = "nonpropelled", brand = "Hty", capacity = 10, color = "white", motorType = "Manual", power = 1000 },
            new Flight { Id = Guid.NewGuid(), aspectRatio = "propelled", brand = "Phy", capacity = 30, color = "blue", motorType = "Manual", power = 1000 }
        };
        public void CreateFlight(Flight flight)
        {
            flights.Add(flight);
        }

        public void DeleteFlight(Guid id)
        {
            var index = flights.FindIndex(e => e.Id == id);
        }

        public Flight GetFlight(Guid Id)
        {
            return flights.Where(i => i.Id == Id).SingleOrDefault();
        }

        public IEnumerable<Flight> GetFlights()
        {
            return flights;
        }
    }
}
