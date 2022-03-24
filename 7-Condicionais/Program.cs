using System;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");
            int idade = 16;
            int quantidadeDePessoas = 2;

            if (idade >= 18)
            {
                Console.WriteLine("João possuí 18 anos, portanto, pode entrar.");
            }
            else
            {
                if (quantidadeDePessoas >= 2)
                {
                    Console.WriteLine("João não possuí 18 anos, mas, está acompanhado e portanto, pode entrar.");
                }
                else
                {
                    Console.WriteLine("João não possuí 18 anos, não pode entrar.");
                }
            }

            Console.WriteLine("Finalizando o projeto, aperte enter. . .");
            Console.ReadLine();
        }
    }
}
