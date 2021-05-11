using System;

namespace Atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string [10];
            Console.WriteLine($"Insira {nome.Length} nomes a seguir: ");

            for (var i = 0; i < nome.Length; i++)
            {
                Console.WriteLine($"Insira o {i + 1}º nome");
                nome[i] = Console.ReadLine() .ToLower();
            }

            Console.WriteLine("Digite o nome que deseja procurar: ");
            string busca = Console.ReadLine();
            bool achei = false;
            

            foreach (var item in nome)
            {
                if(item == busca){
                    achei = true;
                }
            }
            //if (achei == true)
            if (achei){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n ACHEI!!!" + "\n");
                Console.ResetColor();
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n NÃO ACHEI..." + "\n");
                Console.ResetColor();
            }
            
        }

    }
}
