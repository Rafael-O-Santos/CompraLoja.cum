using System;

namespace Piloto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compra Online - AGORA VAI

            string NomedoCliente = "";
            Console.WriteLine("Insira seu nome:");
            NomedoCliente = Console.ReadLine();
            Console.WriteLine("Seu Saldo é:");
            double SaldoCliente = double.Parse(Console.ReadLine());          
            string Produto = "";
            Console.WriteLine("Insira aqui o produto desejado:");
            Produto = Console.ReadLine();
            Console.WriteLine("Seu produto custa:");
            double ValorProduto = double.Parse(Console.ReadLine());
            bool comprarealizada = SaldoCliente> ValorProduto;
            bool compranegada = SaldoCliente < ValorProduto;
            bool comprarealizada2 = SaldoCliente == ValorProduto;
            double SaldoFinal;

            SaldoFinal = (SaldoCliente - ValorProduto);

            

            if (SaldoCliente > ValorProduto)
            {
                Console.WriteLine("Compra realizada");
            }
            else if (SaldoCliente == ValorProduto)
            {
                Console.WriteLine("Compra realizada");
            }
            else
            {
                Console.WriteLine("Compra Negada");
            }

            Console.WriteLine("Nome:" + NomedoCliente +" " +" " +"O produto solicitado foi:" + Produto +" " +" " +"Seu saldo atual é:" + SaldoFinal);  
                      
        }
    }
}
