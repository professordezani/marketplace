using System;
using System.Collections.Generic;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
{
    public class ComprasController : Controller
    {
        private readonly IVendaRepository _vendaRepository;

        public ComprasController(IVendaRepository vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Compras Resumo";
            var id = new Guid(Request.Cookies["Id"]);
            var vendas = _vendaRepository.ReadByCliente(id);
            return View("~/Views/Cliente/Compras.cshtml", vendas);
        }
    }
}
