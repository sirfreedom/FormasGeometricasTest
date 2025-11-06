using DevelopmentChallenge.Data.Languages;
using System.Globalization;
using System.Text;

namespace DevelopmentChallenge.Data
{
    public class LocalizationSpanish : LocalizationBase, ILocalizationStrategy
    {
        private const string CULTURE = "es-ES";


        public string GetTexto(string tipo, string clave) 
        {
            StringBuilder sbClave = new StringBuilder();
            sbClave.Append(tipo);
            sbClave.Append("_");
            sbClave.Append(clave);
            return ReadResource(CULTURE, sbClave.ToString());
        }

        public CultureInfo GetCulture() => new CultureInfo(CULTURE);


    }
}
