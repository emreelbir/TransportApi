using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportApi.Dtos
{
    public class FlightDto
    {
        public Guid Id { get; init; }
        public string color { get; init; }
        public string brand { get; init; }
        public int power { get; init; }
        public string motorType { get; init; }
        public string aspectRatio { get; init; }
        public int capacity { get; init; }
    }
}
