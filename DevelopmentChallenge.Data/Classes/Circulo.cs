using System;
using System.Text;

namespace DevelopmentChallenge.Data
{
    public class Circulo : GeometricBase, IFigura
    {

        public double Radio { get; set; }

        public Circulo(double radio,ILocalizationStrategy localizationStrategy)
        {
            if (radio == 0)
            {
                throw new ArgumentException("the parameter radio its wrong, try again");
            }

            Radio = radio;
            Localization = localizationStrategy;
        }

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
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
