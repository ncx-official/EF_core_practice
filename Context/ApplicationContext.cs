using EF_core_practice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_practice.Context
{
    public class ApplicationContext : DbContext
    {
        readonly StreamWriter logStream = new StreamWriter(String.Format(@"Logs\logs.txt", true));
        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sex> Sexs { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<UserAccountRole> UserAccountRoles { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            // Database.EnsureCreatedAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql();
            optionsBuilder.LogTo(logStream.WriteLine);
        }

        public override void Dispose()
        {
            base.Dispose();
            logStream.Dispose();
        }

        public override async ValueTask DisposeAsync()
        {
            await base.DisposeAsync();
            await logStream.DisposeAsync();
        }
    }
}
