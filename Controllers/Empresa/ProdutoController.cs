using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers.Empresa {
    public class ProdutoController : Controller {
        public IActionResult Index()
        {
            ViewBag.Title = "Produtos";
            return View("~/Views/Empresa/Produto/Index.cshtml");
        }
    }
}