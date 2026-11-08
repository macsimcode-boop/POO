using System;

class Conta
{
    private double saldo;
    public string nome;

    public Conta(double saldo, string nome)
    {
        this.saldo = saldo;
        this.nome = nome;
    }

    public double Saldo
    {
        get { return saldo; }
        set
        {
            if (value >= 0)
                saldo = value;
        }
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }

    public bool Levantar(double valor)
    {
        if (valor > 0 && valor <= saldo)
        {
            saldo -= valor;
            return true;
        }
        return false;
    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"{nome}, o seu saldo é de {saldo}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o seu nome");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o seu saldo inicial");
        double saldoI = double.Parse(Console.ReadLine());

        Conta conta = new Conta(saldoI, nome);

        Console.WriteLine("Deseja levantar ou depositar, e qual o valor? (ex: depositar 50)");
        string input = Console.ReadLine();
        string[] partes = input.Split(' ');
        double valor = double.Parse(partes[1]);

        if (partes[0] == "depositar")
        {
            conta.Depositar(valor);
        }
        else if (partes[0] == "levantar")
        {
            if (!conta.Levantar(valor))
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
        else
        {
            Console.WriteLine("Formato invalido");
        }

        conta.MostrarSaldo();
    }
}
