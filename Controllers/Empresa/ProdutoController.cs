using Microsoft.AspNetCore.Mvc;
using System;
using Marketplace.Models.Entidades;

namespace Marketplace.Controllers.Empresa {
    public class ProdutoController : Controller {
        public IActionResult Index()
        {
            ViewBag.Title = "Produtos";
            return View("~/Views/Empresa/Produto/Index.cshtml");
        }

        public IActionResult Save(Guid? id)
        {
           ViewBag.Title = "Produto";
           return View("~/Views/Empresa/Produto/Save.cshtml");
        }

        [HttpPost]
        public IActionResult Save(Produto produto){
            return RedirectToAction("Index");
        }
    }
}