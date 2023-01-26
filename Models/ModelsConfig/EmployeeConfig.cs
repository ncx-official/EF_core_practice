using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Models.ModelsConfig
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.HasKey(u => u.Id)
                   .HasName("Employee_id");

            builder.Property(p => p.HireDate)
                   .HasColumnName("hire_date")
                   .IsRequired();

            builder.Property(p => p.Salary)
                   .HasColumnName("salary")
                   .IsRequired();
            builder.ToTable(p => p.HasCheckConstraint("CK_Employee_salary", "[salary] > 0"));
            
            builder.Property(p => p.WorkTimePerWeek)
                   .HasColumnName("workTime_perWeek")
                   .IsRequired();
            builder.ToTable(p => p.HasCheckConstraint("CK_Employee_workTime_perWeek", "[workTime_perWeek] > 0"));

            // Foreign keys
            builder.HasOne(e => e.Person)
                   .WithOne(p => p.Employee)
                   .HasForeignKey<Employee>(e => e.PersonId);

            builder.HasOne(e => e.WorkPlace)
                   .WithMany(w => w.Employees)
                   .HasForeignKey(e => e.WorkPlaceId);
            
            builder.HasOne(e => e.Position)
                   .WithMany(p => p.Employees)
                   .HasForeignKey(e => e.PositionId);
            
            builder.HasOne(e => e.CorpAccount)
                   .WithOne(p => p.Employee)
                   .HasForeignKey<Employee>(e => e.CorpAccountId);
        }
    }
}
