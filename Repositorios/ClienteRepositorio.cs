using System.Collections.Generic;
using System.IO;
using Portfolio_Ponto_Digital.Models;

namespace Portfolio_Ponto_Digital.Repositorios
{
    public class ClienteRepositorio: BaseRepositorio
    {
        public static uint CONT = 0;
        private const string PATH = "Database/Cliente.csv";
        private const string PATH_INDEX = "Database/Cliente_Id.csv";
        private List<Cliente> clientes = new List<Cliente> ();

        public ClienteRepositorio()
        {
            if (!File.Exists(PATH_INDEX)){
                File.Create(PATH_INDEX).Close();
            }

            var ultimoIndice = File.ReadAllText(PATH_INDEX);
            uint indice = 0;
            uint.TryParse(ultimoIndice, out indice);
            CONT = indice;
        }

        
        }

    }
}