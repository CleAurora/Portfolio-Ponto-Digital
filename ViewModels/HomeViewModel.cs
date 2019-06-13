using System.Collections.Generic;
using Portfolio_Ponto_Digital.Models;

namespace Portfolio_Ponto_Digital.ViewModels
{
    public class HomeViewModel
    {
        public List<ClienteModel> Clientes {get;set;}
        public List<ComentarioModel> Comentarios {get;set;}
    }
}