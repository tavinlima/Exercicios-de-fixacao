using System;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] valores = new float [10];

            Console.WriteLine($"Olá! Por favor insira {valores.Length} números.");

            for (int v = 0; v < valores.Length; v++)
            {
            Console.WriteLine($"Insira o {v + 1}º número ");
            valores [v] = float.Parse(Console.ReadLine());
            }

            Array.Sort(valores);
            Console.WriteLine("Em ordem: ");
            foreach (var item in valores) Console.WriteLine(item);

            Console.WriteLine("O menor número é " + valores[0]);
		    Console.WriteLine("O menor número é " + valores[(valores.Length - 1)]);
        }
    }
}
