using CommunityToolkit.Maui.Core;
using Quinieleros.Utils;

namespace Quinieleros
{
    public partial class App : Application
    {
        public static IServiceProvider Services;
        public static IAlertService Alert;
        public static IPopupService popupService;
        public static IRestClient restClient;
        public App(IServiceProvider provider)
        {
            InitializeComponent();

            Services = provider;
            Alert = Services.GetService<IAlertService>();
            popupService = Services.GetService<IPopupService>();
            restClient = Services.GetService<IRestClient>();
            MainPage = new AppShell();
        }
    }
}