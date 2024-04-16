
using System;

// Classe base para representar um aluno
class Aluno
{
    public string Nome { get; set; }
    public int RA { get; set; }

    // Construtor da classe Aluno
    public Aluno(string nome, int ra)
    {
        Nome = nome;
        RA = ra;
    }

    // Método para exibir informações do aluno
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"RA: {RA}");
    }
}

// Classe que herda de Aluno e representa um aluno específico
class MeuAluno : Aluno
{
    public MeuAluno() : base("Lucas Matheus ",856082) { }
}

class Program
{
    static void Main()
    {
        // Criando um objeto da classe MeuAluno
        MeuAluno meuAluno = new MeuAluno();

        // Exibindo as informações do aluno
        meuAluno.ExibirInformacoes();

        Console.ReadLine();
    }
}