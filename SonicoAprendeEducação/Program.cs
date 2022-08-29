using System;

namespace SonicoAprendeEducação
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar um programa que retorne se é manhã, tarde ou noite
            //manhã 7:00 - 12:00 - Bom dia
            //tarde 12:01 - 18:00 - Boa tarde
            //noite 18:01 - 6:00 - Boa noite

            Console.WriteLine("Insira o horário: ");
            double H = double.Parse(Console.ReadLine());
            
            if (H >= 1 && H < 6)
            {
                Console.WriteLine("Boa madrugada");
            }
            else if (H >= 7 && H <= 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if ( H >= 13 && H <= 17)
            {
                Console.WriteLine("Boa tarde");
            }
            else if ( H >= 18 && H <= 24)
            {
                Console.WriteLine("Boa noite");
            }
            else
            {
                Console.WriteLine("Horário invalido");
            }
        }
    }
}
