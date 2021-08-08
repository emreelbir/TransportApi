using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportApi.Entities
{
    public record Truck
    {
        public Guid Id { get; init; }
        public string color { get; init; }
        public string brand { get; init; }
        public string gearType { get; init; }
        public int wheel { get; init; }
        public string truckBed { get; init; }
        public int capacity { get; init; }
    }
}
