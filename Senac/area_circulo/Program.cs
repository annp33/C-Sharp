/*
* Desenvolva um programa C# que informe o raio de um círculo e que 
* calcule sua área. Lembre: área = 3.14 x raio^2.
*/

using System;

namespace area_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area;

            Console.WriteLine("\nEntre com o raio do círculo: ");
            raio = double.Parse(Console.ReadLine());            
            
            area = 3.14 * (raio*raio);

            Console.WriteLine("\nA área do círculo de raio "+raio+" é igual a "+area+".\n");
        }
    }
}
