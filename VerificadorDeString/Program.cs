using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Digite uma string:");
        string input = Console.ReadLine();

        
        int count = ContarOcorrenciasDeA(input);

        if (count > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {count} vezes na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não aparece na string.");
        }
    }

   
    static int ContarOcorrenciasDeA(string str)
    {
        int contador = 0;

        foreach (char c in str)
        {
            if (c == 'a' || c == 'A')
            {
                contador++;
            }
        }

        return contador;
    }
}
