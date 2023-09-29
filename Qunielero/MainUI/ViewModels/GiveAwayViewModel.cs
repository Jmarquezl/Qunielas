using CommunityToolkit.Mvvm.ComponentModel;
using Quinieleros.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.ViewModels
{
    public class GiveAwayViewModel : ObservableObject, IQueryAttributable
    {
        #region Members
        #endregion

        #region Properties
        #endregion

        #region Ctor
        public GiveAwayViewModel()
        {
            SaveCommand = new Command(Save, SaveCanExecute);
            BackCommand = new Command(Back, BackCanExecute);
            CancelCommand = new Command(Cancel, CancelCanExecute);

            ResetTemplate();
        }
        #endregion

        #region Commands
        public Command SaveCommand { get; private set; }
        public Command BackCommand { get; private set; }
        public Command CancelCommand { get; private set; }
        #endregion

        #region CanExecute
        private bool SaveCanExecute() => true;
        private bool BackCanExecute() => true;
        private bool CancelCanExecute() => true;
        #endregion

        #region Method
        public void Back()
        {
            Shell.Current.GoToAsync(nameof(Rank));
        }
        private void ResetTemplate()
        {
        }
        private void Save()
        {
        }
        private void Cancel() 
        {
        
        }
        #endregion
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("load"))
            {
            }
        }
    }
}
