using CommunityToolkit.Mvvm.ComponentModel;
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
    public partial class HomeViewModel : ObservableObject, IQueryAttributable
    {
        #region Members
        #endregion

        #region Properties
        [ObservableProperty]
        public ObservableCollection<Quiniela> registros;
        #endregion

        #region Ctor
        public HomeViewModel()
        {
            BetCommand = new Command(NewBet, BetCanExecute);
            GiveAwayCommand = new Command(NewGiveAway, GiveAwayCanExecute);

            Image image = new Image
            {
                Source = ImageSource.FromFile("dotnet_bot.png")
            };
            registros = new ObservableCollection<Quiniela>();
            registros.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            registros.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            registros.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            registros.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            registros.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            registros.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            registros.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            registros.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            registros.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            registros.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
        }
        #endregion

        #region Commands
        public Command BetCommand { get; private set; }
        public Command GiveAwayCommand { get; private set; }
        #endregion

        #region CanExecute
        private bool BetCanExecute() => true;
        private bool GiveAwayCanExecute() => true;
        #endregion

        #region Methods
        private void NewBet()
        {
            Shell.Current.GoToAsync(nameof(BetPage));
        }
        private async void NewGiveAway()
        {
            //Task.Run(async () =>
            //{
            //    App.Alert.DisplayPrompt("Nueva Jornada", "Nombre:", "Guardar", "Cancelar", (result =>
            //    {
            //        //App.Alert.ShowAlert("Result", $"{result}");
            //        JornadaVigente = result;
            //    }));
            //});
        }
        #endregion

        #region Base
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {

        }
        #endregion
    }
}
