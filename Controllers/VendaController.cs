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
        public static CarrinhoView carrinhoView = new CarrinhoView();        
        public static List<Produto> ProdutosCarrinho { get; set; }

        public VendaController(IProdutoRepository produtoRepository, IVendaRepository vendaRepository, IUsuarioRepository usuarioRepository)
        {
            _produtoRepository = produtoRepository;
            _vendaRepository = vendaRepository;
            _usuarioRepository = usuarioRepository;
            ProdutosCarrinho = new List<Produto>();
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Finaliza Venda";
            return View("~/Views/Empresa/Venda/Carrinho.cshtml");
        }

        public IActionResult Adicionar(Guid id)
        {
            var produto = _produtoRepository.Read(id);
            ProdutosCarrinho.Add(produto);
            foreach (var prod in ProdutosCarrinho)
            {
                carrinhoView.valorTotal = (decimal)(carrinhoView.valorTotal + prod.Valor);
            }            
            carrinhoView.ProdutosCart = ProdutosCarrinho;
            return View("~/Views/Empresa/Venda/Carrinho.cshtml", carrinhoView);
        }

        [HttpPost]
        public IActionResult FinalizaVenda()
        {
            var venda = new Venda();
            var vendaItem = new VendaItem();
            foreach (var produto in carrinhoView.ProdutosCart)
            {
                Produto produtos =  _produtoRepository.Read(produto.Id);
                vendaItem.Produto = produto;
                vendaItem.Quantidade = carrinhoView.quantidade;
                venda.Itens.Add(vendaItem);
                venda.Empresa = produto.Empresa;
            }
            venda.valorTotalVenda = carrinhoView.valorTotal;
            venda.DataVenda = DateTime.Today;
            venda.FormaPagamento = carrinhoView.FormaPagamento;
            var cliente = _usuarioRepository.Read(new Guid(Request.Cookies["Id"]));
            venda.Cliente = (Cliente)cliente;
            _vendaRepository.Create(venda);

            return View("/");
        }

    }
}