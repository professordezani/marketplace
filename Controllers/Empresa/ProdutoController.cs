using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers.Empresa {
    public class ProdutoController : Controller {
        public IActionResult Index()
        {
            return View("~/Views/Empresa/Produto/Index.cshtml");
        }
    }
}