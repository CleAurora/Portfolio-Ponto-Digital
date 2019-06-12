using System;

namespace Portfolio_Ponto_Digital.Models
{
    public class ClienteModel
    {
        public int Id {get; set;}
        public string Nome{get; set;}
        public string CPF{get;set;}
        public DateTime DataNascimento {get;set;}
        public string Cargo{get;set;}
        public string Endereco {get;set;}
        public string Email {get;set;}
        public string Telefone {get;set;}
        public string Senha{get;set;}
        public string tipo {get;set;}

        public ClienteModel(int id, string nome, string cpf, DateTime dataNascimento, string cargo, string endereco, string email, string telefone, string senha){
            this.Id = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.DataNascimento = dataNascimento;
            this.Cargo = cargo;
            this.Endereco = endereco;
            this.Email = email;
            this.Telefone = telefone;
            this.Senha = senha;

        }

         public ClienteModel(string nome, string cpf, DateTime dataNascimento, string cargo, string endereco, string email, string telefone, string senha){
            this.Nome = nome;
            this.CPF = cpf;
            this.DataNascimento = dataNascimento;
            this.Cargo = cargo;
            this.Endereco = endereco;
            this.Email = email;
            this.Telefone = telefone;
            this.Senha = senha;

        }

        public ClienteModel(){}

        public ClienteModel(string nome)
        {
            Nome = nome;
        }
    }
}