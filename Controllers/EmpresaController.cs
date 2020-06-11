using Marketplace.Models.Repositories;
using Marketplace.Models.Views;
using Microsoft.AspNetCore.Mvc;
using Marketplace.Models.Entidades;
using System;

namespace Marketplace.Controllers {
    public class EmpresaController : Controller {
   
        private readonly IEmpresaRepository _empresaRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public EmpresaController(IEmpresaRepository empresaRepository, ICategoriaRepository categoriaRepository) {
            _empresaRepository = empresaRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult Index(){            
            ViewBag.Title = "Empresa";
            var cadastroEmpresaView = new CadastroEmpresaView();
            cadastroEmpresaView.Categorias = _categoriaRepository.Read();
            return View("~/Views/Usuario/CadastroEmpresa.cshtml", cadastroEmpresaView);
        }

        [HttpPost]
        public IActionResult Create(CadastroEmpresaView cadastroEmpresaView){

            var empresa = new Empresa {
               Id = new Guid(),
               RazaoSocial = cadastroEmpresaView.RazaoSocial,
               NomeFantasia = cadastroEmpresaView.NomeFantasia,
               Cnpj = cadastroEmpresaView.Cnpj,
               Categoria = _categoriaRepository.Read(cadastroEmpresaView.Categoria)
            };

            var funcionario = new Funcionario {
                Id = new Guid(),   
                Ativo = true,
                Principal = true,                  
                Empresa = empresa,              
                Email = cadastroEmpresaView.Email,
                Senha = cadastroEmpresaView.Senha,
                Nome = cadastroEmpresaView.NomeFantasia               
            };

            _empresaRepository.Create(empresa, funcionario); 

            return View("~");           
        }
    }    
}