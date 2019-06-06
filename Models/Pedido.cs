using System;

namespace Portfolio_Ponto_Digital.Models
{
    public class Pedido
    {
        public int Id {get;set;}
        public Cliente Cliente {get;set;}
        public Plano Plano{get;set;}
        public DateTime DataPedido {get;set;}
        public double PrecoTotal {get;set;}

    }
}