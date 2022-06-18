using System;
using System.Collections.Generic; 

namespace PedidosRestaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            string finaliza_pedido = "N";
            double total_pedido;
            
            Pedido novo_pedido = new Pedido();
           
            do{

                string descricao;
                double valor_unitario;
                int quantidade;

                Console.Write("\nEntre com a descrição do item: "); 
                descricao = Console.ReadLine();

                Console.Write("\nEntre com o valor unitário desse item: ");
                valor_unitario = double.Parse(Console.ReadLine());

                Console.Write("\nEntre com a quantidade desse item: "); 
                quantidade = int.Parse(Console.ReadLine());

                ItemPedido novo_item = new ItemPedido(descricao, valor_unitario, quantidade);

                novo_pedido.AdicionarItem(novo_item); 
                
                Console.Write("\n\nDigite S para sair ou N para incluir um novo item ao pedido: ");
                finaliza_pedido = Console.ReadLine(); 

            }while(finaliza_pedido == "N" || finaliza_pedido == "n"); 

            total_pedido = novo_pedido.ValorPedido();

            Console.WriteLine("\n\nO total do pedido é de " + total_pedido +" reais. \n\n");

        }
    }
}
