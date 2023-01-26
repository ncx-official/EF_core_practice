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
    public class WorkPlaceConfig : IEntityTypeConfiguration<WorkPlace>
    {
        public void Configure(EntityTypeBuilder<WorkPlace> builder)
        {
            builder.ToTable("WorkPlace");

            builder.Property(u => u.Id)
                   .HasColumnName("work_place_id");

            builder.Property(p => p.Name)
                   .HasColumnName("name")
                   .IsRequired();

            builder.Property(p => p.IsSelfMadeHardware)
                   .HasColumnName("isSelfMade_hardware")
                   .IsRequired();
        }
    }
}
