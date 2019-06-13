using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Ponto_Digital.Models;
using Portfolio_Ponto_Digital.Repositorios;

namespace Portfolio_Ponto_Digital.Controllers {
    public class ClienteController : Controller {
        // private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";
        public IActionResult Index () {
            ViewData["User"] = HttpContext.Session.GetString (SESSION_EMAIL);
            ViewData["ViewName"] = "Cliente";
            return View ();
        }

        public IActionResult Login (IFormCollection form) {
            var usuario = form["email"];
            var senha = form["senha"];

            var cliente = ClienteRepositorio.ObterPor (usuario);
            System.Console.WriteLine (cliente);

            if (cliente != null && cliente.Senha.Equals (senha) && cliente.Tipo.Equals("comum")) {
                HttpContext.Session.SetString (SESSION_EMAIL, usuario);
                HttpContext.Session.SetString (SESSION_CLIENTE, cliente.Nome);
                Console.WriteLine ("BBB" + cliente.Nome);


                return RedirectToAction ("Index", "Cliente");

            } else if(cliente != null && cliente.Senha.Equals (senha) && cliente.Tipo.Equals("Administrador")) {
                HttpContext.Session.SetString (SESSION_EMAIL, usuario);
                HttpContext.Session.SetString (SESSION_CLIENTE, cliente.Nome);
                Console.WriteLine ("BBB" + cliente.Nome);

                return RedirectToAction ("Index", "Administrador");
                
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

        [HttpPost]
        public IActionResult EnviarComentario (IFormCollection form) {

            var pessoa = ClienteRepositorio.ObterPor(HttpContext.Session.GetString(SESSION_EMAIL));
            ComentarioModel comentario = new ComentarioModel (pessoa ,comentario : form["comente"]);
            ComentarioRepositorio.Inserir (comentario);
            return RedirectToAction ("Index", "Home");
        } //fim enviar comentário
    }
}