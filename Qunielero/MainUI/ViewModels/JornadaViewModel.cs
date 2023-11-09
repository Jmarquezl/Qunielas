using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls.Xaml;
using Quinieleros.Models;
using Quinieleros.ViewModels.PopUps;
using Quinieleros.Views.PopUps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.ViewModels
{
    public partial class JornadaViewModel : ObservableObject, IQueryAttributable
    {
        #region Members
        private string alias;
        private readonly IPopupService popupService;
        private Popup partidoView;
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
        public JornadaViewModel()
        {
            this.popupService = App.popupService;

            SaveCommand = new Command(Save, SaveCanExecute);
            AddCommand = new Command(Add, AddCanExecute);

            partidos = new ObservableCollection<Partido>();
            var list = Enumerable.Repeat(new Partido()
            {
                EquipoLocal = "Equipo Local",
                EquipoVisita = "Equipo Visita",
            }, 3).ToList();
            foreach (var item in list)
                partidos.Add(item);

            ResetTemplate();
        }
        #endregion

        #region Commands
        public Command SaveCommand { get; private set; }
        public Command AddCommand { get; private set; }
        #endregion

        #region CanExecute
        private bool SaveCanExecute() => true;
        private bool AddCanExecute() => true;
        #endregion

        #region Method
        private void ResetTemplate()
        {
        }
        private async void Save()
        {
            
        }
        private async void Add() 
        {
            var partidoVM = new PartidoViewModel();
            partidoVM.OnResult = (o) => PartidoNuevo(o);
            partidoView = ((Popup)new PartidoPage());
            partidoView.BindingContext = partidoVM;
            await Application.Current.MainPage.ShowPopupAsync(partidoView);
        }
        private async void PartidoNuevo(Partido partido) 
        {
            partidos.Add(partido);
            await partidoView.CloseAsync();
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
