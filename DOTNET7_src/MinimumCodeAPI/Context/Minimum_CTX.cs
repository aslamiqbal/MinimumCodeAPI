using Microsoft.EntityFrameworkCore;
using MinimumCodeAPI.Model;

namespace MinimumCodeAPI.Context
{
    public class Minimum_CTX : DbContext
    {
        //Add-Migration Initial
        //update-database
        public Minimum_CTX()
        {

        }
        public Minimum_CTX(DbContextOptions options) : base(options)
        {

        }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var cofigString = "IdentityConnection";
                var connectionString = configuration.GetConnectionString(cofigString);

                optionsBuilder.UseSqlServer(connectionString);
                base.OnConfiguring(optionsBuilder);
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }
        public DbSet<BMCarType> BMCarTypes { get; set; }
    }
}
