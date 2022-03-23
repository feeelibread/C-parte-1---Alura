using System;

namespace _6_AtribuiçõesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6 - Atribuições de variáveis");
            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            Console.WriteLine("Finalizando o projeto, aperte enter. . .");
            Console.ReadLine();
        }
    }
}
