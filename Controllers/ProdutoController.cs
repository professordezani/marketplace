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
        private readonly IFuncionarioRepository _funcionarioRepository;

        public ProdutoController(IProdutoRepository produtoRepository, IFuncionarioRepository funcionarioRepository) {
          _produtoRepository = produtoRepository;
          _funcionarioRepository = funcionarioRepository;
        }

        public IActionResult Index()
        {            
            ViewBag.Title = "Produtos";
            ViewBag.User = Request.Cookies["Nome"];
            var id = new Guid(Request.Cookies["Id"]);
            var funcionario = _funcionarioRepository.Read(id);
            var produtos = _produtoRepository.ReadByEmpresa(funcionario.Empresa.Id);
            return View("~/Views/Empresa/Produto/Index.cshtml", produtos);
        }

        public IActionResult Save(Guid? id)
        {
           ViewBag.Title = "Produto";
           ViewBag.User = Request.Cookies["Nome"];
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

            var id = new Guid(Request.Cookies["Id"]);
            var funcionario = _funcionarioRepository.Read(id);
            produto.Empresa = funcionario.Empresa;
            
            if(produto.Id == Guid.Empty){
              _produtoRepository.Create(produto);
            } else{
              _produtoRepository.Update(produto);
            }

            return RedirectToAction("Index");
        }
    }
}