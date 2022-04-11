using System;

namespace P10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

            double valorInvestido = 1000.0;

            // 0.036% = 0.0036
            valorInvestido += valorInvestido * 0.0036;
            Console.WriteLine($"Após 1 mês, você terá R${valorInvestido}");

            valorInvestido += valorInvestido * 0.0036;
            Console.WriteLine($"Após 2 mese, você terá R${valorInvestido}");


            Console.WriteLine("Finalizando o projeto, aperte enter. . .");
            Console.ReadLine();

        }
    }
}
