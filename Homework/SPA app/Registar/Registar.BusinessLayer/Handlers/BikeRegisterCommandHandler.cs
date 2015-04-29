using Registar.BL.Contracts.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Handlers
{
    public class BikeRegisterCommandHandler : CommandHandlerBase<BikeRegisterCommand, BikeRegisterResult>
    {
        protected override BikeRegisterResult ExecuteCommand(BikeRegisterCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
