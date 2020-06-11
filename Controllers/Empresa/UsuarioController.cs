using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Marketplace.Models.Views;
using Marketplace.Models.Entidades;
using Marketplace.Models.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers.Empresa
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
        public IActionResult Login()
        {            
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(LoginView model)        
        {     
            if(! (model.Email != "" && model.Senha != ""))
                return View(model);

            var usuario =  _usuarioRepository.Login(model.Email, model.Senha);

            if(usuario != null)
            {         

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, model.Email)
                };

                var identity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var props = new AuthenticationProperties{
                    IsPersistent = true
                };
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal,props).Wait();

                Response.Cookies.Append("Id", usuario.Id.ToString());                
                Response.Cookies.Append("Nome", usuario.Nome);

                if(usuario is Cliente) {
                    return RedirectToAction("Index", "Cliente");
                } else {
                    return RedirectToAction("Index", "Produto");
                }                
            }
            else{
               return View(model);
            }                
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
