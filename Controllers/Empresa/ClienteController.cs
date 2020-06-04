using System;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers.Empresa
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(Cliente model)
        {                        
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View(new Cliente());
        }

        [HttpPost]
        public IActionResult Create(Cliente model)
        {
             if(!ModelState.IsValid)
                return View(model);

            model.Id = Guid.NewGuid();

            _clienteRepository.Create(model);

            return RedirectToAction("Login");
        }

        [HttpGet]
         public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Cliente cliente)
        {
            return View();
        }
    }
}