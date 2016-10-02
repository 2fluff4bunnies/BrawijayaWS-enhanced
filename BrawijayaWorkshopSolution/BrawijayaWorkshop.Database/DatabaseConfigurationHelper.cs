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
            string serverPassword = ConfigurationManager.AppSettings[ConfigurationConstant.DB_SERVER_PASSWORD];
            if(!string.IsNullOrEmpty(serverPassword))
            {
                serverPassword = serverPassword.Decrypt();
            }
            string serverDatabaseName = ConfigurationManager.AppSettings[ConfigurationConstant.DB_NAME].Decrypt();

            if(string.IsNullOrEmpty(serverPassword))
            {
                DefaultConnectionString = string.Format("server={0};Uid={1};database={2};", serverAddress, serverDomain, serverDatabaseName);
            }
            else
            {
                DefaultConnectionString = string.Format(connectionString, serverAddress, serverDomain, serverDatabaseName, serverPassword);
            }
        }
    }
}
