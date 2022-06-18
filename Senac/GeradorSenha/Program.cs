using System;

namespace GeradorSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int anoNascimento, idade;

            Console.WriteLine("\nEntre com o seu nome: ");
            nome = Console.ReadLine();

            nome = nome.Replace(" ",""); //exclui os espaços vazios da string

            Console.WriteLine("\nEntre com o seu ano de nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());

            idade = 2021 - anoNascimento;

            if (idade <= 18)
            {
                Console.WriteLine("\nSua senha é: "+nome+""+idade+"\n");
            }else{
                Console.WriteLine("\nSua senha é: "+idade+""+nome+"\n");
            }

        }
    }
}
