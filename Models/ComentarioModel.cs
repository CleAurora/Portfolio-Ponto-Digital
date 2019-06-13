using System;
using Microsoft.Extensions.Primitives;

namespace Portfolio_Ponto_Digital.Models
{
    public class ComentarioModel
    {

        public int Id {get;set;}
        public ClienteModel Pessoa {get;set;}
        public string Comentario {get;set;}
        public string Status {get;set;}
        public DateTime DataEntrada {get;set;}
        public ComentarioModel(ClienteModel pessoa, StringValues comentario)
        {
            Pessoa = pessoa;
            Comentario = comentario;
        }

        public ComentarioModel()
        {
        }
    }
}