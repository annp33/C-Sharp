using System;

namespace PedidosRestaurante
{
    public class ItemPedido
    {   
      
        public string descricao;
        public double valor_unitario;
        public int quantidade;

        public ItemPedido(string d, double v, int q) 
        {
            descricao = d;
            valor_unitario = v;
            quantidade = q;    
        }
    }
}