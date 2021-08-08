using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportApi.Dtos
{
    public record CreateTruckDto
    {
        [Required]
        public string color { get; init; }
        [Required]
        public string brand { get; init; }
        [Required]
        public string gearType { get; init; }
        [Required]
        public int wheel { get; init; }
        [Required]
        public string truckBed { get; init; }
        [Required]
        public int capacity { get; init; }
    }
}
