
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Quinieleros.Models;
using Quinieleros.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.ViewModels
{
    public partial class BetViewModel : ObservableObject, IQueryAttributable
    {
        #region Members
        private string alias;
        #endregion

        #region Properties
        [ObservableProperty]
        public ObservableCollection<Partido> partidos;
        public string Alias
        {
            get => alias;
            set
            {
                if (value == alias) return;
                alias = value;
                OnPropertyChanged(nameof(Alias));
            }
        }
        #endregion

        #region Ctor
        public BetViewModel()
        {
            SaveCommand = new Command(Save, SaveCanExecute);

            partidos = new ObservableCollection<Partido>();
            var list = Enumerable.Repeat(new Partido()
            {
                EquipoLocal = "Equipo Local",
                EquipoVisita = "Equipo Visita",
            }, 8).ToList();
            foreach (var item in list)
                partidos.Add(item);

            ResetTemplate();
        }
        #endregion

        #region Commands
        public Command SaveCommand { get; private set; }
        #endregion

        #region CanExecute
        private bool SaveCanExecute() => true;
        #endregion

        #region Method
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
