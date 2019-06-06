using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Ponto_Digital.Controllers
{
    public class AvaliacaoController: Controller
    {
         public IActionResult Index()
        {
            ViewData["ViewName"] = "Avaliacao"; 
            return View();
        }
    }
}