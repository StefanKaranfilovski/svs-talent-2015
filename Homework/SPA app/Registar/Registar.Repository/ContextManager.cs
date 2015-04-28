using Registar.DataLayer.Interfaces;
using Registar.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Repository
{
    public static class ContextManager
    {
        private static IContextFactory contextFactory;

        public static TContext CreateContext<TContext>() where TContext : IDbContext
        {
            TContext result = contextFactory.CreateContext<TContext>();
            return result;
        }

        public static void RegisterContext(IContextFactory factory)
        {
            contextFactory = factory;
        }
    }
}
