using Quinieleros.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.Models
{
    public class LoginViewModel : BaseViewModel
    {
        private string usuario;
        private string contrasenia;
        public string Usuario
        {
            get => usuario;
            set
            {
                if (value == usuario) return;
                usuario = value;
                OnPropertyChanged(nameof(Usuario));
            }
        }
        public string Contrasenia
        {
            get => contrasenia;
            set
            {
                if (value == contrasenia) return;
                contrasenia = value;
                OnPropertyChanged(nameof(Contrasenia));
            }
        }
    }
}
