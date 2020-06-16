using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
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
            ViewBag.User = Request.Cookies["Nome"];   
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

            /*var password = model.Senha;

            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8));

            model.Senha = hashed;            */

            _clienteRepository.Create(model);

            return RedirectToAction("Login");
        }

        [HttpGet]
         public IActionResult Update()
        {
            ViewBag.User = Request.Cookies["Nome"];   
            var cliente = _clienteRepository.Read(new Guid(Request.Cookies["Id"]));
            return View(cliente);
        }
        [HttpPost]
        public IActionResult Update(Cliente cliente)
        {
            _clienteRepository.Update(cliente);
            return RedirectToAction("Index");
        }
    }
}