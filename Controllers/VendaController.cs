using System;
using System.Collections.Generic;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;
using Marketplace.Models.Views;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
{
    public class VendaController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IVendaRepository _vendaRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public VendaController(IProdutoRepository produtoRepository, IVendaRepository vendaRepository, IUsuarioRepository usuarioRepository,
        ICategoriaRepository categoriaRepository)
        {
            _produtoRepository = produtoRepository;
            _vendaRepository = vendaRepository;
            _usuarioRepository = usuarioRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Finaliza Venda";
            var homeView = new HomeView();
            homeView.Categorias = _categoriaRepository.Read();
            return View("~/Views/Empresa/Venda/Carrinho.cshtml");
        }
    }
}