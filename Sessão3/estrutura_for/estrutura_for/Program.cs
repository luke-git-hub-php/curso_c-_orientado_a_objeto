﻿using System;

namespace estrutura_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números inteiros você vai digitar?");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int  i = 1; i <= n; i++)
            {
                Console.WriteLine("Valor: N{0}:", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma = "+soma);
        }
    }
}
