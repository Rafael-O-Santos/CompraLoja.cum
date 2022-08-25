using System;
using System.Globalization;
namespace SonicoVaiAsCompras.ExE
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Caixa eletrônico
             Valor da compra
             Valor pago pelo cliente
             Troco (caso tenha)
             */


            Console.WriteLine("=========================");
            Console.WriteLine("=== Valor das compras ===");
            Console.WriteLine("=========================");

            Console.WriteLine("Valor das compras");
            double valordascompras = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("==================");
            Console.WriteLine("=== Valor Pago ===");
            Console.WriteLine("==================");

           
            double SaldoCliente = double.Parse(Console.ReadLine());
            Console.WriteLine("Seu saldo é: " + "R$" + SaldoCliente);
            Console.WriteLine("digite o método de pagamento:");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("=============");
            Console.WriteLine("=== Troco ===");
            Console.WriteLine("=============");

            double troco = SaldoCliente - valordascompras;
            Console.WriteLine("Seu Troco é:" + "R$" + troco);



        }
    }
}
