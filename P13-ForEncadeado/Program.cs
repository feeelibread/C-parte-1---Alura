using System;

namespace P13_ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13 - For Encadeado");

            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            //********
            //*********

            //Imprimindo os asteriscos usando o BREAK
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            //Uma forma diferente 
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
