using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        Inverte(frase);
    }

    static void Inverte(string f)
    {
        string fraseInvertida = "";

        for (int i = f.Length - 1; i >= 0; i--)
        {
            fraseInvertida += f[i];
        }

        Console.WriteLine("String original: " + f);
        Console.WriteLine("String invertida: " + fraseInvertida);
        Console.ReadKey();
    }
}
