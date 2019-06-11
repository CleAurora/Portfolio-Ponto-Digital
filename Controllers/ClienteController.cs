using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Ponto_Digital.Repositorios;

namespace Portfolio_Ponto_Digital.Controllers {
    public class ClienteController : Controller {
        // private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";
        public IActionResult Index () {
            ViewData["ViewName"] = "Cliente";
            return View ();
        }

        public IActionResult Login (IFormCollection form) {
            var usuario = form["email"];
            var senha = form["senha"];

            
            var cliente = ClienteRepositorio.ObterPor (usuario);
            
            if (cliente != null && cliente.Senha.Equals (senha)) {
                HttpContext.Session.SetString (SESSION_EMAIL, usuario);
                HttpContext.Session.SetString (SESSION_CLIENTE, cliente.Nome);
                Console.WriteLine("BBB"+cliente.Nome);

                return RedirectToAction ("Index", "Cliente");
            }else{
                

            return RedirectToAction ("Index", "Home");
            }

        }

        public IActionResult Logout () {
            HttpContext.Session.Remove (SESSION_EMAIL);
            HttpContext.Session.Remove (SESSION_CLIENTE);
            HttpContext.Session.Clear ();

            return RedirectToAction ("Index", "Home");
        }
    }
}