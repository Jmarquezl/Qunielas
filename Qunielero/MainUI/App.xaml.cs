using Quinieleros.Utils;

namespace Quinieleros
{
    public partial class App : Application
    {
        public static IServiceProvider Services;
        public static IAlertService Alert;
        public App(IServiceProvider provider)
        {
            InitializeComponent();

            Services = provider;
            Alert = Services.GetService<IAlertService>();
            MainPage = new AppShell();
        }
    }
}