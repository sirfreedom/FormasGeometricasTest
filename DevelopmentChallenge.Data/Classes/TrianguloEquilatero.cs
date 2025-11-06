using System;
using System.Text;

namespace DevelopmentChallenge.Data
{
    public class TrianguloEquilatero : GeometricBase, IFigura
    {
        public double Lado { get; set; }

        public TrianguloEquilatero(double lado, ILocalizationStrategy localizationStrategy) 
        {
            if (lado == 0) {
                throw new ArgumentException("the parameter LADO its wrong, try again");
            }

            Lado = lado;
            Localization = localizationStrategy;
        }

        public double CalcularArea()
        {
            return (Math.Sqrt(3) / 4) * Lado * Lado;
        }

        public double CalcularPerimetro()
        {
            return 3 * Lado;
        }

        public string Imprimir()
        {
            StringBuilder sbText = new StringBuilder();
            sbText.Append(Localization.GetTexto(Tipo, "Name"));
            sbText.Append(Localization.GetTexto(Tipo, "Area"));
            sbText.Append(CalcularArea());
            sbText.Append(Localization.GetTexto(Tipo, "Perimetro"));
            sbText.Append(CalcularPerimetro());

            return sbText.ToString();
        }
    }
}
