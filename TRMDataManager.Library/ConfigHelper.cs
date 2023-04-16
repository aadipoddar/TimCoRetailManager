using System.Configuration;

namespace TRMDataManager.Library
{
    public class ConfigHelper
    {
        public static decimal GetTaxRate()
        {
            // TODO: Move this from config to the API
            string rateText = ConfigurationManager.AppSettings["taxRate"];

            bool IsValidTaxRate = decimal.TryParse(rateText, out decimal output);

            if (IsValidTaxRate == false)
            {
                throw new ConfigurationErrorsException("The Tax rate is not set up properly");
            }

            return output;
        }
    }
}
