using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Models.ModelsConfig
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Companies");

            builder.HasKey(u => u.Id)
                   .HasName("company_id");

            builder.Property(p => p.Name)
                   .HasColumnName("name")
                   .IsRequired();

            builder.Property(p => p.Description)
                   .HasColumnName("description")
                   .IsRequired();
        }

        // modelBuilder.Entity<User>().HasKey(u => new { u.PassportSeria, u.PassportNumber});
        // isUnique();
        // modelBuilder.Entity<User>().HasCheckConstraint("Age", "Age > 0 AND Age < 120");

        // modelBuilder.Entity<User>().Property(b => b.Name).HasMaxLength(50);

        // modelBuilder.Entity<User>().HasOne(u => u.Company).WithMany(c => c.Users).OnDelete(DeleteBehavior.Cascade);

    }
}
