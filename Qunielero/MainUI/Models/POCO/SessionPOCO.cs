using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.Models.POCO
{
    public class SessionPOCO
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("grupo")]
        public GrupoPOCO Grupo { get; set; }
        [JsonProperty("torneo")]
        public TorneoPOCO Torneo { get; set; }
        [JsonProperty("jornada")]
        public JornadaPOCO Jornada { get; set; }
        [JsonProperty("usuario")]
        public string Usuario{ get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }
        [JsonProperty("paterno")]
        public string Paterno { get; set; }
        [JsonProperty("materno")]
        public string Materno { get; set; }
        [JsonProperty("admin")]
        public bool Administrador { get; set; }
        [JsonProperty("quinielaActiva")]
        public bool QuinielaActiva { get; set; }
        [JsonProperty("equipos")]
        public List<EquipoPOCO> Equipos { get; set; }
    }
    public class EquipoPOCO 
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }
    }
}
