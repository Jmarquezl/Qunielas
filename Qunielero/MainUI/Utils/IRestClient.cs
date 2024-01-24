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
    }
}
