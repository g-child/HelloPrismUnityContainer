using HelloPrismUnityContainer.Views;
using Prism.Mvvm;
using System.Windows;
using Unity;

namespace HelloPrismUnityContainer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IUnityContainer Container { get; } = new UnityContainer();

        private void Application_Startup(object sender, StartupEventArgs eventArgs)
        {
            ViewModelLocationProvider.SetDefaultViewModelFactory(x => Container.Resolve(x));
            Container.Resolve<MainWindow>().Show();
        }
    }
}
