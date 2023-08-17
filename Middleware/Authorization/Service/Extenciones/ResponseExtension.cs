using Authorization.Entity;
using System.Net;
using System.Runtime.CompilerServices;

namespace Authorization.Service.Extenciones
{
    public static class ResponseExtension
    {
        private static Int16 ip;
        static ResponseExtension()
        {
            var addreses = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            ip = Convert.ToInt16(addreses[addreses.Length - 1].ToString().Split(".")[3].ToString());
        }
        public static IResponseBase Success(this IResponseBase response, string message) 
        {
            response.Success = true;
            response.Message = message;
            response.folio = Folio();
            return response;
        }
        public static IResponseBase Fail(this IResponseBase response, string message)
        {
            response.Success = false;
            response.Message = message;
            response.folio = Folio();
            return response;
        }
        private static string Folio() 
        {
            DateTime now = DateTime.Now;
            return $"{ip.ToString("D3")}{now.Year.ToString("D4")}{now.Month.ToString("D2")}{now.Day.ToString("D2")}{now.Hour.ToString("D2")}{now.Minute.ToString("D2")}{now.Second.ToString("D2")}";
        }
    }
}
