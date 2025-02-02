using Quinieleros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.Utils
{
    public interface IRestClient
    {
        Task<string> Logine(string user, string password);
        Task<string> JornadaActiva(string grupo);
        Task<string> CrearJornada(string grupo, string nombre, DateTime fechaCierre, List<Partido> partidos);
    }
}
