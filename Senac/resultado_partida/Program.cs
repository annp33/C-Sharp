/*
 * Desenvolva um código que leia o nome de dois times e o número de
 * gols marcados na partida (para cada time). O nome do vencedor deverá 
 * ser escrito. Caso não haja um, deverá ser impressa a palavra “empate”.
 */

using System;

namespace resultado_partida
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome_time1, nome_time2;
            int gols_time1, gols_time2;
            
            Console.WriteLine("\nEntre com o nome do time da casa: ");
            nome_time1 = Console.ReadLine();
            
            Console.WriteLine("Entre com o número de gols marcados pelo "+nome_time1);
            gols_time1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com o nome do time visitante: ");
            nome_time2 = Console.ReadLine();
            
            Console.WriteLine("Entre com o número de gols marcados pelo "+nome_time2);
            gols_time2 = int.Parse(Console.ReadLine());

            if(gols_time1 > gols_time2){
                Console.WriteLine("\n"+nome_time1+" venceu!\n");
            }else if(gols_time1 < gols_time2){
                Console.WriteLine("\n"+nome_time2+" venceu!\n");
            }else{
                Console.WriteLine("\nEmpate!\n");
            }
        }
    }
}
