using CommunityToolkit.Mvvm.ComponentModel;
using Quinieleros.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.ViewModels
{
    public partial class RankViewModel : ObservableObject, IQueryAttributable
    {
        #region Members

        #endregion

        #region Properties
        [ObservableProperty]
        public ObservableCollection<Quiniela> quinielas;
        #endregion

        #region Ctor
        public RankViewModel()
        {
            BetCommand = new Command(Bet, BetCanExecute);

            Image image = new Image
            {
                Source = ImageSource.FromFile("dotnet_bot.png")
            };
            quinielas = new ObservableCollection<Quiniela>();
            quinielas.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}"});
            quinielas.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            quinielas.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            quinielas.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            quinielas.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            quinielas.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            quinielas.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            quinielas.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            quinielas.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
            quinielas.Add(new Quiniela() { Jornada = 8, Quinielero = "Julio Márquez", Puntos = 10, Resumen = $"J-{8} Puntos: {10}" });
        }
        #endregion

        #region Commands
        public Command BetCommand { get; private set; }
        #endregion

        #region CanExecute
        private bool BetCanExecute() => true;
        #endregion

        #region Methods
        private void Bet() 
        {
        
        }
        #endregion

        #region Base
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {

        }
        #endregion
    }
}
