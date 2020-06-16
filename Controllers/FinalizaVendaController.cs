
using System;
using Marketplace.Models.Entidades;
using Marketplace.Models.Views;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
{
    public class FinalizaVenda : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Finaliza Venda";
            return View("~/Views/Empresa/Venda/FinalizaVenda.cshtml");
        }

        [HttpPost]
        public IActionResult Save(CarrinhoView carrinhoView)
        {
            // var venda = new Venda();
            // var vendaItem = new VendaItem();
            Console.WriteLine(carrinhoView.valorTotal);
            // foreach (var produto in carrinhoView.ProdutosCarrinho)
            // {
            //     vendaItem.Produto = produto;
            //     vendaItem.Quantidade = carrinhoView.quantidade;
            //     venda.Itens.Add(vendaItem);
            // }
            // venda.valorTotalVenda = carrinhoView.valorTotal;
            // venda.DataVenda = DateTime.Today;
            //venda.Empresa = 
            //venda.FormaPagamento = 
            //venda.Cliente = 

            return View("");
        }
    }
}