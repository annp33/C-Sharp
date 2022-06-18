/*
* Desenvolva um código que leia o nome e o tempo de dez cavalos e traga o nome e o tempo 
* dos cavalos mais rápidos.
*/

using System;

namespace corrida_cavalos
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            float tempo, tempo1, tempo2;
            string cavalo, cavalo1, cavalo2;

            Console.Write("\nEntre com o nome do "+ contador +"º cavalo: ");
            cavalo = Console.ReadLine();

            cavalo1 = cavalo;
            cavalo2 = cavalo;

            Console.Write("Entre com o tempo do "+ contador + "º cavalo: ");
            tempo = float.Parse(Console.ReadLine());

            tempo1 = tempo;
            tempo2 = tempo;

            contador++;

            while(contador <= 5){

                Console.Write("\nEntre com o nome do "+ contador +"º cavalo: ");
                cavalo = Console.ReadLine();

                Console.Write("Entre com o tempo do "+ contador + "º cavalo: ");
                tempo = float.Parse(Console.ReadLine());

                if(tempo < tempo1){
                    cavalo2 = cavalo1; 
                    cavalo1 = cavalo;
                    
                    tempo2 = tempo1;             
                    tempo1 = tempo;
                }
                else if(tempo <= tempo2){
                    cavalo2 = cavalo;
                    tempo2 = tempo;
                }

                contador++;
            }

            Console.WriteLine("\n**CAVALOS MAIS RÁPIDOS**\n1º lugar: Cavalo "+cavalo1+" - Tempo "+tempo1+"\n2º lugar: Cavalo "+cavalo2+" - Tempo "+tempo2+"\n\n");
            
        }
    }
}
