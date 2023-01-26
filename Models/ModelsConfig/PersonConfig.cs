using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Models.ModelsConfig
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");

            builder.Property(u => u.Id)
                   .HasColumnName("person_id");

            builder.Property(p => p.FirstName)
                   .HasColumnName("first_name")
                   .IsRequired().HasMaxLength(40);
            
            builder.Property(p => p.LastName)
                   .HasColumnName("last_name")
                   .IsRequired().HasMaxLength(40);

            builder.Property(p => p.BirthDate)
                   .HasColumnName("birthdate")
                   .IsRequired();
            
            builder.Property(p => p.PhoneNumber)
                   .HasColumnName("phone_number")
                   .IsRequired().HasMaxLength(20);
            
            builder.Property(p => p.Email)
                   .HasColumnName("email")
                   .IsRequired().HasMaxLength(40);

            // Foreign keys        
            builder.HasOne(p => p.Gender)
                   .WithMany(g => g.People)
                   .HasForeignKey(g => g.GenderId);
            
            builder.HasOne(p => p.City)
                   .WithMany(g => g.People)
                   .HasForeignKey(g => g.CityId);
        }
    }
}
