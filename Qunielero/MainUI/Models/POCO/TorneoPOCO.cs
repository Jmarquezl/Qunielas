using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.Models.POCO
{
    public class TorneoPOCO : BasePOCO
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }
    }
}
