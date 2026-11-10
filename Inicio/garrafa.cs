
using System;

class Garrafa
{
    public string nome;
    private double quantidade = 0;
    private double capacidade;

    public Garrafa(string nome, double capacidade)
    {
        this.nome = nome;
        Capacidade = capacidade;
    }

    public double Capacidade
    {
        get { return capacidade; }

        set
        {
            if (value > 0)
            {
                capacidade = value;
            }
        }
    }

    public void Encher(double ml)
    {
        if (ml > 0)
        {
            quantidade += ml;

            if (quantidade > capacidade)
            {
                quantidade = capacidade;
            }
        }
    }

    public bool Beber(double ml)
    {
        if (ml > 0 && ml <= quantidade)
        {
            quantidade -= ml;
            return true;
        }

        return false;
    }

    public bool EstaVazia()
    {
        return quantidade == 0;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Capacidade: {capacidade}");
        Console.WriteLine($"Quantidade: {quantidade}");
    }
}

class Program
{
    static void Main()
    {
        Garrafa garrafa = new Garrafa("Água", 500);

        Console.WriteLine("Deseja encher ou beber? Qual o valor? (ex: beber 20)");
        string input = Console.ReadLine();

        try
        {
            string[] partes = input.Split(' ');
            double valor = double.Parse(partes[1]);

            if (partes[0] == "encher")
            {
                garrafa.Encher(valor);
            }
            else if (partes[0] == "beber")
            {
                if (!garrafa.Beber(valor))
                {
                    Console.WriteLine("Não há água suficiente ou o valor é inválido.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Formato inválido.");
                return;
            }

            garrafa.MostrarInfo();

            if (garrafa.EstaVazia())
            {
                Console.WriteLine("A garrafa está vazia.");
            }
            else
            {
                Console.WriteLine("A garrafa ainda tem água.");
            }
        }
        catch
        {
            Console.WriteLine("Entrada inválida. Escreve o comando e um número, ex: beber 20.");
        }
    }
}
