using System;

namespace _2_CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 2 - Criando Variáveis");
            int idade;
            idade = 32;
            Console.WriteLine(idade);
            
            idade = 10;
            Console.WriteLine(idade);
            
            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + idade);

            Console.WriteLine("Finalizando o projeto, tecle enter");
            Console.ReadLine();
        }
    }
}
