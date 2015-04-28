using Registar.DataLayer;
using Registar.DataLayer.Interfaces;
using Registar.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Repository
{
    public class ContextFactory : IContextFactory
    {
        public TContext CreateContext<TContext>() where TContext : IDbContext
        {
            if (typeof(TContext) == typeof(IRegistarDbContext))
            {
                return (TContext)(object)new RegistarDbContext();
            }

            return default(TContext);
        }
    }
}
