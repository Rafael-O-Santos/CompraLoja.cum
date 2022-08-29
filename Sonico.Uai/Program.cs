using System;

namespace Sonico.Uai
{
    class Program
    {
        static void Main(string[] args)
        {
            //escrever um programa que calcule a soma de duas notas e apresente a média final
            //Se a média for maior ou igual a 6 aluno aprovado caso contrário aluno reprovado

            Console.WriteLine("Digite o nome do aluno");
            string Aluno = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota");
            int nota1 =int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            int nota2= int.Parse(Console.ReadLine());

            Console.WriteLine("Essa é a sua média");
            double media = nota1 + nota2 / 2;

            if (nota1 >= 6)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno reprovado!");
            }
        }
    }
}
