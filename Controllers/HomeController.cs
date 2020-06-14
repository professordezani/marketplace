using Microsoft.AspNetCore.Mvc;
using Marketplace.Models.Repositories;
using Marketplace.Models.Views;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Marketplace.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IProdutoRepository _produtoRepository;

        public HomeController(ICategoriaRepository categoriaRepository, IProdutoRepository produtoRepository){
            _categoriaRepository = categoriaRepository;
            _produtoRepository = produtoRepository;
        }
    
        public IActionResult Index(Guid? id)
        {
            var homeView = new HomeView();
            homeView.Categorias = _categoriaRepository.Read();
            homeView.ProdutosGroup = new List<ProdutoGroup>();
            var produtos = _produtoRepository.ReadDisponivel(id);
            var produtoGroup = new ProdutoGroup();
            var contador = 0;
            foreach(var produto in produtos){
                contador++;
                produtoGroup.Produtos.Add(produto);
               
                if(produtoGroup.Produtos.Count == 6 || contador == produtos.Count){
                    homeView.ProdutosGroup.Add(produtoGroup);
                    produtoGroup = new ProdutoGroup();
                }    
            }         

            if (id.HasValue){
               var categoria = homeView.Categorias.FirstOrDefault(x => x.Id == id);
               ViewBag.Title = categoria.Descricao;
            } else {
                ViewBag.Title = "Home";
            }
              
            return View(homeView);
        }

        public IActionResult Detail(Guid id){
            ViewBag.Title = "Produto";
            var homeView = new HomeView();
            homeView.Categorias = _categoriaRepository.Read();
            homeView.ProdutoDetail = _produtoRepository.Read(id);
            return View("~/Views/Home/Detail.cshtml", homeView);
        }
    }
}