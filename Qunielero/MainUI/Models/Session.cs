using Newtonsoft.Json;
using Quinieleros.Models.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.Models
{
    public static class Session
    {
        private static int idUsuario;
        private static string usuario;
        private static bool administrador;
        private static bool quinielaActiva;
        private static List<EquipoPOCO> equipos;
        public static int IdUsuario => idUsuario;
        public static string Usuario => usuario;
        public static bool Administrador => administrador;
        public static bool QuinielaActiva => quinielaActiva;

        static Session()
        {

        }
        public static void SetSession(string jsonSession) 
        {
            SessionPOCO session = JsonConvert.DeserializeObject<SessionPOCO>(jsonSession);
            idUsuario = session.IdUsuario;
            usuario = session.Usuario;
            administrador = session.Administrador;
            quinielaActiva = session.QuinielaActiva;
            equipos = session.Equipos;
        }
    }
}
