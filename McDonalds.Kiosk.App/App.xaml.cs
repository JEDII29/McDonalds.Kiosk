using McDonalds.Kiosk.App.Views.Pages;
using McDonalds.Kiosk.App.Views.Windows;
using McDonalds.Kiosk.Core;
using McDonalds.Kiosk.Core.Contracts;
using McDonalds.Kiosk.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace McDonalds.Kiosk.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IConfiguration _configuration;

        protected override void OnStartup(StartupEventArgs e)
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var startWindow = serviceProvider.GetRequiredService<MainWindow>();
            var idlePage = serviceProvider.GetRequiredService<Idle>();

            startWindow.MainWindowContent.Navigate(idlePage);
            startWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            var connectionString = _configuration.GetConnectionString("MySqlDatabaseConnectionString");
            services.AddDbContext<KioskMySqlContext>(optionsBuilder =>
                optionsBuilder.UseMySql(connectionString), ServiceLifetime.Transient);

            services.AddSingleton<SessionKeeper>();
            services.AddTransient<ISessionManager, SessionManager>();

            // Views
            services.AddTransient<MainWindow>();
            services.AddTransient<Idle>();
            services.AddTransient<DuringOrder>();
        }
    }
}
