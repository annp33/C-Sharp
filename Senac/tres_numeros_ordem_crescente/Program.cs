/*
 * Desenvolva um código que leia três valores e que os
 * imprima em ordem crescente.
 */

using System;

namespace tres_numeros_ordem_crescente
{
    class Program
    {
        static void Main(string[] args)
        { 
            float num1, num2, num3, menor=0, medio=0, maior=0;

            Console.WriteLine("\nEntre com três números:");
            num1 = float.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());
            num3 = float.Parse(Console.ReadLine());

            if(num1 >= num2 && num1 >= num3){
                maior = num1;

                if(num2 > num3){
                    medio = num2;
                    menor = num3;
                }else{
                    medio = num3;
                    menor = num2;
                }

            }else if(num2 >= num1 && num2 >= num3){
                maior = num2;

                if(num1 > num3){
                    medio = num1;
                    menor = num3;
                }else{
                    medio = num3;
                    menor = num1;
                }
            }else{
                maior = num3;

                if(num1 > num2){
                    medio = num1;
                    menor = num2;
                }else{
                    medio = num2;
                    menor = num1;
                }
            }

            Console.WriteLine("\n"+menor+" < "+medio+" < "+maior+"\n");
        }
    }
}
