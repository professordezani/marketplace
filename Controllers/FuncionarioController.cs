using Microsoft.AspNetCore.Mvc;
using System;
using Marketplace.Models.Repositories;
using Marketplace.Models.Entidades;

namespace Marketplace.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;         
        public FuncionarioController(IFuncionarioRepository funcionarioRepository){
            _funcionarioRepository = funcionarioRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Funcionários";
            ViewBag.User = Request.Cookies["Nome"];
            var id = new Guid(Request.Cookies["Id"]);
            var funcionario = _funcionarioRepository.Read(id);
            var funcionarios = _funcionarioRepository.ReadByEmpresa(funcionario.Empresa.Id);
            return View("~/Views/Empresa/Funcionario/Index.cshtml", funcionarios);
        }    

        public IActionResult Save(Guid? id)
        {
            ViewBag.Title = "Funcionário";
            ViewBag.User = Request.Cookies["Nome"];
            var funcionario = new Funcionario();
            if(id.HasValue){
               funcionario = _funcionarioRepository.Read((Guid)id);
            }
            return View("~/Views/Empresa/Funcionario/Save.cshtml", funcionario);
        }

        [HttpPost]
        public IActionResult Save(Funcionario funcionario){              
            if (funcionario.Id != Guid.Empty && string.IsNullOrEmpty(funcionario.Senha)){
                ModelState.Remove("Senha");
            }

            if(!ModelState.IsValid){
                ViewBag.Title = "Funcionário";
                ViewBag.User = Request.Cookies["Nome"];
                return View("~/Views/Empresa/Funcionario/Save.cshtml", funcionario);
            }
            
            if(funcionario.Id == Guid.Empty){
                var id = new Guid(Request.Cookies["Id"]);
                var user = _funcionarioRepository.Read(id);
                funcionario.Empresa = user.Empresa;
               _funcionarioRepository.Create(funcionario);
            } else {
                var funcionarioBd = _funcionarioRepository.Read(funcionario.Id);
                funcionarioBd.Nome = funcionario.Nome;
                funcionarioBd.Email = funcionario.Email;
                funcionarioBd.Senha = !string.IsNullOrEmpty(funcionario.Senha) ?
                                                            funcionario.Senha : 
                                                            funcionarioBd.Senha;
               _funcionarioRepository.Update(funcionarioBd);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id){
            _funcionarioRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}