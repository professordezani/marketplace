using System.Collections.Generic;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;
using Marketplace.Models.Views;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository, ICategoriaRepository categoriaRepository)
        {
            _usuarioRepository = usuarioRepository;
            _categoriaRepository = categoriaRepository;
        }        

        public IActionResult Index()
        {
            /*var homeView = new HomeView();
            homeView.Categorias = _categoriaRepository.Read();  */
            
            return View();
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            List<Categoria> categorias = _categoriaRepository.Read();

            ViewBag.Title = "Novo Usuário";

            var usuario = new Usuario();            

            return View(usuario);
        }

        [HttpPost]
        public IActionResult Create(Usuario usuario)
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