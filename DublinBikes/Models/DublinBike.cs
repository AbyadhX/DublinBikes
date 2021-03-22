using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DublinBikes.Models
{
    public class DublinBike
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(80, MinimumLength = 3)]
        public string Address { get; set; }

        [Required]
        [Range(-90f, 90f)]
        public double Latitude { get; set; }
        [Required]
        [Range(-90f, 90f)]
        public double Longitude { get; set; }

        [Required]
        public bool Banking {get; set;}

        [Required]
        [Range(1, 200)]
        public int Available_bikes { get; set; }
        [Required]
        [Range(1, 200)]
        public int Available_stands { get; set; }

        [Required]
        [Range(1, 200)]
        public int Capacity { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(10)]
        public string Status { get; set; }
    }
}