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
    internal class BikeSearchRegistarDb : IBikeSearchDataSource
    {
        public BikeSearchResult ExecuteCommand(BikeSearchCommand command)
        {
            // TODO How to pass search parameters?
            IBikeRepository bikeRepo = RepositoryManager.CreateRepository<IBikeRepository>();
            SearchFilter filter = new SearchFilter();
            filter.PageIndex = command.PageIndex;
            filter.PageSize = command.PageSize;

            BikeSearchResult bikeResult = new BikeSearchResult();
            bikeResult.Result = bikeRepo.SearchBikes(filter) as List<Bike>;

            return bikeResult;


            //using (RegistarDbContext context = new RegistarDbContext())
            //{
            //    //IEnumerable<Bike> bikes = new List<Bike>();
            //    //bikes = context.Bikes
            //    //        .OrderBy(p => p.BikeId)
            //    //        .Take(10);
            //    //.ToList();

            //    var query = from b in context.Bikes
            //                select b;
            //    if (!string.IsNullOrEmpty(command.Colour))
            //    {
            //        query = query.Where(x => x.Colour == command.Colour);
            //    }
            //    if (!string.IsNullOrEmpty(command.Producer))
            //    {
            //        query = query.Where(x => x.Producer == command.Producer);
            //    }

            //    query = query
            //            .OrderBy(x => x.BikeId)
            //            .Skip(command.PageIndex * command.PageSize)
            //            .Take(command.PageSize);

            //    BikeSearchResult result = new BikeSearchResult();
            //    result.Result = query.ToList();
            //    return result;
            //}
        }
    }
}
