using EF_core_practice.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF_core_practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            // getting all config options from Config\appsettings.json
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile(@"Config\appsettings.json");
            var config = builder.Build();
            // Creating options with connections string from config file
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultLocalHostConnection")).Options;
            
            // Working with DB by using ApplicationContext 
            using (ApplicationContext db = new ApplicationContext(options))
            {
                db.SaveChangesAsync();
            }
        }
    }
}