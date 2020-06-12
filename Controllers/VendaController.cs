using Marketplace.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
{
    public class VendaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Vendas";
            ViewBag.User = Request.Cookies["Nome"];
            return View("~/Views/Empresa/Venda/Index.cshtml");
        }

    }
}