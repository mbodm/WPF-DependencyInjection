using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WpfDependencyInjection
{
    public partial class App : Application
    {
        private readonly IHost host;

        public App()
        {
            host = Host.CreateDefaultBuilder().ConfigureServices(services => ConfigureServices(services)).Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            using (host)
            {
                await host.StartAsync();

                var mainWindow = host.Services.GetService<MainWindow>();
                var mainWindowViewModel = host.Services.GetService<MainWindowViewModel>();

                mainWindow.DataContext = mainWindowViewModel;
                mainWindow.Show();
            }
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            using (host)
            {
                await host.StopAsync();
            }
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<IWriter, DefaultWriter>();
            services.AddSingleton<ICalculator, DefaultCalculator>();
            services.AddSingleton<IBusinessLogic, BusinessLogic>();
        }
    }
}
