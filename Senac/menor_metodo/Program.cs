/* Crie um programa que defina um vetor de números inteiros e um método para encontrar 
 * o menor valor nesse vetor. O vetor precisará ser passado por parâmetro. 
 * O programa deve mostrar o menor valor na tela.
*/

using System;

namespace menor_metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor;
            int num;

            Console.Write("\nEntre com o número de elementos do vetor: ");
            num = int.Parse(Console.ReadLine());

            vetor = new int[num];

            Console.WriteLine("\n");

            for(int i=0; i < num; i++){
                Console.Write("Entre com o {0}º elemento do vetor: ", i+1);
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int menor = MenorNumero(vetor);

            Console.WriteLine("\nO menor número é: "+ menor + "\n");

        }

        static int MenorNumero(int[] vetorB)
        {
            int menor = vetorB[0];

            for(int i=0; i < vetorB.Length; i++){ // "vetorB.Length" - retorn o tamanho do vetor "vetorB"
                    if(vetorB[i] < menor)
                        menor = vetorB[i];                        
            }
            return menor;
        }
        
    }
}
