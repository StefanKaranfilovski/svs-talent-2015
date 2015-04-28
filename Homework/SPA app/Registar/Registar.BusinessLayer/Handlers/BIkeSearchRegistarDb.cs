using Registar.BusinessLayer.Contracts;
using Registar.Common;
using Registar.DataLayer;
using Registar.DomainModel;
using Registar.Repository;
using Registar.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.BusinessLayer.Handlers
{
    public class BikeSearchRegistarDb : IBikeSearchDataSource
    {
        public BikeSearchResult ExecuteCommand(BikeSearchCommand command)
        {
            IBikeRepository bikeRepo = RepositoryManager.CreateRepository<IBikeRepository>();

            BikeSearchResult bikeResult = new BikeSearchResult();
            bikeResult.Result = bikeRepo.SearchBikes(command) as List<Bike>;

            return bikeResult;
        }
    }
}
