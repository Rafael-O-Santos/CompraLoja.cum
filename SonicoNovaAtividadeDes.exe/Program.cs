﻿using System;

namespace SonicoNovaAtividadeDes.exe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade");
            }
            else
            {
                Console.WriteLine("Você é menor de idade");
            }
        }
    }
}
