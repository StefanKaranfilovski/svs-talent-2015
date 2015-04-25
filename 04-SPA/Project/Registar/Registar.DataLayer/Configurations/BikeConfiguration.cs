using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Registar.Models;
using System.Data.Entity.ModelConfiguration;

namespace Registar.DataLayer.Configurations
{
    public class BikeConfiguration : EntityTypeConfiguration<Bike>
    {
        public BikeConfiguration()
        {
            this.ToTable("Bikes")
                .HasKey(p => p.BikeId);
        }
    }
}
