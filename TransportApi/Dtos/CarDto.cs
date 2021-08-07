using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportApi.Entities
{
    public record CarDto
    {
        public Guid Id { get; init; }
        public string color { get; init; }
        public string brand { get; init; }
        public string gearType { get; init; }
        public decimal power { get; init; }
        public int capcaity { get; init; }

    }
}
