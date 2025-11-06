using System;
using System.Text;

namespace DevelopmentChallenge.Data
{
    public class Rectangulo : GeometricBase, IFigura
    {

        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo(double ancho, double alto, ILocalizationStrategy localizationStrategy)
        {
            if (alto == 0 || ancho == 0)
            {
                throw new ArgumentException("the parameters its wrong, try again");
            }

            Ancho = ancho;
            Alto = alto;
            Localization = localizationStrategy;
        }

        public double CalcularArea()
        {
            return Ancho * Alto;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Ancho + Alto);
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
