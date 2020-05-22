using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers.Empresa {
    public class VendaController : Controller {
        public IActionResult Index()
        {
            ViewBag.Title = "Vendas";
            return View("~/Views/Empresa/Venda/Index.cshtml");
        }
    }
}