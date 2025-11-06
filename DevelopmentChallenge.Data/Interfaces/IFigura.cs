
namespace DevelopmentChallenge.Data
{

    public interface IFigura
    {
        /// <summary>
        /// Tipo determina el nombre de la clase por reflexion
        /// </summary>
        string Tipo { get; }

        /// <summary>
        /// Calcula el area de la figura
        /// </summary>
        /// <returns>
        /// devuelve el calculo del area
        /// </returns>
        double CalcularArea();

        /// <summary>
        /// Calcula el perimetro de la figura
        /// </summary>
        /// <returns>
        /// devuelve el perimetro de la figura
        /// </returns>
        double CalcularPerimetro();

        /// <summary>
        /// Imprimir : imprime datos de la figura
        /// </summary>
        /// <returns>
        /// devuelve dependiendo el culture, en el idioma correspondiente el area y el perimetro de la figura
        /// </returns>
        string Imprimir(); 


    }
}
