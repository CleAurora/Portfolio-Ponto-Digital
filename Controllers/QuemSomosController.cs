using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Ponto_Digital.Controllers
{
    public class QuemSomosController: Controller
    {
        public IActionResult Index()
        {
            ViewData["ViewName"]= "QuemSomos";
            return View();
        }
    }
}