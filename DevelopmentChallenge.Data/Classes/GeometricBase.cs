using System.Reflection;

namespace DevelopmentChallenge.Data
{
    public class GeometricBase
    {

        /// <summary>
        /// El localization es lo unico comun en todas las clases, puede que en un futuro haya mas cosas comunes, pero por ahora no.
        /// </summary>
        protected ILocalizationStrategy Localization { get; set; }


        /// <summary>
        /// Tipo esta propiedad devuelve el nombre del objeto en string, si la clase se llama cuadrado devuelve cuadrado, esto sirve para saber quien es por reflexion
        /// y tambien lo podemos usar como key para el culture.
        /// </summary>
        public string Tipo
        {
            get 
            {
                return this.GetType().Name;
            }
        }




    }
}
