using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Ponto_Digital.Controllers
{
    public class ContribuicaoController: Controller
    {
        public IActionResult Index()
        {
            ViewData["ViewName"]="Contribuicao";
            return View();
        }
    }
}