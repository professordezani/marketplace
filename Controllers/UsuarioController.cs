using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}