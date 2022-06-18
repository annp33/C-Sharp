using System;
using System.Collections.Generic; 

namespace PedidosRestaurante
{
    public class Pedido
    {
        private static List<ItemPedido> itens;
        
        public Pedido()
        {
           itens = new List<ItemPedido>();
        }

        // Este método não pode ser do tipo "static", assim ele pode ser acessado com uma variável de instância.
        public void AdicionarItem(ItemPedido item) 
        {
            itens.Add(item); 
        }

        public double ValorPedido()
        {
            double total = 0;
            
            foreach(var item in itens){
                total = total + (item.valor_unitario * item.quantidade);
            }

            return total;
        }

    }
}