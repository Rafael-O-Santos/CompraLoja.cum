using System;

namespace Sonico.Web
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar um programa que leia um número e retorne se ele é positivo ou negativou

            Console.WriteLine("========== número ==========");
            Console.WriteLine();
            Console.WriteLine("Digite um número:");
            double N = double.Parse(Console.ReadLine());
            Console.WriteLine("O número digitado foi: " + N);

            if ( N < 0)
            {
                Console.WriteLine("Seu número é negativo!");
            }
            else if (N == 0)
            {
                Console.WriteLine("Zero é neutro!");
            }
            else
            {
                Console.WriteLine("Seu número é Positivo");
            }



        }
    }
}
