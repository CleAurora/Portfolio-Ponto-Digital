using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Ponto_Digital.Controllers
{
    public class ComoUsarController: Controller
    {
        public IActionResult Index()
        {
            ViewData["ViewName"] = "ComoUsar";
            return View();
        }
    }
}