using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using Quinieleros.Models;
using Quinieleros.Models.POCO;
using Quinieleros.Views;
using Quinieleros.Views.PopUps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.ViewModels.PopUps
{
    public partial class PartidoViewModel : ObservableObject, IQueryAttributable
    {
        #region Members
        private EquipoPOCO selectedEquipoLocal;
        private EquipoPOCO selectedEquipoVisita;
        private readonly IPopupService popupService;        
        #endregion

        #region Properties
        [ObservableProperty]
        public ObservableCollection<EquipoPOCO> equipos;
        public EquipoPOCO SelectedEquipoLocal 
        {
            get => selectedEquipoLocal;
            set 
            {
                if (value == selectedEquipoLocal) return;
                selectedEquipoLocal = value;
                OnPropertyChanged(nameof(SelectedEquipoLocal));
                AddCommand.ChangeCanExecute();
            }
        }
        public EquipoPOCO SelectedEquipoVisita
        {
            get => selectedEquipoVisita;
            set
            {
                if (value == selectedEquipoVisita) return;
                selectedEquipoVisita = value;
                OnPropertyChanged(nameof(SelectedEquipoVisita));
                AddCommand.ChangeCanExecute();
            }
        }
        public Action<Partido> OnResult{ get; set; }
        #endregion

        #region Ctor
        public PartidoViewModel()
        {
            AddCommand = new Command(AddPartido, AddCanExecute);
            this.popupService = App.popupService;

            equipos = new ObservableCollection<EquipoPOCO>();
            Session.GetEquipos().ForEach(e => equipos.Add(e));
        }
        #endregion

        #region CanExecute
        private bool AddCanExecute() => selectedEquipoLocal?.Id > 0 && selectedEquipoVisita?.Id > 0;
        #endregion

        #region Commands
        public Command AddCommand { get; private set; }
        #endregion

        #region Methods
        public async void AddPartido() 
        {
            OnResult.Invoke(new Partido() { EquipoLocal = selectedEquipoLocal.Nombre, EquipoVisita = selectedEquipoVisita.Nombre, EsBonus= false});
        }
        #endregion

        #region Internal
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            
        }

        #endregion
    }
}
