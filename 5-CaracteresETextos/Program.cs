using System;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            //Character
            char primeiraLetra = 'ã';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            //Strings
            string titulo = "Alura curso online de tecnlogia, descobri pelo gavetaaaa " + 2022;
            Console.WriteLine(titulo);

            string cursosProgramacao = @" - .NET
 - Java 
 - Javascript";
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("Finalizando o projeto, aperte enter. . .");
            Console.ReadLine();
        }
    }
}
