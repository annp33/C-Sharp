// Desenvolva um código que imprima os números menores que 101 em ordem decrescente.

using System;

namespace numeros_ordem_decrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int contador=100; contador>=0; contador--){
            Console.WriteLine(contador);
            }
        }
    }
}
