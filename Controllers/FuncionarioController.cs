using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}