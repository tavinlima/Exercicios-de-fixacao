using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Insira o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira a quantidade de produtos: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            double total = quantidade * preco;
            Console.WriteLine($"O valor total é: R$: {total .ToString("N2")}");

            if(quantidade <= 5){
                double porcentagem = total * 0.2;
                double totalFinal = total - porcentagem;
                Console.WriteLine($"O valor com desconto é: R$: {totalFinal .ToString("N2")}");
            } 
            else if (quantidade > 5 && quantidade <= 10){
                double porcentagem = total * 0.3;
                double totalFinal = total - porcentagem;
                Console.WriteLine($"O valor com desconto é: R$: {totalFinal .ToString("N2")}");
            }
            else {
                double porcentagem = total * 0.5;
                double totalFinal = total - porcentagem;
                Console.WriteLine($"O valor com desconto é: R$: {totalFinal .ToString("N2")}");
            }
        }
    }
}
