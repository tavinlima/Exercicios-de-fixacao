using System;

namespace Atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int [15];
            Console.WriteLine($"Insira {valores.Length} números: ");

            for (var i = 0; i < valores.Length; i++)
            {
                Console.WriteLine($"Insira o {i + 1}º número: ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            for (var i = (valores.Length - 1); i <= 0; i--)
            {
                Console.WriteLine($"Em ordem inversa:");
                Console.WriteLine($"\n {valores [i]}");
            }
        }
    }
}
