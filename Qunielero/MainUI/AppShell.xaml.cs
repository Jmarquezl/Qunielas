using Quinieleros.Views;

namespace Quinieleros
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Rank), typeof(Rank));
            Routing.RegisterRoute(nameof(Bet), typeof(Bet));
            Routing.RegisterRoute(nameof(GiveAway), typeof(GiveAway));
        }
    }
}