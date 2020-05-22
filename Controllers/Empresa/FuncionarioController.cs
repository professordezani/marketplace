using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers.Empresa
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Funcionários";
            return View("~/Views/Empresa/Funcionario/Index.cshtml");
        }
    }
}