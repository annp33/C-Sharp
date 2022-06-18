/*
 * Desenvolva um código que pergunte quanto você tem para a passagem. 
 * Se esse valor for menor do que R$ 10,00, imprima “Vá de ônibus”. 
 * Se o valor for menor do que R$ 50,00, imprima “Vá de táxi”. Se
 * o valor for menor do que R$ 150,00, imprima “Vá de avião”. Se o valor
 * for menor do que R$ 500,00, imprima “Vá de helicóptero”. Se o valor for
 * superior a R$ 500,00, imprima “Vá de navio”.
 */

using System;

namespace passagem_transporte
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor;

            do{
            Console.WriteLine("\nQuanto você tem para passagem?");
            valor = float.Parse(Console.ReadLine());
            }while(valor < 0);

            if(valor < 4.5f)
                Console.WriteLine("\nVá a pé!\n");
            else if(valor >=3 && valor < 10f)
                Console.WriteLine("\nVá de ônibus!\n");
            else if(valor >= 10f && valor < 50f)
                Console.WriteLine("\nVá de táxi!\n");
            else if(valor >=50f && valor < 150f )
                Console.WriteLine("\nVá de avião!\n");
            else if(valor >=150f && valor < 500f )
                Console.WriteLine("\nVá de helicóptero!\n");
            else
                Console.WriteLine("\nVá de navio!\n");
        }
    }
}
