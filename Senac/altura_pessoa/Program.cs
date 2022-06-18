/*
 * Desenvolva um código que leia a altura de uma pessoa. Deverá
 * imprimir “Alto” se a altura for maior que 1,80 ou igual; caso 
 * contrário, deverá imprimir “Baixo”.
 */

using System;

namespace altura_pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura;

            Console.WriteLine("\nEntre com a sua altura (em metros): ");
            altura = float.Parse(Console.ReadLine());

            if(altura > 1.80f)
                Console.WriteLine("\nAlto\n");
            else
                Console.WriteLine("\nBaixo\n");
        }
    }
}
