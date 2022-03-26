/*

MC302 – Programação Orientada a Objetos
Instituto de Computação - Universidade Estadual de Campinas
Lista de Exercícios 01 - Estruturas de Programação, Funções e Vetores

Questão 1 - Escreva um programa que carregue dois valores A e B pelo teclado e imprima todos os números
ímpares entre A e B.

*/

using System;

class unicamp_list01ex1{
    static void Main(){
        int numA, numB, impar=0;

        Console.Write("Entre com um valor inteiro para A: ");
        numA = int.Parse(Console.ReadLine());

        Console.Write("Entre com um valor inteiro para B: ");
        numB = int.Parse(Console.ReadLine());        
        
        Console.Write("\n");

        if((numA < numB) && ((numA%2) == 0)){
            impar = numA + 1;
            if((numA != numB) && ((numA-numB) != 1) && ((numA-numB) != -1))
                    Console.Write("{0} ", impar);
        }else if ((numA > numB) && ((numA%2) == 0)){
            impar = numA - 1;
            if((numA != numB) && ((numA-numB) != 1) && ((numA-numB) != -1))
                    Console.Write("{0} ", impar);        
        }else{
                impar = numA;
        }   

        if((numA < numB) && ((numA-numB) != 1) && ((numA-numB) != -1)){
            while(impar < numB-2){
                impar += 2;
                Console.Write("{0} ", impar);
            }
        }else if((numA > numB) && ((numA-numB) != 1) && ((numA-numB) != -1)){
            while(impar > numB+2){
                impar -= 2;
                Console.Write("{0} ", impar);
            }
        }else{
            Console.WriteLine("Não há números ímpares entre A e B");
        }

        Console.Write("\n\n");

    }
}

