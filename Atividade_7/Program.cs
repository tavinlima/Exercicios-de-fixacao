using System;

namespace Atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int [15];
            Console.WriteLine("Insira 15 números: ");

            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($"Insira o {i + 1}º número: ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            for (var i = 14; i < 15; i--)
            {
                Console.WriteLine($"Em ordem inversa:");
                Console.WriteLine(valores [i]);
            }
        }
    }
}
