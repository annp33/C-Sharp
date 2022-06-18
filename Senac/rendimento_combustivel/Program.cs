/*
 * Sabendo que um automóvel faz 12 km/l, desenvolva um programa C# que informe uma 
 * distância e que retorne a quantidade de litros de combustível necessária para percorrê-la.
 */

using System;

namespace rendimento_combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int rendimento=12;
            double distancia, combustivel;

            Console.WriteLine("\nEntre com uma distância em km:");
            distancia = double.Parse(Console.ReadLine());

            combustivel = distancia/rendimento;

            Console.WriteLine("\nA quantidade de combustível necessária para percorrer "+distancia+" km é igual a "+combustivel+" litros.\n");
        }
    }
}
