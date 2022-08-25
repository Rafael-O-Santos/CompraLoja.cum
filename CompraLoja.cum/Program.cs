using System;

namespace CompraLoja.cum
{
    class Program
    {
        static void Main(string[] args)
        {
            //CompraOnline - AGORA VAI

            string NomedoCliente = "";
            double Saldo;
            string Produto = "";
            double ValorProduto;
           

            // Atribuindo valores

            Console.WriteLine("Insira seu nome:");
            NomedoCliente = Console.ReadLine();

            Console.WriteLine("Seu Saldo é:");
            Saldo = Double.Parse(Console.ReadLine());

            Console.WriteLine("Insira aqui o produto desejado:");
            Produto = Console.ReadLine();

            Console.WriteLine("Seu produto custa:");
            ValorProduto = Double.Parse(Console.ReadLine());

            Console.WriteLine("Nome do cliente:" + NomedoCliente + " " + "Seu saldo final é: 0" + " " + "o produto comprado foi:" + Produto);

            
        }
    }
}
