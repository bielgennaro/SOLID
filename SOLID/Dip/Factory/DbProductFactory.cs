using System.Configuration;
using Dip.Model;

namespace Dip.Factory
{
    public class DbProductFactory
    {
        public static DbProduct Create()
        {
            if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                return new SQLServerProduct();
            }
                
            

            return new MongoDbProduct();
        }
    }
}