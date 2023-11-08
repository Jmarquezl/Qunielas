using CommunityToolkit.Maui.Core;
using Quinieleros.Utils;

namespace Quinieleros
{
    public partial class App : Application
    {
        public static IServiceProvider Services;
        public static IAlertService Alert;
        public static IPopupService popupService;
        public App(IServiceProvider provider)
        {
            InitializeComponent();

            Services = provider;
            Alert = Services.GetService<IAlertService>();
            popupService = Services.GetService<IPopupService>();
            MainPage = new AppShell();
        }
    }
}