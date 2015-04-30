using Registar.BusinessLayer.Contracts;
using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BL.Contracts.Contracts
{
    public class BikeRegisterCommand : Command
    {
        public Bike Bike { get; set; }

        public Bike BikeToRegister { get; set; }
    }
}
