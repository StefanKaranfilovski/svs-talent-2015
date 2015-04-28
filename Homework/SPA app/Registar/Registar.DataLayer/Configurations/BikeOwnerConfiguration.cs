using Registar.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer.Configurations
{
    public class BikeOwnerConfiguration 
        : EntityTypeConfiguration<BikeOwner>
    {
        public BikeOwnerConfiguration()
        {
            this.ToTable("BikeOwners", "data")
                .HasKey(p => p.BikeOwnerId);

            this.Property(p => p.BikeOwnerId)
                .HasColumnName("BikeOwnerId");

            this.Property(p => p.FirstName)
                .HasColumnName("FirstName");

            this.Property(p => p.LastName)
                .HasColumnName("LastName");
        }
    }
}
