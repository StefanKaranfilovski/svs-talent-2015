using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.DomainModel;
using Registar.DataLayer.Interfaces;
using Registar.DataLayer.Configurations;

namespace Registar.DataLayer
{
    public class RegistarDbContext : DbContext, IRegistarDbContext
    {
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<BikeOwner> BikeOwners { get; set; }

        // The connection string uses (localdb)\V11.0
        public RegistarDbContext() : base("RegistarDb")
        {
            this.Bikes = this.Set<Bike>();
            this.BikeOwners = this.Set<BikeOwner>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BikeConfiguration());
            modelBuilder.Configurations.Add(new BikeOwnerConfiguration());
        }
    }
}
