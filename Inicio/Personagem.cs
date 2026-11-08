using System;

class Personagem
{
    public string nome;
    private int vida = 100;
    private int nivel;

    public Personagem(string nome, int nivel)
    {
        this.nome = nome;
        Nivel = nivel;                       
    }

    public int Nivel
    {
        get { return nivel; }
        set
        {
            if (value >= 1)
                nivel = value;
        }
    }

    public int ReceberDano(int dano)
    {
        if (dano > 0)
        {
            vida -= dano;
            if (vida < 0)                     
                vida = 0;
        }
        return vida;
    }

    public int Curar(int quantidade)
    {
        if (quantidade > 0)
        {
            vida += quantidade;
            if (vida > 100)                 
                vida = 100;
        }
        return vida;
    }

    public bool EstarVivo()               
    {
        return vida > 0;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Nivel: {nivel}");
        Console.WriteLine($"Vida: {vida}");
    }
}

class Program
{
    static void Main()
    {
        Personagem personagem = new Personagem("Aragorn", 5);

        Console.WriteLine("Deseja dar dano ou curar, e qual o valor? (ex: dano 30 ou curar 20)");
        string input = Console.ReadLine();
        string[] partes = input.Split(' ');
        int valor = int.Parse(partes[1]);

        if (partes[0] == "dano")              
        {
            personagem.ReceberDano(valor);
        }
        else if (partes[0] == "curar")
        {
            personagem.Curar(valor);
        }
        else
        {
            Console.WriteLine("Comando invalido");
        }

        personagem.MostrarInfo();

        if (personagem.EstarVivo())            
        {
            Console.WriteLine("Está vivo");    
        }
        else
        {
            Console.WriteLine("Morreu");
        }
    }
}
