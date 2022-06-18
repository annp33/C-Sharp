/*
 * Desenvolva um programa C# que informe a idade e calcule o número de dias
 */

using System;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, dias;
            
            Console.WriteLine("\nQual é a sua idade (em anos)?");
            idade = int.Parse(Console.ReadLine());

            dias = idade*365;

            Console.WriteLine("\nVocê está há, aproximadamente, "+dias+" dias na Terra!\n");
        }
    }
}
