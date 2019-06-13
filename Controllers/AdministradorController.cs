using Microsoft.AspNetCore.Mvc;
using Portfolio_Ponto_Digital.Repositorios;
using Portfolio_Ponto_Digital.ViewModels;

namespace Portfolio_Ponto_Digital.Controllers
{
    public class AdministradorController: Controller
    {
        HomeViewModel homeViewModel = new HomeViewModel();

        [HttpGet]
          public IActionResult Index()
        {
            homeViewModel.Comentarios = ComentarioRepositorio.ListarComentarios();
            homeViewModel.Clientes = ClienteRepositorio.ListarClientes();

            ViewData["ViewName"]= "Adminisrador";
            return View(homeViewModel);
        }

        
        public IActionResult ListarComentarios(){
            homeViewModel.Comentarios = ComentarioRepositorio.ListarComentarios();
            homeViewModel.Clientes = ClienteRepositorio.ListarClientes();
            return View(homeViewModel);
        }

        // public IActionResult BuscarComentarios(IFormCollection form){
        //     strin
        // }

    }
}