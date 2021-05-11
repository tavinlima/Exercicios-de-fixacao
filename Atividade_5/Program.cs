using System;

namespace Atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada de 1 a 10:");
            // int numero = 1;

            for (var i = 1; i < 11; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\n Tabuada do {i}" + "\n");
                Console.ResetColor();

                for (var c = 1; c < 11; c++)
                {
                int resposta = i * c;
                Console.WriteLine($"Tabuada: {i} x {c} = {resposta}");
                }
            }
        }
    }
}
