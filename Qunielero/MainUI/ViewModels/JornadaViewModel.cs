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
        private string jornada;
        private DateTime fecha;
        private DateTime fechaMinima;
        private TimeSpan hora;
        private readonly IPopupService popupService;
        private Popup partidoView;
        #endregion

        #region Properties
        [ObservableProperty]
        public ObservableCollection<Partido> partidos;
        public string Jornada
        {
            get => jornada;
            set
            {
                if (value == jornada) return;
                jornada = value;
                OnPropertyChanged(nameof(Jornada));
                SaveCommand.ChangeCanExecute();
            }
        }
        public DateTime Fecha
        {
            get => fecha;
            set
            {
                if (value == fecha) return;
                fecha = value;
                OnPropertyChanged(nameof(Fecha));
                SaveCommand.ChangeCanExecute();
            }
        }
        public DateTime FechaMinima
        {
            get => fechaMinima;
            set
            {
                if (value == fechaMinima) return;
                fechaMinima = value;
                OnPropertyChanged(nameof(FechaMinima));
                SaveCommand.ChangeCanExecute();
            }
        }
        public TimeSpan Hora
        {
            get => hora;
            set
            {
                if (value == hora) return;
                hora = value;
                OnPropertyChanged(nameof(Hora));
                SaveCommand.ChangeCanExecute();
            }
        }
        #endregion

        #region Ctor
        public JornadaViewModel()
        {
            this.popupService = App.popupService;
            partidos = new ObservableCollection<Partido>();
            SaveCommand = new Command(Save, SaveCanExecute);
            AddCommand = new Command(Add, AddCanExecute);
            ResetTemplate();
        }
        #endregion

        #region Commands
        public Command SaveCommand { get; private set; }
        public Command AddCommand { get; private set; }
        #endregion

        #region CanExecute
        private bool SaveCanExecute() => Session.ConfiguracionCompleta && Partidos.Any();
        private bool AddCanExecute() => true;
        #endregion

        #region Method
        private void ResetTemplate()
        {
            Fecha = DateTime.Today;
            FechaMinima = DateTime.Today;
            Hora = TimeSpan.FromHours(17);
            Jornada = string.Empty;
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
            SaveCommand.ChangeCanExecute();
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
