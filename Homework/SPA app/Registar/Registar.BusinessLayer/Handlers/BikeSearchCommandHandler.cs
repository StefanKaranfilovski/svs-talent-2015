using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BusinessLayer.Contracts;
using Registar.DataLayer;
using Registar.DomainModel;

namespace Registar.BusinessLayer.Handlers
{
    public class BikeSearchCommandHandler : CommandHandlerBase<BikeSearchCommand,BikeSearchResult>
    {
        private IBikeSearchDataSource _dataSource;

        public BikeSearchCommandHandler(IBikeSearchDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        protected override BikeSearchResult ExecuteCommand(BikeSearchCommand command)
        {
            return _dataSource.ExecuteCommand(command);
        }
    }
}
