using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o 4 projeto - Convertendo numeros e outros tipos numericos");

            double salario = 1200.50;

            //O int é um tipo de variável que suporta valores até 32 bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            //O long é um tipo de variável que suporta valores até 64 bits
            long idade = 13000000000;
            Console.WriteLine(idade);

            //O short é um tipo de variável que suporta valores até 16 bits
            short quantidadeDeProdutos = 15000;
            Console.WriteLine(quantidadeDeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("Finalizando o projeto, aperte enter. . .");
        }
    }
}
