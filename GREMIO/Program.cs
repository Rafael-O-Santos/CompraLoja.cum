using System;

namespace GREMIO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* while enquanto

            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            }

            while (i <= 10);
            */

            //Array
            /*var indice = 0;
            var versoes = new[] { "1.0", "1.1", "2.0", "3.0" };
           
            /*Console.WriteLine(versoes[0]);
            Console.WriteLine(versoes[1]);
            Console.WriteLine(versoes[2]);
            Console.WriteLine(versoes[3]);
            */

            /*Array com while
            while (indice < versoes.Length)
            {
                Console.WriteLine(versoes[indice] + " corresponde ao índice: " + indice);
                indice ++;
            }
            */

            /*var contador = 10;
            var opc = "";
            do
            {
                Console.WriteLine("Digite a Opção");
                Console.WriteLine("1 - SAQUE | 2 - Depósito | 3 - Saldo | 0 - Sair");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        Console.WriteLine("Opção 1 - Saque selecionado");
                        break;
                    case "2":
                        Console.WriteLine("Opção 2 - Depósito selecionado");
                        break;
                    case "3":
                        Console.WriteLine("Opção 3 - Saldo disponível: R$ 100,00");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida - Aprenda a LER");
                        break;
                }

            } while (opc != "0");
            */

            //Carros laço for
            //var carros = new[] { "Celta", "Gol", "Eclipse", "Supra", "Subaru" };

            /*for (int indice = 0; indice < carros.Length; indice++)
            {
                Console.WriteLine(carros[indice]);
            }
            */

            string[] carCompanies = { "Tata Motors", "Mahindra", "Volkswagen", "Toyota" };

            foreach (string car in carCompanies)
            {
                Console.WriteLine("{0}", car);
            }


            
        }
    }
}
