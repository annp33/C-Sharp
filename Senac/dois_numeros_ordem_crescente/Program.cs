/*
 * Desenvolva um código que leia dois valores inteiros positivos e que os
 * imprima em ordem crescente.
 */

using System;

namespace dois_numeros_ordem_crescente
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, maior=0, menor=0;

            do{
            Console.WriteLine("\nEntre com um número inteiro positivo: ");
            num1 = int.Parse(Console.ReadLine());
            }while(num1 < 0);

            do{
            Console.WriteLine("Entre com outro número inteiro positivo: ");
            num2 = int.Parse(Console.ReadLine());
            }while(num2 < 0);

            if(num1 > num2 || num1 == num2){
                maior = num1;
                menor = num2;
            }else{
                maior = num2;
                menor = num1;
            }

            Console.WriteLine("\n"+menor+" < "+maior+"\n");
        }
    }
}
