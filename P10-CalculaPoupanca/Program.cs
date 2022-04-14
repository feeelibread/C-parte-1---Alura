using System;

namespace P10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

            double valorInvestido = 1000.0;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine($"Após {contadorMes} meses, você terá: {valorInvestido}");
                
                contadorMes++;

            }

            Console.WriteLine("Finalizando o projeto, aperte enter. . .");
            Console.ReadLine();

        }
    }
}
