using System;

namespace Sonico___segundinha
{
    class Program
    {
        static void Main(string[] args)
        {
            var ativo = false;
            var a = 3;
            var b = 5;

            Console.WriteLine( a == b); //igual
            Console.WriteLine( a != b); // Diferente

            Console.WriteLine("Operador Lógico E ");
            // Operador &&
            Console.WriteLine(a > 2 || b > 4); // A = V B= V ==== Retorno ==== Verdadeiro
            Console.WriteLine(a > 4 && b > 4); // A = F B= V ==== Retorno ==== Falso
            Console.WriteLine(a > 2 && b > 6); // A = V B= F ==== Retorno ==== Falso
            Console.WriteLine(a > 2 && b > 4); // A = V B= F ==== Retorno ==== Falso
            Console.WriteLine(a > 4 && b > 6); // A = F B= F ==== Retorno ==== Falso


            Console.WriteLine("Operador Lógico Ou ");
            // Operador Ou
            Console.WriteLine(a > 2 || b > 4); // A = V B= V ==== Retorno ==== Vardadeiro
            Console.WriteLine(a > 4 || b > 4); // A = F B= V ==== Retorno ==== Vardadeiro
            Console.WriteLine(a > 2 || b > 6); // A = V B= F ==== Retorno ==== Vardadeiro
            Console.WriteLine(a > 2 || b > 4); // A = V B= F ==== Retorno ==== Vardadeiro
            Console.WriteLine(a > 4 || b > 6); // A = F B= F ==== Retorno ==== Falso
        }
    }
}
