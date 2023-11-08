using Quinieleros.Views;
using Quinieleros.Views.PopUps;

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
            Routing.RegisterRoute(nameof(JornadaPage), typeof(JornadaPage));
            Routing.RegisterRoute(nameof(PartidoPage), typeof(PartidoPage));
        }
    }
}