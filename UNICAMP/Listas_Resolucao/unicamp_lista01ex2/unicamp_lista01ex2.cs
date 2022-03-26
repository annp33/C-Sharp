/*

MC302 – Programação Orientada a Objetos
Instituto de Computação - Universidade Estadual de Campinas
Lista de Exercícios 01 - Estruturas de Programação, Funções e Vetores

Questão 2 - Escreva um programa que leia o nome e salário atual de um funcionário. O programa deve calcular
seu novo salário (segundo a tabela abaixo) e mostrar o nome, o salário atual e o salário reajustado do
funcionário:

|  Faixa salarial  | Acréscimo |
| acima de |  até  |           |
|    --    |  150  |    25%    |
|   150    |  300  |    20%    |
|   300    |  600  |    15%    |
|   600    |  --   |    10%    |

- repita o processo acima até que seja digitado FIM no lugar do nome do funcionário;
- mostrar ao final do programa a soma dos salários atuais, a soma dos salários reajustados e a
diferença entre eles.

*/

using System;

class unicamp_lista01ex2{
    static void Main(){
        string nome="funcionario";
        double salarioAtual, salarioReajustado=0, somaAtuais=0, somaReajustados=0, diferenca;

        do{
            Console.Write("\nEntre com o nome do funcionário ou digite FIM para sair: ");
            nome = Console.ReadLine();

            if((nome!="FIM") && (nome!="fim") && (nome!="Fim")){

                Console.Write("Entre com o salário atual do funcionário: ");
                salarioAtual = double.Parse(Console.ReadLine());

                if((salarioAtual > 0) && (salarioAtual <= 150)){
                    salarioReajustado = salarioAtual + salarioAtual*0.25;

                }else if((salarioAtual > 150) && (salarioAtual <= 300)){
                    salarioReajustado = salarioAtual + salarioAtual*0.20;

                }else if((salarioAtual > 300) && (salarioAtual <= 600)){
                    salarioReajustado = salarioAtual + salarioAtual*0.15;

                }else if(salarioAtual > 600){
                    salarioReajustado = salarioAtual + salarioAtual*0.10;

                }else{
                    Console.WriteLine("\nSalário Inválido!");
                }

                if(salarioAtual > 0){
                    Console.WriteLine("\nNome do funcionário: {0}\nSalário Atual: {1:c}\nSalário Reajustado: {2:c}\n", nome, salarioAtual, salarioReajustado);

                    somaAtuais += salarioAtual;

                    somaReajustados += salarioReajustado; 
                }

            }
            
        }while((nome!="FIM") && (nome!="fim") && (nome!="Fim"));

        diferenca = somaReajustados - somaAtuais;

        Console.WriteLine("\nSoma dos salários atuais: {0:c}\nSoma dos salários reajustados: {1:c}\nDiferença: {2:c}\n", somaAtuais, somaReajustados, diferenca);

    }
}