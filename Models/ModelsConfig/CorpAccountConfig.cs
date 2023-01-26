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
    public class CorpAccountConfig : IEntityTypeConfiguration<CorpAccount>
    {
        public void Configure(EntityTypeBuilder<CorpAccount> builder)
        {
            builder.ToTable("CorpAccount");

            builder.HasKey(u => u.Id)
                   .HasName("corp_account_id");

            builder.Property(p => p.Login)
                   .HasColumnName("login")
                   .IsRequired();

            builder.Property(p => p.Password)
                   .HasColumnName("password")
                   .IsRequired();

            // Foreign keys
            builder.HasOne(p => p.AccountRole)
                   .WithMany(g => g.CorpAccounts)
                   .HasForeignKey(g => g.AccountRoleId);
        }
    }
}
