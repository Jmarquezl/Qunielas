using Microsoft.AspNetCore.Mvc;
using QuinielerosWeb.Models;

namespace QuinielerosWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login() 
        {
            LoginModel model = new LoginModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Login(LoginModel model) {

            return View(model);
        }
    }
}
