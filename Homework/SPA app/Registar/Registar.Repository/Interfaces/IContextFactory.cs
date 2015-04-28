using Registar.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Repository.Interfaces
{
    public interface IContextFactory
    {
        TContext CreateContext<TContext>() where TContext : IDbContext;
    }
}
