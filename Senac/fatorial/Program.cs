/* 
* Desenvolva um código que leia um número inteiro e devolva o fatorial deste 
* (por exemplo: fatorial de 5 é igual a 5 x 4 x 3 x 2 x 1).
*/

using System;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, fatorial = 1;

            Console.Write("\nEntre com o valor de n: ");
            n = int.Parse(Console.ReadLine());

            for(int contador = 1; contador <= n; contador++){

                fatorial = fatorial * contador;
            }

            Console.WriteLine("\n" + n + "! = " + fatorial + "\n\n");
        }
    }
}
