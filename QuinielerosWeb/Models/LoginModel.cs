using System.ComponentModel.DataAnnotations;

namespace QuinielerosWeb.Models
{
    public class LoginModel
    {
        public string Usuario { get; set; } = string.Empty;
        public string Pass { get; set; } = string.Empty;
    }
}
