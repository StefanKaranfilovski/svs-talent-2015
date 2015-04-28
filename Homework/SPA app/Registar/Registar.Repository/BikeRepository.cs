using NLog;
using Registar.BusinessLayer.Contracts;
using Registar.DataLayer.Interfaces;
using Registar.DomainModel;
using Registar.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Repository
{
    internal class BikeRepository : IBikeRepository
    {
        // NLog instance
        Logger log = LogManager.GetCurrentClassLogger();

        public IList<Bike> SearchBikes(BikeSearchCommand filter)
        {
            log.Info("Reading from the RegistarDbContext...");

            using (var context = ContextManager.CreateContext<IRegistarDbContext>())
            {
                var query = from b in context.Bikes
                            select b;

                if (!string.IsNullOrEmpty(filter.Colour))
                {
                    query = query.Where(x => x.Colour == filter.Colour);
                }
                if (!string.IsNullOrEmpty(filter.Producer))
                {
                    query = query.Where(x => x.Producer == filter.Producer);
                }

                query = query
                        .OrderBy(x => x.BikeId)
                        .Skip(filter.PageIndex * filter.PageSize)
                        .Take(filter.PageSize);

                var result = query.ToList();

                log.Warn("Closing the RegistarDbContext...");

                return result;
            }
        }
    }
}
