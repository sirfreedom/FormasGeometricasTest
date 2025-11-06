using DevelopmentChallenge.Data;
using DevelopmentChallenge.Data.Languages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //IFigura figura = new Cuadrado(3, new LocalizationSpanish());
            //Console.Write(figura.Imprimir());

            List<IFigura> lFigura = new List<IFigura>();
            StringBuilder sbTexto = new StringBuilder();
            List<ILocalizationStrategy> lLocalization = new List<ILocalizationStrategy>();

            lLocalization.Add(new LocalizationSpanish());
            lLocalization.Add(new LocalizationEnglish());
            lLocalization.Add(new LocalizationItalian());
            lLocalization.Add(new LocalizationPolish());

            foreach (ILocalizationStrategy l in lLocalization) {
                lFigura.Add(new Cuadrado(3, l));
                lFigura.Add(new Circulo(3, l));
                lFigura.Add(new Rectangulo(3, 4, l));
                lFigura.Add(new Trapecio(2, 3, 4, 5, 6, l));
                lFigura.Add(new TrianguloEquilatero(3, l));
            }

            foreach (IFigura f in lFigura)
            {
                sbTexto.Append(f.Imprimir());
            }

            Console.Write(sbTexto.ToString());



        }
    }
}
