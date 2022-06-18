/*
 * Analise um vetor de dez posições e verifique se existem valores iguais e os escreva.
*/

using System;

namespace vetor_valores_iguais
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[10];
            int contador=0;

            Console.Write("\n");

            for(int i=0; i<10; i++){

                do{
                    Console.Write("Entre com o {0}º elemento do vetor diferente de zero: ", i+1);
                    vetorA[i] = int.Parse(Console.ReadLine());
                }while(vetorA[i] == 0);
            }

            Console.Write("\nValores repetidos: [");
            
            for(int i=0; i<10; i++){
                for(int j=0; j<10; j++){
                    if((vetorA[i] == vetorA[j]) && (j > i) && (vetorA[i] != 0)){
                        vetorA[j]=0;
                        contador++;
                    }
                }

                if(contador !=0){
                    Console.Write(" " + vetorA[i]);
                }

                contador=0;   
            }       

            Console.Write(" ]\n\n");

        }
    }
}
