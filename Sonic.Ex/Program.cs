using System;
using System.Globalization;

namespace Sonic.Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             Fazer m programa para calcular o aumento de salário dos funcionários
              de um funcionário X Exibindo:

             - % de aumento do salário
             - Aumento em Reais
             - Salário Final
           */
            Console.WriteLine("=====================================");
            Console.WriteLine("=== Program de aumento de salário ===");
            Console.WriteLine("=====================================");


            Console.WriteLine("Insira o nome do funcionário: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite o salário do funcionário: ");
            double SalarioInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual % de aumento deseja para o funcionário " + Nome + " ?");
            double perc = double.Parse(Console.ReadLine());

            double percemdecimal = perc / 100;

            double SalarioFinal = SalarioInicial + SalarioInicial * percemdecimal;




            Console.Clear();


            Console.WriteLine("=======================");
            Console.WriteLine("=== Resultado Final ===");
            Console.WriteLine("=======================");


            Console.WriteLine("Salário Inicial: " + SalarioInicial);
            Console.WriteLine("Percentual de aumento" + perc + "%");
            Console.WriteLine("Total de aumento:" + SalarioInicial * percemdecimal);
            Console.WriteLine("Salário Final: " + SalarioFinal);
            Console.WriteLine("Salario Final: " + "R$" + SalarioFinal.ToString("F2",
                CultureInfo.InvariantCulture));

        }
    }
}
