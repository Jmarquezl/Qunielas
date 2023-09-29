using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.ViewModels
{
    public class GeneralViewModel : ObservableObject, IQueryAttributable
    {
        #region Members
        #endregion

        #region Properties
        #endregion

        #region Ctor
        public GeneralViewModel()
        {
            SaveCommand = new Command(Save, SaveCanExecute);

            ResetTemplate();
        }
        #endregion

        #region Commands
        public Command SaveCommand { get; private set; }
        #endregion

        #region CanExecute
        private bool SaveCanExecute() => true;
        #endregion

        #region Methods
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
