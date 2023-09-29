using Quinieleros.Views;

namespace Quinieleros
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(RankPage), typeof(RankPage));
            Routing.RegisterRoute(nameof(BetPage), typeof(BetPage));
        }
    }
}