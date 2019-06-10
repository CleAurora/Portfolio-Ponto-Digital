using System.Collections.Generic;
using System.IO;
using Portfolio_Ponto_Digital.Models;

namespace Portfolio_Ponto_Digital.Repositorios
{
    public class PlanosRepositorio
    {
        public List<PlanoModel> Listar(){
            List<PlanoModel> listaDePlanos = new List<PlanoModel>();
            string[] linhas = File.ReadAllLines("Database/Plano.csv");
            PlanoModel plano;

            foreach (var item in linhas)
            {
                if(string.IsNullOrEmpty(item))
                {
                    continue;
                }
                string[]linha = item.Split(";");
                plano = new PlanoModel(
                    id: int.Parse(linha[0]),
                    nome: linha[1],
                    preco: linha[2]
                );
                listaDePlanos.Add(plano);
            }
            return listaDePlanos;
        }//fim listar
    }
}