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
                }
            }
            else
            {
                Console.WriteLine("Formato inválido");           
            }
        }
        catch                                          
        {
            Console.WriteLine("Entrada inválida. Escreve o comando e um número, ex: beber 20");
        }

        garrafa.MostrarInfo();

        if (garrafa.EstaVazia())
        {
            Console.WriteLine("A garrafa está vazia");
        }
        else
        {
            Console.WriteLine("A garrafa ainda tem água");
        }
    }
}
