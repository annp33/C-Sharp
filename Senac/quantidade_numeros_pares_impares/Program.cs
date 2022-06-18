/*
* Desenvolva um código que leia um conjunto de números e imprima a quantidade de números
* pares e a quantidade de números ímpares lidos. A leitura deve acontecer consecutivamente
* até que o usuário digite o número 9999. Neste caso, o programa encerra mostrando as 
* quantidades calculadas.
*/

using System;

namespace quantidade_numeros_pares_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, somaPares=0, somaImpares=0;

            do{

                Console.Write("\nDigite um número inteiro ou 9999 para sair: ");
                num = int.Parse(Console.ReadLine());

                if(num%2 == 0){
                    somaPares++;
                }else if(num != 9999){
                    somaImpares++; // não contabiliza o número 9999.
                }

            }while(num != 9999);

            Console.WriteLine("\nPares: " + somaPares + " números");
            Console.WriteLine("Ímpares: " + somaImpares + " números\n\n");
        }
    }
}
