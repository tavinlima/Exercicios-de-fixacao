using System;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual combustível usado? use 'a' para alcool ou 'g' para gasolina");
            string combustivel = Console.ReadLine() .ToLower();

            Console.WriteLine("Quantos litros vendidos? ");
            double litros = double.Parse(Console.ReadLine());
                
            double valorAlcool = 4.90 * litros;
            double valorGasolina = 5.30 * litros;
            
            switch (combustivel)
            {
                case "a":
                if (litros <= 20){
                double porcentagem = (valorAlcool * 3) / 100;
                double valorFinal = valorAlcool - porcentagem;
                Console.WriteLine($"O valor final é de: R${valorFinal .ToString("N2")}");
                } 
                else{
                double porcentagem = (valorAlcool * 5) / 100;
                double valorFinal = valorAlcool - porcentagem;
                Console.WriteLine($"O valor final é de: R${valorFinal .ToString("N2")}");
                }
                    break;
                case "g":
                 if (litros <= 20){
                double porcentagem = (valorGasolina * 4) / 100;
                double valorFinal = valorGasolina - porcentagem;
                Console.WriteLine($"O valor final é de: R${valorFinal .ToString("N2")}");
                } 
                else{
                double porcentagem = (valorGasolina * 6) / 100;
                double valorFinal = valorGasolina - porcentagem;
                Console.WriteLine($"O valor final é de: R${valorFinal .ToString("N2")}");
                }
                    break;
                default:
                Console.WriteLine($"Valor inválido!!!");
                    break;
            }

            //Exemplo com Do - While

            // double valorAlcool = 4.90 * litros;
            // double valorGasolina = 5.30 * litros;
            // bool condicao = false;

            // do
            // {
            // Console.WriteLine("Qual combustível usado? use 'a' para alcool ou 'g' para gasolina");
            // string combustivel = Console.ReadLine() .ToLower();
                
            // switch (combustivel)
            // {
            //     case "a":
            //     Console.WriteLine("Quantos litros vendidos? ");
            //     double litros = double.Parse(Console.ReadLine());

            //     if (litros <= 20){
            //     double porcentagem = (valorAlcool * 3) / 100;
            //     double valorFinal = valorAlcool - porcentagem;
            //     Console.WriteLine($"O valor final é de: R${valorFinal .ToString("N2")}");
            //     } 
            //     else{
            //     double porcentagem = (valorAlcool * 5) / 100;
            //     double valorFinal = valorAlcool - porcentagem;
            //     Console.WriteLine($"O valor final é de: R${valorFinal .ToString("N2")}");
            //     }

            //     condicao = true;
            //         break;
            //     case "g":
            //     Console.WriteLine("Quantos litros vendidos? ");
            //     double litros = double.Parse(Console.ReadLine());

            //     if (litros <= 20){
            //     double porcentagem = (valorGasolina * 4) / 100;
            //     double valorFinal = valorGasolina - porcentagem;
            //     Console.WriteLine($"O valor final é de: R${valorFinal .ToString("N2")}");
            //     } 
            //     else{
            //     double porcentagem = (valorGasolina * 6) / 100;
            //     double valorFinal = valorGasolina - porcentagem;
            //     Console.WriteLine($"O valor final é de: R${valorFinal .ToString("N2")}");
            //     }

            //     condicao = true;
            //         break;
            //     default:
            //     Console.WriteLine($"Valor inválido!!!");
            //         break;
            // }
            // } while (condicao == false;)
        }

    }
}
