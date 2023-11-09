using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Quinieleros.Models;
using Quinieleros.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace Quinieleros.ViewModels
{
    public class LoginViewModel : ObservableObject, IQueryAttributable
    {
        #region Members
        private string usuario;
        private string contrasenia;
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
                LoginCommand.ChangeCanExecute();
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
                LoginCommand.ChangeCanExecute();
            }
        }
        #endregion

        #region Ctor
        public LoginViewModel()
        {
            LoginCommand = new Command(Login, LoginCanExecute);
            ResetTemplate();
            Usuario = "Julio";
            Contrasenia = "Julio";
        }
        #endregion

        #region Commands
        public Command LoginCommand { get; private set; }
        #endregion

        #region CanExecute
        private bool LoginCanExecute() => usuario.Length > 3 && !string.IsNullOrEmpty(contrasenia);
        #endregion

        #region Methods
        private void ResetTemplate() 
        {
            usuario = string.Empty;
            contrasenia = string.Empty;
        }
        private void Login() 
        {
            Session.SetSession("{\"idUsuario\":19, \"usuario\":\"julio cesar\", \"administrador\":true,\"equipos\":[{\"id\":1,\"nombre\":\"Manchester\"}, {\"id\":2,\"nombre\":\"Feyenord\"}, {\"id\":3,\"nombre\":\"Jaguares\"}]}");
            Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
        #endregion
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("load"))
            {
                OnPropertyChanged(nameof(Usuario));
                OnPropertyChanged(nameof(Contrasenia));
            }
        }
    }
}
