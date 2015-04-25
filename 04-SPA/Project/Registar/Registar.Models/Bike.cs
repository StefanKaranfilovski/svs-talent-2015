using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Models
{
    public class Bike
    {
        [Key]
        public int BikeId { get; set; }

        [Required]
        [Display(Name="Register number")]
        public string RegisterNumber { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }
    }
}
