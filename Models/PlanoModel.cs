namespace Portfolio_Ponto_Digital.Models
{
    public class PlanoModel
    {
        public int Id{get;set;}
        public string Nome{get;set;}
        public string Preco{get;set;}

        public PlanoModel(int id, string nome, string preco){
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}