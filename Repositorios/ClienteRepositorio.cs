using System;
using System.Collections.Generic;
using System.IO;
using Portfolio_Ponto_Digital.Models;

namespace Portfolio_Ponto_Digital.Repositorios {
    public class ClienteRepositorio : BaseRepositorio {

        const string CLIENTES_PATH = "Database/Clientes.csv";

        private static List<ClienteModel> ListaDeClientes = new List<ClienteModel> ();
        public static List<ClienteModel> ListarClientes () {
            string[] clientes = File.ReadAllLines (CLIENTES_PATH);
            foreach (var item in clientes) {
                if (item != null) {
                    string[] dados = item.Split (";");
                    var cliente = new ClienteModel ();

                    cliente.Id = int.Parse (dados[0]);
                    cliente.Nome = dados[1];
                    cliente.CPF = dados[2];
                    cliente.DataNascimento = DateTime.Parse (dados[3]);
                    cliente.Cargo = dados[4];
                    cliente.Endereco = dados[5];
                    cliente.Email = dados[6];
                    cliente.Telefone = dados[7];
                    cliente.Senha = dados[8];

                    ListaDeClientes.Add (cliente);
                }
            }
            return ListaDeClientes;
        } //fim listar

        public static ClienteModel ObterPor (string email) {
            var listaDeClientes = ListarClientes ();

            if (email != null) {
                foreach (var item in listaDeClientes) {

                        if (item.Email.Equals (email)) {
                            return item;
                        }
                    }

            }
            return null;
        }

        public static void Inserir (ClienteModel cliente) {
            if (!File.Exists (CLIENTES_PATH)) {
                File.Create (CLIENTES_PATH).Close ();
            }
            ListaDeClientes = ListarClientes ();
            cliente.Id = ListaDeClientes == null ? 1 : ListaDeClientes.Count + 1;
            File.AppendAllText (CLIENTES_PATH, $"{cliente.Id};{cliente.Nome};{cliente.CPF};{cliente.DataNascimento};{cliente.Cargo};{cliente.Endereco};{cliente.Email};{cliente.Telefone};{cliente.Senha}\n");
        }

    }
}