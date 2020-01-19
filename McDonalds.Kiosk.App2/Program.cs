using McDonalds.Kiosk.App2.Forms;
using McDonalds.Kiosk.Core;
using McDonalds.Kiosk.Core.Contracts;
using McDonalds.Kiosk.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace McDonalds.Kiosk.App2
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var configuration = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json")
              .Build();

            var services = new ServiceCollection();
            services.ConfigureServices(configuration);

            var serviceProvider = services.BuildServiceProvider();

            var startWindow = serviceProvider.GetRequiredService<IdleForm>();
            Application.Run(startWindow);
        }

        private static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MySqlDatabaseConnectionString");
            services.AddDbContext<KioskMySqlContext>(optionsBuilder =>
                optionsBuilder.UseMySql(connectionString), ServiceLifetime.Transient);

            services.AddSingleton<SessionKeeper>();
            services.AddTransient<ISessionManager, SessionManager>();

            // Forms
            services.AddTransient<IdleForm>();
        }
    }
}
