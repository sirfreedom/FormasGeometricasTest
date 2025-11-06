using System.Text;
using DevelopmentChallenge.Data.Languages;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {

        [TestCase]
        public void Test_Cuadrado_Espanol()
        {
            IFigura figura;
            StringBuilder sbTexto = new StringBuilder();
            figura = new Cuadrado(3, new LocalizationSpanish());
            Assert.AreEqual(9, figura.CalcularArea());
            Assert.AreEqual(12, figura.CalcularPerimetro());
            Assert.IsTrue(figura.Imprimir().Contains("Calculamos"),"La impresión debe incluir el texto esperado en español");
            Assert.IsFalse(figura.Imprimir().Contains("We calculate"), "La impresión debe incluir el texto esperado en ingles");
            Assert.IsFalse(figura.Imprimir().Contains("Calcoliamo"), "La impresión debe incluir el texto esperado en italiano");
        }


        [TestCase]
        public void Test_Cuadrado_Ingles()
        {
            IFigura figura;
            StringBuilder sbTexto = new StringBuilder();
            figura = new Cuadrado(3, new LocalizationEnglish());
            Assert.AreEqual(9, figura.CalcularArea());
            Assert.AreEqual(12, figura.CalcularPerimetro());
            Assert.IsTrue(figura.Imprimir().Contains("We calculate"), "La impresión debe incluir el texto esperado en ingles");
            Assert.IsFalse(figura.Imprimir().Contains("Calculamos"), "La impresión debe incluir el texto esperado en español");
            Assert.IsFalse(figura.Imprimir().Contains("Calcoliamo"), "La impresión debe incluir el texto esperado en italiano");
        }

        [TestCase]
        public void Test_Cuadrado_Italiano()
        {
            IFigura figura;
            StringBuilder sbTexto = new StringBuilder();
            figura = new Cuadrado(3, new LocalizationItalian());
            Assert.AreEqual(9, figura.CalcularArea());
            Assert.AreEqual(12, figura.CalcularPerimetro());
            Assert.IsTrue(figura.Imprimir().Contains("Calcoliamo"), "La impresión debe incluir el texto esperado en italiano");
            Assert.IsFalse(figura.Imprimir().Contains("Calculamos"), "La impresión debe incluir el texto esperado en español");
            Assert.IsFalse(figura.Imprimir().Contains("We calculate"), "La impresión debe incluir el texto esperado en ingles");
        }


        [TestCase]
        public void Test_Circulo_Espanol()
        {
            IFigura figura;
            StringBuilder sbTexto = new StringBuilder();
            figura = new Circulo(3, new LocalizationSpanish());
            Assert.AreEqual(28.274333882308138, figura.CalcularArea());
            Assert.AreEqual(18.84955592153876, figura.CalcularPerimetro());
            Assert.IsTrue(figura.Imprimir().Contains("Calculamos"), "La impresión debe incluir el texto esperado en español");
            Assert.IsFalse(figura.Imprimir().Contains("We calculate"), "La impresión debe incluir el texto esperado en ingles");
            Assert.IsFalse(figura.Imprimir().Contains("Calcoliamo"), "La impresión debe incluir el texto esperado en italiano");
        }


        [TestCase]
        public void Test_Circulo_Ingles()
        {
            IFigura figura;
            StringBuilder sbTexto = new StringBuilder();
            figura = new Circulo(3, new LocalizationEnglish());
            Assert.AreEqual(28.274333882308138, figura.CalcularArea());
            Assert.AreEqual(18.84955592153876, figura.CalcularPerimetro());
            Assert.IsTrue(figura.Imprimir().Contains("We calculate"), "La impresión debe incluir el texto esperado en ingles");
            Assert.IsFalse(figura.Imprimir().Contains("Calculamos"), "La impresión debe incluir el texto esperado en español");
            Assert.IsFalse(figura.Imprimir().Contains("Calcoliamo"), "La impresión debe incluir el texto esperado en italiano");
        }

        [TestCase]
        public void Test_Circulo_Italiano()
        {
            IFigura figura;
            StringBuilder sbTexto = new StringBuilder();
            figura = new Circulo(3, new LocalizationItalian());
            Assert.AreEqual(28.274333882308138, figura.CalcularArea());
            Assert.AreEqual(18.84955592153876, figura.CalcularPerimetro());
            Assert.IsTrue(figura.Imprimir().Contains("Calcoliamo"), "La impresión debe incluir el texto esperado en italiano");
            Assert.IsFalse(figura.Imprimir().Contains("Calculamos"), "La impresión debe incluir el texto esperado en español");
            Assert.IsFalse(figura.Imprimir().Contains("We calculate"), "La impresión debe incluir el texto esperado en ingles");
        }


        [TestCase]
        public void Test_Rectangulo_Espanol()
        {
            IFigura figura;
            StringBuilder sbTexto = new StringBuilder();
            figura = new Rectangulo(3,4, new LocalizationSpanish());
            Assert.AreEqual(12, figura.CalcularArea());
            Assert.AreEqual(14, figura.CalcularPerimetro());
            Assert.IsTrue(figura.Imprimir().Contains("Calculamos"), "La impresión debe incluir el texto esperado en español");
        }

        [TestCase]
        public void Test_Trapecio_Espanol()
        {
            IFigura figura;
            StringBuilder sbTexto = new StringBuilder();
            figura = new Trapecio(2,3,4,5,6, new LocalizationSpanish());
            Assert.AreEqual(15, figura.CalcularArea());
            Assert.AreEqual(20, figura.CalcularPerimetro());
            Assert.IsTrue(figura.Imprimir().Contains("Calculamos"), "La impresión debe incluir el texto esperado en español");
            Assert.IsFalse(figura.Imprimir().Contains("We calculate"), "La impresión debe incluir el texto esperado en ingles");
            Assert.IsFalse(figura.Imprimir().Contains("Calcoliamo"), "La impresión debe incluir el texto esperado en italiano");
        }

        [TestCase]
        public void Test_TrianguloEquilatero_Espanol()
        {
            IFigura figura;
            StringBuilder sbTexto = new StringBuilder();
            figura = new TrianguloEquilatero(3, new LocalizationSpanish());
            Assert.AreEqual(3.897114317029974, figura.CalcularArea());
            Assert.AreEqual(9, figura.CalcularPerimetro());
            Assert.IsTrue(figura.Imprimir().Contains("Calculamos"), "La impresión debe incluir el texto esperado en español");
            Assert.IsFalse(figura.Imprimir().Contains("We calculate"), "La impresión debe incluir el texto esperado en ingles");
            Assert.IsFalse(figura.Imprimir().Contains("Calcoliamo"), "La impresión debe incluir el texto esperado en italiano");
        }


    }
}
