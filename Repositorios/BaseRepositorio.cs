using System.IO;

namespace Portfolio_Ponto_Digital.Repositorios
{
    public class BaseRepositorio
    {
         protected string[] ObterRegistrosCSV (string PATH) {
            return File.ReadAllLines (PATH);
        }

        protected string ExtrairCampo (string nomeCampo, string linha) {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf(chave);
            var indiceTerminal = linha.IndexOf(";", indiceChave);
            var valor = "";
            
            if (indiceTerminal != -1) {
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            } else {
                valor = linha.Substring(indiceChave);
            }
            
            
            System.Console.WriteLine($"Campo[{nomeCampo}] e valor {valor}");
            return valor.Replace(nomeCampo + "=", "");
        }
    }
}