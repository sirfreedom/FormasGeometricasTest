using System;
using System.Text;

namespace DevelopmentChallenge.Data
{
    public class Trapecio : GeometricBase, IFigura
    {

        public double LongitudBaseMayor { get; set; }

        public double LongitudBaseMenor { get; set; }

        public double LadoIzquierdo { get; set; }

        public double LadoDerecho { get; set; }

        public double Altura { get; set; }

        public Trapecio(double longitudbasemayor, double longitudbasemenor, double ladoizquierdo, double ladoderecho, double altura, ILocalizationStrategy localizationStrategy)
        {

            if (longitudbasemayor == 0 || longitudbasemenor == 0 || ladoizquierdo == 0 || ladoderecho == 0 || altura == 0)
            {
                throw new ArgumentException("the parameters its wrong, try again");
            }

            LongitudBaseMayor = longitudbasemayor;
            LongitudBaseMenor = longitudbasemenor;
            LadoIzquierdo = ladoizquierdo;
            LadoDerecho = ladoderecho; 
            Altura = altura;
            Localization = localizationStrategy;
        }


        public double CalcularArea()
        {
            return ((LongitudBaseMayor + LongitudBaseMenor) / 2) * Altura;
        }

        public double CalcularPerimetro()
        {
            return LongitudBaseMayor + LongitudBaseMenor + LadoIzquierdo + LadoDerecho + Altura;
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
