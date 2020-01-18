using McDonalds.Kiosk.App.Commands;
using McDonalds.Kiosk.App.ViewModels;
using McDonalds.Kiosk.App.Views;
using McDonalds.Kiosk.Utilities.Contracts;
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

            var startWindow = serviceProvider.GetRequiredService<Idle>();
            startWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<SessionKeeper>();
            services.AddTransient<ISessionManager, SessionManager>();

            // Commands
            services.AddTransient<OpenSessionCommand>();

            // ViewModels
            services.AddTransient<IdleViewModel>();

            // Views
            services.AddTransient<Idle>();
        }
    }
}
