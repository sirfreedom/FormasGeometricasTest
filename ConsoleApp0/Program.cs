using DevelopmentChallenge.Data;
using System;

namespace ConsoleApp0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IFigura figura = new Cuadrado(3, new LocalizationSpanish());
            Console.Write(figura.Imprimir());



        }
    }
}
