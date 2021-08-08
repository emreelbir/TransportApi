using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportApi.Dtos
{
    public record CreateFlightDto
    {
        [Required]
        public string color { get; init; }
        [Required]
        public string brand { get; init; }
        [Required]
        public int power { get; init; }
        [Required]
        public string motorType { get; init; }
        [Required]
        public string aspectRatio { get; init; }
        [Required]
        public int capacity { get; init; }
    }
}
