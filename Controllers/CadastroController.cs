using Microsoft.AspNetCore.Mvc;
using Portfolio_Ponto_Digital.Repositorios;

namespace Portfolio_Ponto_Digital.Controllers
{
    public class CadastroController: Controller
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
    }
}