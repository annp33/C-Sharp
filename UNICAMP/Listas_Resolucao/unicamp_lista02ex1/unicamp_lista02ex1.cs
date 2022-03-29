/*

MC302 – Programação Orientada a Objetos
Instituto de Computação - Universidade Estadual de Campinas
Lista de Exercícios 02 - Classes

Questão 1 - Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina. 
Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome, 2 notas de 
prova e 1 nota de trabalho. Escreva os seguintes métodos para esta classe:
- media: calcula a média final do aluno (cada prova tem peso 2,5 e o trabalho tem peso 2).
- final: calcula quanto o aluno precisa para a prova final (retorna zero se ele não for 
para a final).

*/

using System;

class AlunosMatriculados{
    public string nome, matricula;
    public double prova1, prova2, trabalho;

    public AlunosMatriculados(string aluno, string alunoMat){
        nome =  aluno;
        matricula = alunoMat;    
    }

    public double Media(){
        double media = prova1*0.25 + prova2*0.25 + trabalho*0.2;
        return media;
    }

    public double Final(double alunoMed){
        double provaFinal;

        if(alunoMed >= 5){
            provaFinal = 0;
        }else{
            provaFinal = (5 - alunoMed*0.7)/0.3;
        }

        return provaFinal;
    }
}

class unicamp_lista02ex1{
    static void Main(){

        string []nomeAlu = new string[3];
        string []matriculaAlu = new string[3];

        for(int i=0; i<nomeAlu.Length; i++){
            Console.Write("\nEntre com o nome do aluno {0}: ", i+1);
            nomeAlu[i] = Console.ReadLine();

            Console.Write("Entre com a matrícula do aluno: ");
            matriculaAlu[i] = Console.ReadLine();
        }

        AlunosMatriculados aluno1 = new AlunosMatriculados(nomeAlu[0], matriculaAlu[0]);
        AlunosMatriculados aluno2 = new AlunosMatriculados(nomeAlu[1], matriculaAlu[1]);
        AlunosMatriculados aluno3 = new AlunosMatriculados(nomeAlu[2], matriculaAlu[2]);

        aluno1.prova1 = 3.4;
        aluno1.prova2 = 2.1;
        aluno1.trabalho = 4;

        aluno2.prova1 = 8.2;
        aluno2.prova2 = 9.0;
        aluno2.trabalho = 7.5;

        aluno3.prova1 = 5.6;
        aluno3.prova2 = 7.8;
        aluno3.trabalho = 6;

        
        Console.WriteLine("\nAluno: {0}\nMatrícula: {1}\nProva 1: {2}\nProva 2: {3}\nTrabalho: {4}\nMédia: {5}\nProva Final: {6}", aluno1.nome, aluno1.matricula, aluno1.prova1, aluno1.prova2, aluno1.trabalho, aluno1.Media(), aluno1.Final(aluno1.Media()));
        
        if(aluno1.Final(aluno1.Media()) > 10)
            Console.Write("**REPROVADO(A)**\n");

        Console.WriteLine("\nAluno: {0}\nMatrícula: {1}\nProva 1: {2}\nProva 2: {3}\nTrabalho: {4}\nMédia: {5}\nProva Final: {6}", aluno2.nome, aluno2.matricula, aluno2.prova1, aluno2.prova2,aluno2.trabalho, aluno2.Media(), aluno2.Final(aluno2.Media()));

        if(aluno2.Final(aluno2.Media()) > 10)
            Console.Write("\n**REPROVADO(A)**\n");

        Console.WriteLine("\nAluno: {0}\nMatrícula: {1}\nProva 1: {2}\nProva 2: {3}\nTrabalho: {4}\nMédia: {5}\nProva Final: {6}\n\n", aluno3.nome, aluno3.matricula, aluno3.prova1, aluno3.prova2, aluno3.trabalho, aluno3.Media(), aluno3.Final(aluno3.Media()));

        if(aluno3.Final(aluno3.Media()) > 10)
            Console.Write("**REPROVADO(A)**\n");

    }
}