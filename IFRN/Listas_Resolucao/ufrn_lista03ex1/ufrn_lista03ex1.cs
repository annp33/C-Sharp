/*

IFRN - Instituto Federal de Educação, Ciência e Tecnologia do Rio Grande do Norte
Curso Técnico em Informática
Disciplina: Programação Orientada a Objetos

Lista de Exercícios 3

Questão 1 - Construa a classe Filme em Java, que obedeça à descrição abaixo:

Filme
- titulo: String
- duracaoEmMinutos: int
+ getTitulo(): String
+ setTitulo(String): void
+ getDuracaoEmMinutos(): int
+ setDuracaoEmMinutos(int): void
+ exibirDuracaoEmHoras(): void
+ Filme(String, int)

- A classe deve possuir dois atributos privados: titulo (do tipo String) e duracaoEmMinutos (do tipo int)
- Crie um construtor para a classe que recebe 2 parâmetros, cada um representando um dos atributos da
classe.
- Crie os métodos de acesso (get e set) para os atributos titulo e duracaoEmMinutos
- Crie um método exibirDuracaoEmHoras que converta o valor em minutos para horas e apresente a
mensagem “O filme TITULO possui X horas e Y minutos de duração”. Por exemplo, dado o filme com título Titanic que possui 194 minutos de duração, a mensagem que deverá ser exibida para o usuário será:
“O filme Titanic possui 3 horas e 14 minutos de duração”


Crie uma classe TestarFilme que possua um método main de modo que seja possível testar a classe Filme criada na questão anterior.

- Crie um objeto umFilmeQualquer do tipo Filme. Utilize o construtor da classe passando os valores “Os
Vingadores”, para o atributo título, e 142 para o atributo duracaoEmMinutos.
- Chame o método exibirDuracaoEmHoras() para mostrar quantas horas o filme possui.
- Crie um objeto meuFilmeFavorito do tipo Filme, cujo título deve ser o título do seu filme favorito e a
duração deve ser iniciada em 100 minutos.
- Altere o atributo duracaoEmMinutos do objeto meuFilmeFavorito para a duração correta do filme.
- Chame o método exibirDuracaoEmHoras() do objeto meuFilmeFavorito para mostrar quantas
horas/minutos o filme possui.
- Exiba a mensagem: “Os filmes no catálogo são X e Y”, onde no lugar de X, deverá aparecer o título do
umFilmeQualquer e no lugar de Y deverá aparecer o título do meuFilmeFavorito.

*/

using System;
class Filme{
    private string titulo;
    private int duracaoEmMinutos;

    public Filme(string titulo, int duracaoEmMinutos){
        this.titulo = titulo;
        this.duracaoEmMinutos = duracaoEmMinutos;
    }

    public void setTitulo(string nome){
        titulo = nome;
    }

    public string getTitulo(){
        return titulo;
    }

    public void setDuracaoEmMinutos(int duracao){
        duracaoEmMinutos = duracao;
    }

    public int getDuracaoEmMinutos(){
        return duracaoEmMinutos;
    }

    public void exibirDuracaoEmHoras(){
        int horas = getDuracaoEmMinutos()/60;
        int minutos = getDuracaoEmMinutos()%60;

        Console.WriteLine("O filme \"{0}\" possui {1} horas e {2} minutos de duração.\n", getTitulo(), horas, minutos);
    }
}

class TestarFilme{
    static void Main(){
        
        Filme umFilmeQualquer = new Filme("Os Vingadores", 142);
        Console.Write("\n");
        umFilmeQualquer.exibirDuracaoEmHoras();
        
        Filme meuFilmeFavorito = new Filme("O Parque dos Dinossauros", 100);
        meuFilmeFavorito.setDuracaoEmMinutos(127);
        meuFilmeFavorito.exibirDuracaoEmHoras();

        Console.WriteLine("Os filmes no catálogo são \"{0}\" e \"{1}\".\n\n", umFilmeQualquer.getTitulo(), meuFilmeFavorito.getTitulo());

    }
}
