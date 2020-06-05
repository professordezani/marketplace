using System;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Marketplace.Controllers.Empresa
{
    public class DetalheProdutoController : Controller
    {

        private readonly IProdutoRepository _produtoRepository;
        public List<Produto> ProdutosCarrinho;

        public DetalheProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public IActionResult Index(Guid id)
        {
            ViewBag.Title = "Detalhe Produto";
            var produto = _produtoRepository.Read((Guid)id);
            return View("~/Views/Empresa/Venda/DetalheProduto.cshtml", produto);
        }

        [HttpGet]
        public ActionResult AdicionarProduto(Produto produto)
        {
            ProdutosCarrinho.Add(produto);
            return View("~/Views/Empresa/Venda/Carrinho.cshtml", ProdutosCarrinho);
        }

    }
}