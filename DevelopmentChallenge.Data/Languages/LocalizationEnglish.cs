using System.Globalization;
using System.Text;


namespace DevelopmentChallenge.Data.Languages
{
    public class LocalizationEnglish : LocalizationBase, ILocalizationStrategy
    {
        /// <summary>
        /// Cultura del lenguaje
        /// </summary>
        private const string CULTURE = "en-US";

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
