using System;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;
using Marketplace.Models.Views;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;            
        }        

        public IActionResult Index()
        {
            
            return View();
        }
        
        [HttpGet]
        public IActionResult Create()
        {
             return View();
        }

        [HttpPost]
        public IActionResult Create(Usuario model)
        {         
             return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            return View();
        }
    }
}