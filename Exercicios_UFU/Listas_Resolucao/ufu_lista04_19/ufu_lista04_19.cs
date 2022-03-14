/* 

Universidade Federal de Uberlândia - UFU
Faculdade de Computação - FACOM
Lista de exercícios de programação em linguagem C
Exercícios: Vetores e Matrizes

19. Faça um vetor de tamanho 50 preenchido com o seguinte valor: 
(i + 5*i) % (i + 1), sendo i a posição do elemento no vetor. Em 
seguida imprima o vetor na tela.

*/

using System;
using System.Collections.Generic;

class UFF_Lista04_19{
    static void Main(){
        int [] num = new int[50];

        for(int i=0; i<num.Length; i++){
           num[i] = (i+(5*i)) % (i+1);
        }

        Console.Write("\n");

        foreach(int n in num){
            Console.Write("{0} ",n);
        }

        Console.Write("\n\n");

    }
}