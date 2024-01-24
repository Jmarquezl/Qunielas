using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.Utils
{
    internal static class Extersiones
    {
        internal static string ToJson(this object _object) => JsonConvert.SerializeObject(_object);
    }
}
