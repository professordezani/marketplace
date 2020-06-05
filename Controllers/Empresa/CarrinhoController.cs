using Marketplace.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers.Empresa
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Carrinho";
            return View("~/Views/Empresa/Venda/Carrinho.cshtml");
        }

    }
}