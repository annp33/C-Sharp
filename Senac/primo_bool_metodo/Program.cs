/*
 * Em um projeto em C#, programe um método que receba por parâmetro um valor inteiro e 
 * positivo e retorne o valor bool “true”, se o valor for primo, e “false”, caso contrário.
 * Um número primo é um número natural (inteiro positivo) divisível por 1 e por ele mesmo. 
 * O número 1 não é considerado um número primo, porque ele só tem um divisor. 
*/

using System;

namespace numero_bool_metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool retorno;

            Console.Write("\nDigite um número: ");
            n = int.Parse(Console.ReadLine());

            retorno = Primo(n);

            Console.WriteLine("\nO número é primo: {0}\n", retorno);
        }

        static bool Primo(int num)
        {
            int contador=2, cont=0;
            bool primo;
            
            while(contador < num){
                if(num % contador == 0){
                    cont++; // é incrementado a cada vez que o número for divisível pelo contador
                }
                contador++;
            }

            if(cont == 0 && num > 1) 
                primo = true;
            else
                primo = false;

            return primo;
        }
        
    }
}
