using System;

namespace FLAMENGO
{
    class Program
    {
        static void Main(string[] args)
        {
            //fazer um programa utilizando a estrutura switch que quando digitar 1 ele volte domingo 2 segunda 3 terca até sábado

            Console.WriteLine("Digite um número de 1 - 7");
            var numero = Console.ReadLine();

            switch (numero)
            {
                case "1":
                    Console.WriteLine("Número 1 - Domingo");
                    break;
                case "2":
                    Console.WriteLine("Número 2 - Segunda-Feira");
                    break;
                case "3":
                    Console.WriteLine("Número 3 - Terça-Feira");
                    break;
                case "4":
                    Console.WriteLine("Número 4 - Quarta-Feira");
                    break;
                case "5":
                    Console.WriteLine("Número 5 - Quinta-Feira");
                    break;
                case "6":
                    Console.WriteLine("Número 6 - Sexta-Feira");
                    break;
                case "7":
                    Console.WriteLine("Número 7 - Sábado");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        }
    }
}
