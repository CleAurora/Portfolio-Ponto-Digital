using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Ponto_Digital.Repositorios;
using Portfolio_Ponto_Digital.ViewModels;

namespace Portfolio_Ponto_Digital.Controllers
{
    public class AdministradorController: Controller
    {
        [HttpGet]
          public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Comentarios = ComentarioRepositorio.ListarComentarios();
            homeViewModel.Clientes = ClienteRepositorio.ListarClientes();

            ViewData["ViewName"]= "Administrador";
            return View(homeViewModel);
        }

        
        public IActionResult ListarComentarios(){
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Comentarios = ComentarioRepositorio.ListarComentarios();
            homeViewModel.Clientes = ClienteRepositorio.ListarClientes();
            return View(homeViewModel);
        }

        public IActionResult ListarClientes(){
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Comentarios = ComentarioRepositorio.ListarComentarios();
            homeViewModel.Clientes = ClienteRepositorio.ListarClientes();
            return View(homeViewModel);
        }

        public IActionResult BuscarComentarios(IFormCollection form){
            HomeViewModel homeViewModel = new HomeViewModel();
            string status = form["status"];

            if(string.IsNullOrEmpty(status))
            {
                return RedirectToAction("ListarComentarios");
            }else{
                homeViewModel.Comentarios = ComentarioRepositorio.Filtrar(status);
            }
            homeViewModel.Comentarios = ComentarioRepositorio.ListarComentarios();
            return View(homeViewModel);
                    
        }

        public IActionResult AtualizarComentario(IFormCollection form){
            int id = int.Parse(form["comentarioId"]); 
            string status = form["status"];

            ComentarioRepositorio.AtualizarStatusComentario(id, status);

            return RedirectToAction ("Index", "Administrador");
        }

    }
}