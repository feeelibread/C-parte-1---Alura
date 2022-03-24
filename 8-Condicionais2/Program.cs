using System;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8 - Condicionais 2");
            int idade = 16;
            int quantidadeDePessoas = 2;

            if (idade >= 18 || quantidadeDePessoas >= 2)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");

            }

            Console.WriteLine("Finalizando o projeto, aperte enter. . .");
            Console.ReadLine();
        }
    }
}
