﻿using System;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] valores = new float [10];

            Console.WriteLine("Olá! Por favor insira 10 números.");

            for (int v = 0; v < 10; v++)
            {
            Console.WriteLine($"Insira o {v + 1}º número ");
            valores [v] = float.Parse(Console.ReadLine());
            }

            Array.Sort(valores);
            Console.WriteLine("Em ordem: ");
            foreach (var item in valores) Console.WriteLine(item);

            Console.WriteLine("O menor número é " + valores[0]);
		    Console.WriteLine("O menor número é " + valores[9]);
        }
    }
}
