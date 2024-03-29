﻿using Newtonsoft.Json;
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
        private static string idUsuario;
        private static string usuario;
        private static string nombreCompleto;
        private static bool administrador;
        private static GrupoPOCO grupo;
        private static TorneoPOCO torneo;
        private static JornadaPOCO jornada;
        private static List<EquipoPOCO> equipos;
        public static string IdUsuario => idUsuario;
        public static string Usuario => usuario;
        public static string NombreCompleto => nombreCompleto;
        public static bool Administrador => administrador;
        public static JornadaPOCO Jornada => jornada;
        public static List<EquipoPOCO> GetEquipos() => equipos.OrderBy(e => e.Nombre).ToList();
        public static GrupoPOCO Grupo => grupo;
        public static TorneoPOCO Torneo => torneo;
        public static bool ConfiguracionCompleta => !string.IsNullOrEmpty(grupo?.Id) && !string.IsNullOrEmpty(torneo?.Id);
        static Session()
        {

        }
        public static void SetSession(SessionPOCO session) 
        {
            idUsuario = session.Id;
            usuario = session.Usuario;
            nombreCompleto = $"{session.Nombre} {session.Paterno} {session.Materno}";
            administrador = session.Administrador;
            equipos = session.Equipos;
            grupo = session.Grupo;
            torneo = session.Torneo;
            jornada = session.Jornada;

            Preferences.Set("token", session.Token);
            Preferences.Set("idGrupo", session.Grupo.Id);
        }
        public static void SetJornadaActiva(JornadaPOCO jornadaActiva) 
        {
            jornada = jornadaActiva;
        }
    }
}
