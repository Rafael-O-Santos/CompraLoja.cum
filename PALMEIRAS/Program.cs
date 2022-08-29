using System;

namespace PALMEIRAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione a opção desejada");
            var opçao = Console.ReadLine();

            switch (opçao)
            {
                case "1":
                    Console.WriteLine("Opção 1 - Seu saldo é de R$ 100,00");
                    break;
                case "2":
                    Console.WriteLine("Opção 2 - Informe o valor do depósito");
                    break;
                case "3":
                    Console.WriteLine("Opção 3 - Saque - Informe o valor");
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
            }
        }
    }
}
