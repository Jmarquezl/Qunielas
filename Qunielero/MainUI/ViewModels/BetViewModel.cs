
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Quinieleros.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.ViewModels
{
    public partial class BetViewModel : ObservableObject, IQueryAttributable
    {
        #region Members
        #endregion

        #region Properties
        #endregion

        #region Ctor
        public BetViewModel()
        {
            SaveCommand = new Command(Save, SaveCanExecute);
            BackCommand = new Command(Back, SaveCanExecute);

            ResetTemplate();
        }
        #endregion

        #region Commands
        public Command SaveCommand { get; private set; }
        public Command BackCommand { get; private set; }
        #endregion

        #region CanExecute
        private bool SaveCanExecute() => true;
        #endregion

        #region Method
        public void Back()
        {
            Shell.Current.GoToAsync(nameof(RankPage));
        }
        private void ResetTemplate()
        {
        }
        private void Save() 
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
