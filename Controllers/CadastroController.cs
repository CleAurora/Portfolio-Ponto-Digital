using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Ponto_Digital.Models;
using Portfolio_Ponto_Digital.Repositorios;
using Portfolio_Ponto_Digital.ViewModels;

namespace Portfolio_Ponto_Digital.Controllers
{
    public class CadastroController: Controller
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        private PlanosRepositorio planoRepositorio = new PlanosRepositorio();

        [HttpGet]
        public IActionResult Index()
        {
            var planosRecuperados = planoRepositorio.Listar();

            ClienteViewModel cliente = new ClienteViewModel();

            cliente.planos = planosRecuperados;

            
            ViewData["ViewName"] = "Cadastro";
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form){

            ClienteModel cliente = new ClienteModel(
                nome:           form["nome"],
                cpf:            form["CPF"],
                dataNascimento: DateTime.Parse(form["dataNascimento"]),
                cargo:          form["cargo"],
                endereco:       form["endereco"],
                email:          form["email"],
                telefone:       form["telefone"],
                senha:          form["senha"]
            );
            
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            return RedirectToAction("Index", "Cliente");
        }//fim Cadastrar
    }
}