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
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");

            builder.Property(u => u.Id)
                   .HasColumnName("department_id");

            builder.Property(p => p.Title)
                   .HasColumnName("title")
                   .IsRequired().HasMaxLength(50);
        }
    }
}
