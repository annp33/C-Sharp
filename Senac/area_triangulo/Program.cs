/*Desenvolva um programa C# que leia base e altura e que calcule a
 *área de um triângulo. Lembre: área = (base x altura)/2.
 */

using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            float baset, altura, area;

            Console.WriteLine("\nEntre com a base do triângulo: ");
            baset = float.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com a altura do triângulo: ");
            altura = float.Parse(Console.ReadLine());

            area = (baset*altura)/2;

            Console.WriteLine("\nA área do triângulo é igual a: "+area+"\n");

        }
    }
}
