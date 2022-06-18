/*
 * Faça um algoritmo que some o conteúdo de dois vetores e armazene o resultado em um terceiro vetor.
*/

using System;

namespace soma_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA; // declaração do vetor
            int[] vetorB;
            int[] vetorSoma;
            int tamanho;

            Console.Write("\nEntre com o tamanho dos vetores A e B: ");
            tamanho = int.Parse(Console.ReadLine());

            vetorA = new int[tamanho]; //instanciação do vetor
            vetorB = new int[tamanho];
            vetorSoma = new int[tamanho];

            Console.Write("\n");

            for(int i=0; i<tamanho; i++){
                Console.Write("Entre com o valor do {0}º elemento do vetor A: ", i+1);
                vetorA[i]= int.Parse(Console.ReadLine());      
            }

            Console.Write("\n");

            for(int i=0; i<tamanho; i++){
                Console.Write("Entre com o valor do {0}º elemento do vetor B: ", i+1);
                vetorB[i]= int.Parse(Console.ReadLine());      
            }

            Console.Write("\nA + B = [");

            for(int i=0; i<tamanho; i++){
                vetorSoma[i] = vetorA[i] + vetorB[i];
                Console.Write(" "+vetorSoma[i]);
            }

            Console.WriteLine(" ]\n");
            
        }
    }
}
