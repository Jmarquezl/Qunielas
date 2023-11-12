using CommunityToolkit.Mvvm.ComponentModel;
using Quinieleros.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quinieleros.Models;

namespace Quinieleros.ViewModels
{
    public partial class AppShellViewModel : ObservableObject, IQueryAttributable
    {
        #region Members
        #endregion

        #region Properties      
        #endregion
        #region Commands
        public Command LogOutCommand { get; private set; }
        #endregion

        #region Ctor
        public AppShellViewModel()
        {
            LogOutCommand = new Command(LogOut, LogOutCanExecute);
        }
        #endregion

        #region CanExecute
        private bool LogOutCanExecute() => true;// Session.IdUsuario > 0;
        #endregion


        #region Methods
        private void LogOut() 
        {
            Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
        #endregion
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            throw new NotImplementedException();
        }
    }
}
