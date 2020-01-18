using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Reflection;

namespace McDonalds.Kiosk.DatabaseContext
{
    // TODO: add comment
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<KioskMySqlContext>
    {
        public KioskMySqlContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<KioskMySqlContext>();
            var connectionString = configuration.GetConnectionString("MySqlDatabaseConnectionString");

            optionsBuilder.UseMySql(connectionString);
            return new KioskMySqlContext(optionsBuilder.Options);
        }
    }
}
