
namespace Quinieleros.Views;
using Quinieleros.Models;

public partial class FlyoutHeaderControl : StackLayout
{
	public FlyoutHeaderControl()
	{
		InitializeComponent();
		lblQuinielero.Text = Session.Nombre;
	}
}