using System;
using System.Text;

namespace DevelopmentChallenge.Data
{
    public class Cuadrado : GeometricBase, IFigura
    {
        public double Lado { get; set; }

        public Cuadrado(double lado, ILocalizationStrategy localizationStrategy) 
        {
            if (lado == 0)
            {
                throw new ArgumentException("the parameter lado its wrong, try again");
            }

            Lado = lado;
            Localization = localizationStrategy;
        }

        public double CalcularArea()
        {
            return Lado * Lado;
        }

        public double CalcularPerimetro()
        {
            return 4 * Lado;
        }

        public string Imprimir()
        {
            StringBuilder sbText = new StringBuilder();
            sbText.Append(Localization.GetTexto(Tipo, "Key"));
            sbText.AppendLine();
            sbText.Append(Localization.GetTexto(Tipo, "Area"));
            sbText.Append(CalcularArea());
            sbText.AppendLine();
            sbText.Append(Localization.GetTexto(Tipo, "Perimetro"));
            sbText.Append(CalcularPerimetro());
            sbText.AppendLine();
            return sbText.ToString();
        }
    }
}
