using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.ViewModels.PopUps
{
    public partial class PartidoViewModel : ObservableObject, IQueryAttributable
    {
        #region Members
        private string equipoLocal;
        private string equipoVisita;
        #endregion

        #region Properties
        public string EquipoLocal 
        { 
            get => equipoLocal;
            set 
            {
                if (value == equipoLocal) return;
                equipoLocal = value;
                OnPropertyChanged(nameof(EquipoLocal));
            }
        }
        public string EquipoVisita
        {
            get => equipoVisita;
            set
            {
                if (value == equipoVisita) return;
                equipoVisita = value;
                OnPropertyChanged(nameof(EquipoVisita));
            }
        }
        #endregion

        #region Ctor
        public PartidoViewModel()
        {
            AddCommand = new Command(AddPartido, AddCanExecute);
        }
        #endregion

        #region CanExecute
        private bool AddCanExecute() => true;
        #endregion

        #region Commands
        public Command AddCommand { get; private set; }
        #endregion

        #region Methods
        public void AddPartido() 
        {
            
        }
        #endregion

        #region Internal
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            
        }

        #endregion
    }
}
