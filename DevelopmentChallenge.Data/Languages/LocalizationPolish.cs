using System.Globalization;
using System.Resources;
using System.Text;


namespace DevelopmentChallenge.Data.Languages
{
    public class LocalizationPolish : ILocalizationStrategy
    {
        private const string CULTURE = "pl-PL";

        private readonly ResourceManager _resourceManager = new ResourceManager("DevelopmentChallenge.pl-PL.Resources", typeof(LocalizationPolish).Assembly);

        public string GetTexto(string tipo, string clave)
        {
            StringBuilder sbClave = new StringBuilder();
            string sKey = string.Empty;
            sbClave.Append(tipo);
            sbClave.Append("_");
            sbClave.Append(clave);
            sKey = _resourceManager.GetString(sbClave.ToString(), new CultureInfo(CULTURE));
            return sKey;
        }

        public CultureInfo GetCulture() => new CultureInfo(CULTURE);
    }
}
