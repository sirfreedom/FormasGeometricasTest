using System.Globalization;
using System.Resources;
using System.Text;


namespace DevelopmentChallenge.Data.Languages
{
    public class LocalizationEnglish : ILocalizationStrategy
    {
        private const string CULTURE = "en-US";

        private readonly ResourceManager _resourceManager = new ResourceManager("DevelopmentChallenge.Resources", typeof(LocalizationEnglish).Assembly);

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
