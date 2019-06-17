using System.Collections.Generic;
using Portfolio_Ponto_Digital.Models;

namespace Portfolio_Ponto_Digital.ViewModels
{
    public class HomeViewModel
    {
        public List<ClienteModel> Clientes {get;set;}
        public List<ComentarioModel> Comentarios {get;set;}

        public int ClientesCadastrados {
            get { return Clientes.Count; }
        }

        public int ComentariosCadastrados {
            get { return Comentarios.Count; }
        }

        public int ComentariosAprovados {
            get { return Comentarios.FindAll(comentario => comentario.Status == "Aprovado").Count; }
        }

        public int ComentariosReprovados {
            get { return Comentarios.FindAll(comentario => comentario.Status == "Reprovado").Count; }
        }
    }
}