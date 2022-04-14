using System;

namespace P11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");
            double valorInvestido = 1000.0;
            
            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine($"Após o mês {contadorMes}, você terá R${valorInvestido} investido");
            }

        }
    }
}
