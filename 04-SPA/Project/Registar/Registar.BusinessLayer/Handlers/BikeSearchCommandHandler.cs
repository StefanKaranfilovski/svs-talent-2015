using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BusinessLayer.Contracts;
using Registar.DataLayer;
using Registar.Models;

namespace Registar.BusinessLayer.Handlers
{
    internal class BikeSearchCommandHandler : CommandHandlerBase<BikeSearchCommand,BikeSearchResult>
    {
        protected override BikeSearchResult ExecuteCommand(BikeSearchCommand command)
        {
            using (RegistarDbContext context = new RegistarDbContext())
            {
                var query = context.Bikes.OrderBy(p => p.RegisterNumber)
                                         .Take(10);

                BikeSearchResult result = new BikeSearchResult();
                result.Result = query.ToList();

                return result;
            }
        }
    }
}
