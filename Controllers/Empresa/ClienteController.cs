using Marketplace.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers.Empresa
{
    public class ClienteController : Controller
    {
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
        public IActionResult Create(Cliente cliente)
        {
            return View();
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