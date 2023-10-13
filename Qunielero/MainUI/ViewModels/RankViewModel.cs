using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Quinieleros.Models;
using Quinieleros.Utils;
using Quinieleros.Views;
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
           
        #endregion

        #region CanExecute
        private bool BetCanExecute() => true;
        private bool GiveAwayCanExecute() => true;
        #endregion

        #region Methods
        #endregion

        #region Base
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {

        }
        #endregion
    }
}
