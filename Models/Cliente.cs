using System;

namespace Portfolio_Ponto_Digital.Models
{
    public class Cliente
    {
        public int Id {get; set;}
        public string Nome{get; set;}
        public ulong CPF{get;set;}
        public DateTime DataNascimento {get;set;}
        public string Cargo{get;set;}
        public string Endereco {get;set;}
        public string Email {get;set;}
        public string Telefone {get;set;}
        public string Senha{get;set;}


    }
}