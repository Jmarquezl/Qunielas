using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using Quinieleros.Models;
using Quinieleros.Models.POCO;
using Quinieleros.Utils;
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
        private IRestClient restClient;
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
            restClient = App.restClient;
            LoginCommand = new Command(Login, LoginCanExecute);
            ResetTemplate();
            Usuario = "jmarquez";
            Contrasenia = "julio";
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
            SessionPOCO session = JsonConvert.DeserializeObject<SessionPOCO>(restClient.Logine(Usuario, Contrasenia).Result);
            if (session.Code.Equals(CodeError.SUCCESS))
            {
                Session.SetSession(session);
                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();
                Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
            else
                App.Alert.ShowAlert("Quinieleros", "Loging failed");
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
