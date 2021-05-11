using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Insira seu ano de nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;

            if(anoAtual - nascimento < 16){
                Console.WriteLine("Não pode votar esse ano :(");
            } 
            else{
            Console.WriteLine("Pode votar esse ano!");
            }
        }
    }
}
