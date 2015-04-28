using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.DomainModel;

namespace Registar.DataLayer
{
    public class BikeConfiguration 
        : EntityTypeConfiguration<Bike>
    {
        public BikeConfiguration()
        {
            this.ToTable("Bikes", "data")
                //.HasKey(x => new {Id = x.BikeId, Colour = x.Colour});
                .HasKey(p => p.BikeId);

            this.Property(p => p.BikeId)
                .HasColumnName("BikeId");

            this.Property(p => p.BikeOwnerId)
                .HasColumnName("BikeOwnerId");

            this.Property(p => p.RegNumber)
                .HasColumnName("RegisterNumber")
                .IsRequired();

            this.Property(p => p.Producer)
                .HasColumnName("Manufacturer")
                .IsRequired();

            this.Property(p => p.Model)
                .HasColumnName("Model");

            this.Property(p => p.Colour)
                .HasColumnName("Colour");

            this.Property(p => p.City)
                .HasColumnName("City");

            this.Property(p => p.SpeedsCount)
                .HasColumnName("SpeedsCount");

            //this.Ignore(p => p.SpeedsCount);

            this.Ignore(p => p.IgnoreMe);

            this.Ignore(p => p.TimeStamp);

            this.Ignore(p => p.History);
        }
    }
}
