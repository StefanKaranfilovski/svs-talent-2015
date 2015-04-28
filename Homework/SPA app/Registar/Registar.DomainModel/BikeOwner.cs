using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DomainModel
{
    public class BikeOwner
    {
        public int BikeOwnerId { get; set; }

        [Display(Name="First name")]
        public string FirstName { get; set; }

        [Display(Name="Last name")]
        public string LastName { get; set; }
    }
}
