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
            throw new NotImplementedException();
        }

        public double CalcularPerimetro()
        {
            throw new NotImplementedException();
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
