using System;
using System.Collections.Generic;
using System.Linq;

namespace lista_clientes
{
    public class Cliente
    {
        private static List<DadosCliente> dados;

        public Cliente()
        {
           dados = new List<DadosCliente>();
        }
        
        public void Incluir(DadosCliente dado) 
        {
            dados.Add(dado); 
        }

        public void ListarDados()
        {
            foreach (var dado in dados)
            {
                Console.WriteLine("Nome: "+ dado.nome +" Idade: "+ dado.idade);
            }
        }
    }
}