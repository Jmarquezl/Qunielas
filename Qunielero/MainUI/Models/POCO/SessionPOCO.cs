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
        [JsonProperty("idUsuario")]
        public int IdUsuario { get; set; }
        [JsonProperty("usuario")]
        public string Usuario{ get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }
        [JsonProperty("administrador")]
        public bool Administrador { get; set; }
        [JsonProperty("quinielaActiva")]
        public bool QuinielaActiva { get; set; }
        [JsonProperty("equipos")]
        public List<EquipoPOCO> Equipos { get; set; }
        [JsonProperty("grupo")]
        public GrupoPOCO Grupo { get; set; }
        [JsonProperty("torneo")]
        public TorneoPOCO Torneo { get; set; }
    }
    public class EquipoPOCO 
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }
    }
}
