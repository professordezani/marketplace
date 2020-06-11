using Microsoft.AspNetCore.Mvc;
using System;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Marketplace.Controllers {
    public class ProdutoController : Controller {

        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository) {
          _produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            ViewBag.User = Request.Cookies["Nome"];
            ViewBag.Title = "Produtos";
            var produtos = _produtoRepository.Read();
            return View("~/Views/Empresa/Produto/Index.cshtml", produtos);
        }

        public IActionResult Save(Guid? id)
        {
           ViewBag.Title = "Produto";
           var produto = new Produto();
           if(id.HasValue){
             produto =_produtoRepository.Read((Guid)id);
           }
           return View("~/Views/Empresa/Produto/Save.cshtml", produto);
        }

        [HttpPost]
        public IActionResult Save(Produto produto, List<IFormFile> files){
            if(!ModelState.IsValid) {
               return View("~/Views/Empresa/Produto/Save.cshtml", produto);
            }            
            foreach (var file in files)
            {
               if (file.Length > 0)
               {
                  using (var ms = new MemoryStream())
                  {
                    file.CopyTo(ms);
                    produto.Imagem = ms.ToArray();
                  }
               }
            }
            
            if(produto.Id == Guid.Empty){
              _produtoRepository.Create(produto);
            } else{
              _produtoRepository.Update(produto);
            }

            return RedirectToAction("Index");
        }
    }
}