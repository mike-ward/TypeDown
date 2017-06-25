using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Practices.Unity;
using TypeDown.Services;
using TypeDown.Views;
using Page = TypeDown.Util.Page;

namespace TypeDown
{
    sealed partial class App
    {
        public App()
        {
            InitializeComponent();
        }

        protected override UIElement CreateShell(Frame rootFrame)
        {
            var shell = Container.Resolve<AppShell>();
            shell.SetContentFrame(rootFrame);
            return shell;
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate(Page.NameFromType(typeof(MainPage)), null);
            return Task.FromResult(true);
        }

        protected override Task OnInitializeAsync(IActivatedEventArgs args)
        {
            Container.RegisterType<IAlertMessageService, AlertMessageService>(new ContainerControlledLifetimeManager());
            return base.OnInitializeAsync(args);
        }
    }
}
