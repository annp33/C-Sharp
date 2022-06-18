/*
 * Desenvolva um código que pergunte “Qual é a cor (VERDE/AMARELO/VERMELHO)?”. 
 * Se for escolhida a cor VERDE, imprima “Siga em frente”; se for escolhida a 
 * opção AMARELO, imprima “Atenção”; e, se for escolhido VERMELHO, imprima “Pare”. 
 * Se tirarmos o desvio condicional de múltipla escolha, este item teria que sair do
 * desafio, não? Avalie.
 */

using System;

namespace semaforo_cores
{
    class Program
    {
        static void Main(string[] args)
        {
            string cor;
            Console.WriteLine("\nQual é a cor (VERDE/AMARELO/VERMELHO)?");
            cor = Console.ReadLine();

            switch(cor){
                case "VERDE": 
                    Console.WriteLine("\nSiga em frente!\n");
                break;

                case "AMARELO": 
                    Console.WriteLine("\nAtenção!\n");
                break;

                case "VERMELHO":
                    Console.WriteLine("\nPARE!\n");
                break;

                default:
                    Console.WriteLine("\nOpção Inválida!\n");
                break;

            }
        }
    }
}
