using System;
using System.Collections.Generic;
using System.IO;
using Portfolio_Ponto_Digital.Models;

namespace Portfolio_Ponto_Digital.Repositorios
{
    public class ComentarioRepositorio
    {
        const string COMENTARIOS_PATH = "Database/Comentarios.csv";

        private static List<ComentarioModel> ListaDeComentarios = new List<ComentarioModel>();
        // private static List<ComentarioModel> ListaDeComentariosAprovados = new List<ComentarioModel>();

        public static List<ComentarioModel> ListarComentarios(){
            string[] comentarios = File.ReadAllLines(COMENTARIOS_PATH);
            foreach (var item in comentarios)
            {
                if(item != null){
                    string[] dados = item.Split(";");
                    var comentario = new ComentarioModel();

                    comentario.Id = int.Parse(dados[0]);
                    ClienteModel Pessoa = new ClienteModel();
                    Pessoa.Nome = dados[1];
                    comentario.Pessoa = Pessoa;
                    comentario.Comentario = dados[2];
                    comentario.DataEntrada = DateTime.Parse(dados[3]);
                    comentario.Status = dados[4];

                    ListaDeComentarios.Add(comentario);
                }
            }
            return ListaDeComentarios;
        }//fim listar comentário

        public static void Inserir (ComentarioModel comentario){
            if(!File.Exists(COMENTARIOS_PATH)){
                File.Create(COMENTARIOS_PATH).Close();
            }
            ListaDeComentarios = ListarComentarios();
            comentario.Id = ListaDeComentarios == null ? 1 : ListaDeComentarios.Count + 1;
            comentario.DataEntrada = DateTime.Now;
            comentario.Status = "Aguardando";
            File.AppendAllText (COMENTARIOS_PATH, $"{comentario.Id};{comentario.Pessoa.Nome};{comentario.Comentario};{comentario.DataEntrada};{comentario.Status}");
        }


        public List<ComentarioModel> Filtrar(string status){
            List<ComentarioModel> listaFiltrada = new List<ComentarioModel>();
            List<ComentarioModel> listaDeComentarios = ListarComentarios();

            foreach (var item in listaDeComentarios )
            {
                if(item.Status.Equals("status")){
                    listaFiltrada.Add(item);
                }else{
                    continue;
                }
            }//fim foreach
            return listaFiltrada;
        }//fim filtrar

        
    }
}