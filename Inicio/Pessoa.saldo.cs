using System;

class Pessoa
{
    public string nome;
    public int idade;

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Ola, meu nome é {nome} e tenho {idade} de idade");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa("Pedro", 15);
        Pessoa pessoa2 = new Pessoa("Julio", 20);

        pessoa1.Apresentar();
        pessoa2.Apresentar();
    }
}
