using Microsoft.AspNetCore.Mvc;
using Marketplace.Models.Repositories;
using Marketplace.Models.Views;
using System.Collections.Generic;

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
    
        public IActionResult Index()
        {
            var homeView = new HomeView();
            homeView.Categorias = _categoriaRepository.Read();
            homeView.ProdutosGroup = new List<ProdutoGroup>();
            var produtos = _produtoRepository.Read();
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
            return View(homeView);
        }
    }
}