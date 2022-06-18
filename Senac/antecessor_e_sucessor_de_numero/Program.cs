/*
 * Desenvolva um programa C# que informe um número e que mostre seu antecessor e seu sucessor.
 */
using System;

namespace antecessor_e_sucessor_de_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, antecessor, sucessor;

            Console.WriteLine("\nEntre com um número inteiro:");
            num = int.Parse(Console.ReadLine());
            
            antecessor = num - 1; 
            
            sucessor = num + 1;

            Console.WriteLine("\n"+antecessor+" é o antecessor de "+num+" e "+sucessor+" é o seu sucessor\n");

            
        }
    }
}
