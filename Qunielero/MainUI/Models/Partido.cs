using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.Models
{
    public class Partido
    {
        public int IdLocal { get; set; }
        public int? Local { get; set; }
        public string EquipoLocal { get; set; }

        public int IdVisita { get; set; }
        public int? Visita { get; set; }
        public string EquipoVisita { get; set; }
        public bool EsBonus { get; set; }
    }
}
