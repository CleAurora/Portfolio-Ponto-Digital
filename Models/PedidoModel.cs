using System;

namespace Portfolio_Ponto_Digital.Models
{
    public class PedidoModel
    {
        public int Id {get;set;}
        public ClienteModel Cliente {get;set;}
        public PlanoModel Plano{get;set;}
        public DateTime DataPedido {get;set;}
        public double PrecoTotal {get;set;}

    }
}