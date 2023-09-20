using Quinieleros.Views;

namespace Quinieleros
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Rank), typeof(Rank));
        }
    }
}