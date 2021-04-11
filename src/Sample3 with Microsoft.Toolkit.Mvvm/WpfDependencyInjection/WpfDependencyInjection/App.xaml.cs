using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.DependencyInjection;

namespace WpfDependencyInjection
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ConfigureServices();

            var mainWindow = Ioc.Default.GetService<MainWindow>();
            var mainWindowViewModel = Ioc.Default.GetService<MainWindowViewModel>();

            mainWindow.DataContext = mainWindowViewModel;
            mainWindow.Show();
        }

        private void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<MainWindow>();
            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<IWriter, DefaultWriter>();
            services.AddSingleton<ICalculator, DefaultCalculator>();
            services.AddSingleton<IBusinessLogic, BusinessLogic>();

            Ioc.Default.ConfigureServices(services.BuildServiceProvider());
        }
    }
}
