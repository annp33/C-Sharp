/* 

Universidade Federal de Uberlândia - UFU
Faculdade de Computação - FACOM
Lista de exercícios de programação em linguagem C
Exercícios: Vetores e Matrizes

21. Faça um programa que receba do usuario dois vetores, A e B, 
com 10 numeros inteiros cada. Crie um novo vetor denominado C 
calculando C = A - B. Mostre na tela os dados do vetor C.

*/

using System;

class UFU_Lista04_21{
    static void Main(){
        int [] vetorA = new int [10];
        int [] vetorB = new int [10];
        int [] vetorC = new int [10];

        Console.Write("\n");

        for(int i=0; i<vetorA.Length; i++){
            Console.Write("Entre com o {0}º elemento do vetor A: ", i+1);
            vetorA[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\n");

        for(int i=0; i<vetorB.Length; i++){
            Console.Write("Entre com o {0}º elemento do vetor B: ", i+1);
            vetorB[i] = int.Parse(Console.ReadLine());
            vetorC[i] = vetorA[i] - vetorB[i];
        }

        Console.Write("\nVetor C: ");

        foreach(int num in vetorC){
            Console.Write("{0} ", num);
        }

        Console.Write("\n\n");
    }
}