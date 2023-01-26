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
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");

            builder.Property(u => u.Id)
                   .HasColumnName("country_id");

            builder.Property(p => p.Name)
                   .HasColumnName("name")
                   .IsRequired().HasMaxLength(40);
        }
    }
}
