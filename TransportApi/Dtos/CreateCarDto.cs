using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportApi.Dtos
{
    public class CreateCarDto
    {
        [Required]
        public string color { get; init; }
        [Required]
        public string brand { get; init; }
        [Required]
        public string gearType { get; init; }
        [Required]
        [Range(100, 300)]
        public decimal power { get; init; }
        [Required]
        [Range(2,5)]
        public int capcaity { get; init; }
    }
}
