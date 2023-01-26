using EF_core_practice.Models;
using EF_core_practice.Models.ModelsConfig;
using Microsoft.EntityFrameworkCore;


namespace EF_core_practice.Context
{
    public class ApplicationContext : DbContext
    {
        readonly StreamWriter logStream = new StreamWriter(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + String.Format(@"\Logs\logs.txt", true));
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CorpAccount> CorpAccounts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<WorkPlace> WorkPlaces { get; set; }

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
        // Fluent API config
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Table "AccountRole"
            modelBuilder.ApplyConfiguration(new AccountRoleConfig());
            
            // Table "City"
            modelBuilder.ApplyConfiguration(new CityConfig());

            // Table "CorpAccount"
            modelBuilder.ApplyConfiguration(new CorpAccountConfig());

            // Table "Country"
            modelBuilder.ApplyConfiguration(new CountryConfig());

            // Table "Department"
            modelBuilder.ApplyConfiguration(new DepartmentConfig());

            // Table "Employee"
            modelBuilder.ApplyConfiguration(new EmployeeConfig());

            // Table "Gender"
            modelBuilder.ApplyConfiguration(new GenderConfig());

            // Table "Person"
            modelBuilder.ApplyConfiguration(new PersonConfig());

            // Table "Position"
            modelBuilder.ApplyConfiguration(new PositionConfig());

            // Table "WorkPlace"
            modelBuilder.ApplyConfiguration(new WorkPlaceConfig());
        }
       
        // Dispose StreamWriter object
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
