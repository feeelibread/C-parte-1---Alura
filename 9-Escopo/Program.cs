using System;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 9 - Escopo");
            int idade = 18;
            bool acompanhado = true;

            if (acompanhado == true)
            {
               string mensagemAdicional = "João está acompanhado";
            }
            else
            {
                string mensagemAdicional = "João não está acompanhado";
            }

            if (idade >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
                Console.WriteLine(mensagemAdicional);

            }

            Console.WriteLine("Finalizando o projeto, aperte enter. . .");
            Console.ReadLine();
        }
    }
}
