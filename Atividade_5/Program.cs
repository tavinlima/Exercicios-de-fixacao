using System;

namespace Atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada de 1 a 10:");
            int numero = 1;
            bool check  = true;

            for (var i = 0; check == true; i++)
            {
                if(i == 11){
                    if(numero <=9)
                    {
                        numero++;
                        i=1;
                    }
                }
                int resposta = numero * i;

                Console.WriteLine($"Tabuada: {numero} * {i} = {resposta}");

                if(resposta == 100){
                    check = false;
                }
            }
        }
    }
}
