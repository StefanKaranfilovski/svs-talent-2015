using Registar.BusinessLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BL.Contracts.Contracts
{
    public class BikeRegisterResult : CommandResult
    {
        public bool IsSuccess { get; set; }
        public IList<string> ValidationErrors { get; set; }
    }
}
