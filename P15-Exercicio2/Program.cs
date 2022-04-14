using System;

namespace P15_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;
            for (int i = 1; i <= 10; i++)
            {
                fatorial *= i;
                Console.WriteLine($"O fatorial de {i}, é = {fatorial}");
            }
        }
    }
}
