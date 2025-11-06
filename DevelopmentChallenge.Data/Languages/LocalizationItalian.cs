using System.Globalization;
using System.Resources;
using System.Text;

namespace DevelopmentChallenge.Data.Languages
{
    public class LocalizationItalian : ILocalizationStrategy
    {
        private const string CULTURE = "it-IT";

        private readonly ResourceManager _resourceManager = new ResourceManager("DevelopmentChallenge.it-IT", typeof(LocalizationItalian).Assembly);

        public string GetTexto(string tipo, string clave)
        {
            StringBuilder sbClave = new StringBuilder();
            string sKey;
            sbClave.Append(tipo);
            sbClave.Append("_");
            sbClave.Append(clave);
            sKey = _resourceManager.GetString(sbClave.ToString(), new CultureInfo(CULTURE));
            return sKey;
        }

        public CultureInfo GetCulture() => new CultureInfo(CULTURE);
    }
}
