using System.Collections.Generic;
using System.IO;
using Portfolio_Ponto_Digital.Models;

namespace Portfolio_Ponto_Digital.Repositorios
{
    public class ClienteRepositorio: BaseRepositorio
    {
       
        public ClienteModel CadastrarCliente (ClienteModel cliente){
            if(File.Exists("clientes.csv")){
                cliente.Id = File.ReadAllLines("clientes.csv").Length +1;
            }else{
                cliente.Id = 1;
            }

            StreamWriter sw = new StreamWriter("clientes.csv");
            sw.WriteLine($"{cliente.Id};{cliente.Nome};{cliente.CPF};{cliente.DataNascimento};{cliente.Cargo};{cliente.Endereco};{cliente.Email};{cliente.Telefone};{cliente.Senha}");
            sw.Close();

            return cliente;

        }//fim cadastrar
        
        

    }
}