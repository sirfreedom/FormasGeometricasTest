using System.Globalization;


namespace DevelopmentChallenge.Data
{
    public interface ILocalizationStrategy
    {
        /// <summary>
        /// GetTexto busca en el archivo de resources
        /// </summary>
        /// <param name="tipo">
        /// el nombre del objeto 
        /// </param>
        /// <param name="clave">
        /// la clave del registro de resources
        /// </param>
        /// <returns>
        /// la concatenacion del tipo y de la clave logran determinar el nombre del objeto y clave a traducir.
        /// </returns>
        string GetTexto(string tipo, string clave);

        /// <summary>
        /// GetCulture
        /// </summary>
        /// <returns>
        /// devuelve la cultura del objeto implementado
        /// </returns>
        CultureInfo GetCulture();


    }
}
