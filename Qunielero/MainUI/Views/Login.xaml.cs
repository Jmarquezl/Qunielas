using Quinieleros.Models;
using System.ComponentModel;

namespace Quinieleros.Views;

public partial class Login : ContentPage
{
    #region Members
    public LoginViewModel viewModel;
    #endregion

    #region Properties
    #endregion

    #region Ctor
    public Login()
	{
		InitializeComponent();
        viewModel = new LoginViewModel();
        BindingContext = viewModel;
	}
    #endregion

    #region Methods

    #endregion

    #region Events
    private void btnLogin_Clicked(object sender, EventArgs e)
    {
        viewModel.Usuario = "Juls";
    }
    #endregion
}