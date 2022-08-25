using System;
using System.Globalization;
namespace Sonico___Vende_Terrenos
{
    class Program
    {
        static void Main(string[] args)
        {
            // programa para ler as medidas da largura e comprimento de m terreno retangular
            //com uma casa decimal, bem como o valor do metro quadrado do terreno com duas casa decimais.

            double largura;
            double comprimento;
            double Valorm2;
            double area;
            double valorTotal;


            Console.WriteLine("Digite o valor da largura do terreno:");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do comprimento do terreno:");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor no m²: ");
            Valorm2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Area de cálculo

            area = largura * comprimento;
            valorTotal = area * Valorm2;

            // resultados

            Console.Clear();

            Console.WriteLine("========== Resultados ==========");
            Console.WriteLine("Área do terreno é: " + area.ToString("F2", CultureInfo.InvariantCulture) + "m²");
            Console.WriteLine(" Valor total do terreno é R$: " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
