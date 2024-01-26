using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.Models.POCO
{
    public class JornadaPOCO : BasePOCO
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }
        [JsonProperty("fechaCierre")]
        public DateTimeOffset? FechaCierre { get; set; }
        [JsonProperty("activo")]
        public bool Activo { get; set; }
    }
}
