using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EF_core_practice.Models.ModelsConfig
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City");

            builder.Property(u => u.Id)
                   .HasColumnName("city_id");

            builder.Property(p => p.Name)
                   .HasColumnName("name")
                   .IsRequired().HasMaxLength(40);
            
            builder.HasOne(c => c.Country)
                   .WithMany(co => co.Cities)
                   .HasForeignKey(c => c.CountryId);
        }
    }
}
