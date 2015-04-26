using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DomainModel
{
    /// <summary>
    /// Domain model object for Bike
    /// </summary>
    public class Bike
    {
        public int BikeId { get; set; }

        [Display(Name="Register number")]
        public string RegNumber { get; set; }

        [Display(Name="Manufacturer")]
        public string Producer { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }

        public object IgnoreMe { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }

        public IEnumerable<BikeHistory> History { get; set; } 
    }

    public class BikeHistory
    {
        public int BikeId { get; set; }

        public DateTime Date { get; set; }
    }
}
