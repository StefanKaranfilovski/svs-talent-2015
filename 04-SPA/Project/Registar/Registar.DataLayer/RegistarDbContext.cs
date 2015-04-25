using Registar.DataLayer.Configurations;
using Registar.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer
{
    public class RegistarDbContext : DbContext
    {
        public DbSet<Bike> Bikes { get; set; }

        public RegistarDbContext()
            : base("Registar_Db")
        {
            Bikes = Set<Bike>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BikeConfiguration());
        }
    }
}
