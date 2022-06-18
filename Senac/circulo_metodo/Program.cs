/* Crie um programa que contenha um método para realizar o cálculo da área de um círculo. 
 * A área é definida pela fórmula A = π * R². O usuário informará o valor do raio (R). 
 * Considere π igual a 3,14.
*/

using System;

namespace circulo_metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area, comprimento;

            Console.Write("\nEntre com o raio da circunferência: ");
            raio = double.Parse(Console.ReadLine());
            
            area = AreaCirculo(raio);
            comprimento = ComprimentoCirculo(raio);

            Console.WriteLine($"\nA área da circunferência de raio {raio} é: "+ area);
            Console.WriteLine($"\nO comprimento da circunferência de raio {raio} é: " + comprimento);   
            Console.WriteLine("\n");         
        }

        static double AreaCirculo(double r)
        {   
            double area;

            area = Math.PI * (r * r);

            return area;
        }

        static double ComprimentoCirculo(double r)
        {   
            double comprimento;

            comprimento = 2 * Math.PI * r;

            return comprimento;
        }
    }
}
