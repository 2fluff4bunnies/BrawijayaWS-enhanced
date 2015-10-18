using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Utils;
using System.Configuration;

namespace BrawijayaWorkshop.Database
{
    public static class DatabaseConfigurationHelper
    {
        public static string DefaultConnectionString { get; private set; }

        static DatabaseConfigurationHelper()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[ConfigurationConstant.DB_CONNECTION_STRING_NAME].ConnectionString;
            string serverAddress = ConfigurationManager.AppSettings[ConfigurationConstant.DB_SERVER_ADDRESS].Decrypt();
            string serverDomain = ConfigurationManager.AppSettings[ConfigurationConstant.DB_SERVER_DOMAIN].Decrypt();
            string serverPassword = ConfigurationManager.AppSettings[ConfigurationConstant.DB_SERVER_PASSWORD].Decrypt();
            string serverDatabaseName = ConfigurationManager.AppSettings[ConfigurationConstant.DB_NAME].Decrypt();

            DefaultConnectionString = string.Format(connectionString, serverAddress, serverDomain, serverDatabaseName, serverPassword);
        }
    }
}
