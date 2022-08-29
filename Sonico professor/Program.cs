using System;

namespace Sonico_professor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do aluno");
            double nota = double.Parse(Console.ReadLine());

            if (nota > 7)
            {
                Console.WriteLine("Você está aprovado");
            }
            else if (nota >= 5 && nota < 7 )
            {
                Console.WriteLine("Você está de recuperação");
            }
            else
            {
                Console.WriteLine("Você está reprovado");
            }
        }
    }
}
