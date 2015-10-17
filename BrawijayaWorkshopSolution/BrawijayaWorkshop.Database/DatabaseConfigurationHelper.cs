using BrawijayaWorkshop.Constant;
using System.Configuration;

namespace BrawijayaWorkshop.Database
{
    public static class DatabaseConfigurationHelper
    {
        public static string DefaultConnectionString { get; private set; }

        static DatabaseConfigurationHelper()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[ConfigurationConstant.DB_CONNECTION_STRING_NAME].ConnectionString;
            string serverAddress = ConfigurationManager.AppSettings[ConfigurationConstant.DB_SERVER_ADDRESS];
            string serverDomain = ConfigurationManager.AppSettings[ConfigurationConstant.DB_SERVER_DOMAIN];
            string serverPassword = ConfigurationManager.AppSettings[ConfigurationConstant.DB_SERVER_PASSWORD];
            string serverDatabaseName = ConfigurationManager.AppSettings[ConfigurationConstant.DB_NAME];

            DefaultConnectionString = string.Format(connectionString, serverAddress, serverDomain, serverDatabaseName, serverPassword);
        }
    }
}
