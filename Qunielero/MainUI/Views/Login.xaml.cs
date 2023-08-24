using Quinieleros.Models;
using System.ComponentModel;

namespace Quinieleros.Views;

public partial class Login : ContentPage
{
    #region Members
    private string usuario;
    private string contrasenia;
    //private LoginViewModel model;
    #endregion

    #region Properties
    public string Usuario
    {
        get => usuario;
        set
        {
            if (value == usuario) return;
            usuario = value;
            OnPropertyChanged(nameof(Usuario));
        }
    }
    public string Contrasenia
    {
        get => contrasenia;
        set
        {
            if (value == contrasenia) return;
            contrasenia = value;
            OnPropertyChanged(nameof(Contrasenia));
        }
    }
    #endregion

    #region Ctor
    public Login()
	{
		InitializeComponent();
        //model = new LoginViewModel();
	}
    #endregion

    #region Methods

    #endregion

    #region Events
    private void btnLogin_Clicked(object sender, EventArgs e)
    {
        //model.Usuario = "Juls";
        Usuario = "Dad";
    }
    #endregion
}