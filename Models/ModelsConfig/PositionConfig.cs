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
    public class PositionConfig : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.ToTable("Position");

            builder.Property(u => u.Id)
                   .HasColumnName("position_id");

            builder.Property(p => p.Title)
                   .HasColumnName("title")
                   .IsRequired();

            builder.Property(p => p.DepartmentId)
                   .HasColumnName("department_id");

            // Foreign keys
            builder.HasOne(e => e.Department)
                   .WithMany(p => p.Positions)
                   .HasForeignKey(e => e.DepartmentId);
        }
    }
}