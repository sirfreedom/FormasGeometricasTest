using System;
using System.Data;
using System.Linq;
using System.Text;


namespace DevelopmentChallenge.Data.Languages
{
    public abstract class LocalizationBase
    {
        /// <summary>
        /// Este metodo lee el resource y busca la key y devuelve el dato
        /// </summary>
        /// <param name="Culture"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public string ReadResource(string Culture, string Key)
        {
            string sFile = "DevelopmentChallenge.resx";
            DataSet dsResource = new DataSet();
            string sValorResource = string.Empty;
            StringBuilder sbPath = new StringBuilder();
            string sApp = AppDomain.CurrentDomain.BaseDirectory;
            sbPath.Append(sApp);
            sbPath.Append(sFile);
            try
            {
                dsResource.ReadXml(sbPath.ToString());

                sValorResource = dsResource.Tables["resource"].AsEnumerable()
                .Where(row => row.Field<string>("Key") == Key)
                .Select(row => row.Field<string>(Culture)).ToList().SingleOrDefault();
            }
            catch (Exception)
            {
            }
            return sValorResource;
        }



    }
}
