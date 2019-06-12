using System;

namespace Portfolio_Ponto_Digital.Models
{
    public class ComentarioModel
    {
        public int Id{get;set;}
        public ClienteModel Pessoa {get; set;}
        public string Comentario{get;set;}
        public DateTime DataEntrada{get;set;}
        public string Status{get;set;}

        public ComentarioModel(ClienteModel pessoa, string comentario){
            this.Pessoa = new  ClienteModel();
            this.Pessoa = pessoa;
            this.Comentario = comentario;
        }

        public ComentarioModel()
        {
        }
    }
}