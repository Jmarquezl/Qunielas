using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using Quinieleros.Models;
using Quinieleros.Views;
using Quinieleros.Views.PopUps;
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
        private readonly IPopupService popupService;        
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
        public Action<Partido> OnResult{ get; set; }
        #endregion

        #region Ctor
        public PartidoViewModel()
        {
            AddCommand = new Command(AddPartido, AddCanExecute);
            this.popupService = App.popupService;
        }
        #endregion

        #region CanExecute
        private bool AddCanExecute() => true;
        #endregion

        #region Commands
        public Command AddCommand { get; private set; }
        #endregion

        #region Methods
        public async void AddPartido() 
        {
            OnResult.Invoke(new Partido() { EquipoLocal = equipoLocal, EquipoVisita = equipoVisita});
        }
        #endregion

        #region Internal
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            
        }

        #endregion
    }
}
