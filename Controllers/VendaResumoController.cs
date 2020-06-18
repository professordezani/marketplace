using System;
using System.Collections.Generic;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
{
    public class VendaResumoController : Controller
    {
        private readonly IVendaRepository _vendaRepository;
        private readonly IFuncionarioRepository _funcionarioRepository;

        public VendaResumoController(IVendaRepository vendaRepository, IFuncionarioRepository funcionarioRepository)
        {
            _vendaRepository = vendaRepository;
            _funcionarioRepository = funcionarioRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Venda Resumo";
            var Vendas = _vendaRepository.ReadByEmpresa();
            return View("~/Views/Empresa/Venda/VendaResumo.cshtml", Vendas);
        }
    }
}