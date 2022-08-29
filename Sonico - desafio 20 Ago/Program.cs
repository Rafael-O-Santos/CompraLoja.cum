using System;

namespace Sonico___desafio_20_Ago
{
    class Program
    {
        static void Main(string[] args)
        {
            // escrever um programa que leia quantos m² existe no apartamento
            // se o apartamento for menor que 50m² o programa deve retornar "apartamento compacto"
            // caso seja maior que 50m² apartamento super-luxo

            //variáveis
            double comprimento;
            double largura;
            double M2;
            //definindo valores
            Console.WriteLine("Digite a largura");
            largura = double.Parse(Console.ReadLine());
            Console.WriteLine("A largura é: " + largura);

            Console.WriteLine("Digite o comprimento:");
            comprimento = double.Parse(Console.ReadLine());
            Console.WriteLine("O comprimento é: " + comprimento);

            M2 = largura * comprimento;
            Console.WriteLine("M² é igual: " + M2); 

            //if else

            if (M2 <= 50)
            {
                Console.WriteLine("Seu apartamento é super-luxo");
            }
            else
            {
                Console.WriteLine("Seu apartamento é compacto ");
            }
                
        }
    }
}
