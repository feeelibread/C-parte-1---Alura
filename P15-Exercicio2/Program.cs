using System;

namespace P15_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            for (int i = 1; i <= 10; i++)
            {
                n = i * n;
                Console.WriteLine($"O fatorial de {i}, é = {n}");
            }
        }
    }
}
