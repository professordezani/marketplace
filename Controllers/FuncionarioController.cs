using System.Collections.Generic;
using Marketplace.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Funcionários";
            List<Funcionario> lista = new List<Funcionario>();   
            Funcionario funcionario = new Funcionario();
            lista.Add(funcionario);

            return View(lista);
        }      
        
        [HttpGet]
        public IActionResult Create()
        {           
            return View("~/Views/Funcionario/Create.cshtml");
        }      

        [HttpPost]
        public IActionResult Create(Funcionario model)
        {         
            //TODO   
            return RedirectToAction("Create");
        }      
        [HttpGet]
        public IActionResult Update(string id)
        {           
            return View(new Funcionario());
        }      

        [HttpPost]
        public IActionResult Update(string id, Funcionario model)
        {         
            //TODO   
            return RedirectToAction("/");
        }      

        

          
    }
}