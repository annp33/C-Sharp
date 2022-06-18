/*
 * Utilizando List<Cliente>, faça um programa no qual o usuário poderá cadastrar clientes em uma lista.
 * Na aplicação, forneça as opções “incluir”, “listar” e “sair”. O programa usará um laço que termina 
 * só quando o usuário digitar o comando “sair”. O comando “inserir” criará um novo objeto “Cliente” e 
 * o preencherá com dados de nome e idade informados pelo usuário. Em seguida, o objeto será adicionado 
 * à lista. O comando “listar” percorrerá a lista e usará o método Cliente.MostraDados() para mostrar os
 * clientes cadastrados.
*/

using System;
using System.Collections.Generic;

namespace lista_clientes
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "s";

            Cliente cliente = new Cliente();

            do{

                string nome;
                int idade;

                Console.Write("\nDigite: \nI - para incluir um novo cliente \nL - para listar os clientes cadastrados \nS - para sair\n");
                opcao = Console.ReadLine();   

                switch(opcao){
                    case "I" or "i":
                        Console.Write("\nDigite o nome do cliente: ");
                        nome = Console.ReadLine();
                        Console.Write("Digite a idade do cliente: ");
                        idade = int.Parse(Console.ReadLine()); 

                        DadosCliente dados_cliente = new DadosCliente(nome, idade);
                     
                        cliente.Incluir(dados_cliente);
                    break;

                    case "L" or "l":
                        Console.Write("\n");
                        cliente.ListarDados();
                        break;

                    case "S" or "s":
                        Console.Write("\n** Encerrando Programa **\n\n");
                    break;

                    default:
                        Console.Write("\nOPÇÃO INVÁLIDA!\n\n");
                    break;
                }
            
            }while(opcao != "s" && opcao != "S");
        }
    }
}
