using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace WpfDependencyInjection
{
    public partial class App : Application
    {
        private readonly IServiceProvider serviceProvider;

        public App()
        {
            serviceProvider = ConfigureServices().BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = serviceProvider.GetService<MainWindow>();
            var mainWindowViewModel = serviceProvider.GetService<MainWindowViewModel>();

            mainWindow.DataContext = mainWindowViewModel;
            mainWindow.Show();
        }

        private IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<MainWindow>();
            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<IWriter, DefaultWriter>();
            services.AddSingleton<ICalculator, DefaultCalculator>();
            services.AddSingleton<IBusinessLogic, BusinessLogic>();

            return services;
        }
    }
}
