/*
 * Analise um vetor de dez posições e atribua o valor 0 para todos os
 * elementos que contiverem valores negativos.
*/

using System;

namespace vetor_valores_negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[10]; // declaração e instanciação o objeto vetor
            int[] vetorB = new int[10]; 

            Console.Write("\n");

            for(int i=0; i<10; i++){
                Console.Write("Entre com o {0}º elemento do vetor: ", i+1);
                vetorA[i] = int.Parse(Console.ReadLine());

                if(vetorA[i] < 0){
                    vetorB[i] = 0;
                }else{
                    vetorB[i] =vetorA[i];
                }
            }

            Console.Write("\nVetor original: [");

            for(int i=0; i<10; i++){
                Console.Write(" "+ vetorA[i]); 
            }

            Console.Write("]\n\nVetor modificado: [");
                        
            for(int i=0; i<10; i++){
                Console.Write(" "+ vetorB[i]); 
            }

            Console.WriteLine(" ]\n");

        }
    }
}
