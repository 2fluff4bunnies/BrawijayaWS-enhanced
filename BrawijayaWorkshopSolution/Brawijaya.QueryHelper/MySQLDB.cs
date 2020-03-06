using BrawijayaWorkshop.Constant;
using BrawijayaWorkshop.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brawijaya.QueryHelper
{
    public class MySQLDB
    {
        public MySqlConnection connection;
        public string DefaultConnectionString;

        public MySQLDB()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings[ConfigurationConstant.DB_CONNECTION_STRING_NAME].ConnectionString;
            string serverAddress = ConfigurationManager.AppSettings[ConfigurationConstant.DB_SERVER_ADDRESS].Decrypt();
            string serverDomain = ConfigurationManager.AppSettings[ConfigurationConstant.DB_SERVER_DOMAIN].Decrypt();
            string serverPassword = ConfigurationManager.AppSettings[ConfigurationConstant.DB_SERVER_PASSWORD];
            if (!string.IsNullOrEmpty(serverPassword))
            {
                serverPassword = serverPassword.Decrypt();
            }
            string serverDatabaseName = ConfigurationManager.AppSettings[ConfigurationConstant.DB_NAME].Decrypt();

            if (string.IsNullOrEmpty(serverPassword))
            {
                DefaultConnectionString = string.Format("server={0};Uid={1};database={2};", serverAddress, serverDomain, serverDatabaseName);
            }
            else
            {
                DefaultConnectionString = string.Format(connectionString, serverAddress, serverDomain, serverDatabaseName, serverPassword);
            }

            connection = new MySqlConnection(DefaultConnectionString);
        }

        public void DeletePurchasingsComplete()
        {
            connection.Open();
            string queryDelIvcDetail = "delete from invoicedetails";
            MySqlCommand cmdDelIvcDetail = new MySqlCommand(queryDelIvcDetail, connection);
            cmdDelIvcDetail.ExecuteNonQuery();
            Console.WriteLine("delete invoicedetails");

            string queryDelIvc = "delete from invoices";
            MySqlCommand cmdDelIvc = new MySqlCommand(queryDelIvc, connection);
            cmdDelIvc.ExecuteNonQuery();
            Console.WriteLine("delete invoices");

            string queryDelspkschedules = "delete from spkschedules";
            MySqlCommand cmdDelspkschedules = new MySqlCommand(queryDelspkschedules, connection);
            cmdDelspkschedules.ExecuteNonQuery();
            Console.WriteLine("delete spkschedules");

            string queryDelspkdetailsparepartdetails = "delete from spkdetailsparepartdetails";
            MySqlCommand cmdDelspkdetailsparepartdetails = new MySqlCommand(queryDelspkdetailsparepartdetails, connection);
            cmdDelspkdetailsparepartdetails.ExecuteNonQuery();
            Console.WriteLine("delete spkdetailsparepartdetails");

            string queryDelspkdetailspareparts = "delete from spkdetailspareparts";
            MySqlCommand cmdDelspkdetailspareparts = new MySqlCommand(queryDelspkdetailspareparts, connection);
            cmdDelspkdetailspareparts.ExecuteNonQuery();
            Console.WriteLine("delete spkdetailspareparts");

            string queryDelspks = "delete from spks";
            MySqlCommand cmdDelspks = new MySqlCommand(queryDelspks, connection);
            cmdDelspks.ExecuteNonQuery();
            Console.WriteLine("delete spks");

            string queryParentStockCardId = "SELECT ParentStockCardId FROM sparepartstockcarddetails where PurchasingId IS NOT NULL";

            //Create a list to store the result
            List<string>[] listParentStockCardId = new List<string>[1];
            listParentStockCardId[0] = new List<string>();
            //Create Command
            MySqlCommand cmdParentStockCardId = new MySqlCommand(queryParentStockCardId, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReaderParentStockCardId = cmdParentStockCardId.ExecuteReader();

            //Read the data and store them in the list
            while (dataReaderParentStockCardId.Read())
            {
                listParentStockCardId[0].Add(dataReaderParentStockCardId["ParentStockCardId"] + "");
            }
            //close Data Reader
            dataReaderParentStockCardId.Close();

            string queryDelsparepartstockcarddetails = "delete from sparepartstockcarddetails where PurchasingId IS NOT NULL";
            MySqlCommand cmdDelsparepartstockcarddetails = new MySqlCommand(queryDelsparepartstockcarddetails, connection);
            cmdDelsparepartstockcarddetails.ExecuteNonQuery();
            Console.WriteLine("delete sparepartstockcarddetails");

            foreach (var itemParentStockCardId in listParentStockCardId[0])
            {
                string queryDelsparepartstockcards = "delete from sparepartstockcards where Id =" + itemParentStockCardId;
                MySqlCommand cmdDelsparepartstockcards = new MySqlCommand(queryDelsparepartstockcarddetails, connection);
                cmdDelsparepartstockcards.ExecuteNonQuery();
            }
            Console.WriteLine("delete sparepartstockcards");

            string queryDelspecialsparepartdetails = "delete from specialsparepartdetails where PurchasingDetailId IS NOT NULL";
            MySqlCommand cmdDelspecialsparepartdetails = new MySqlCommand(queryDelspecialsparepartdetails, connection);
            cmdDelspecialsparepartdetails.ExecuteNonQuery();
            Console.WriteLine("delete specialsparepartdetails");

            string queryDelpurchasingdetails = "delete from purchasingdetails";
            MySqlCommand cmdDelpurchasingdetails = new MySqlCommand(queryDelpurchasingdetails, connection);
            cmdDelpurchasingdetails.ExecuteNonQuery();
            Console.WriteLine("delete purchasingdetails");

            string queryDelpurchasings = "delete from purchasings";
            MySqlCommand cmdDelpurchasings = new MySqlCommand(queryDelpurchasings, connection);
            cmdDelpurchasings.ExecuteNonQuery();
            Console.WriteLine("delete purchasings");

            connection.Close();
        }

        public void DeleteSparepartNotSpecial()
        {
            connection.Open();

            string queryParentStockCardId = "SELECT sc.Id FROM sparepartstockcards sc JOIN spareparts s on  s.Id = sc.SparepartId where s.IsSpecialSparepart = 0";

            //Create a list to store the result
            List<string>[] listParentStockCardId = new List<string>[1];
            listParentStockCardId[0] = new List<string>();
            //Create Command
            MySqlCommand cmdParentStockCardId = new MySqlCommand(queryParentStockCardId, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReaderParentStockCardId = cmdParentStockCardId.ExecuteReader();

            //Read the data and store them in the list
            while (dataReaderParentStockCardId.Read())
            {
                listParentStockCardId[0].Add(dataReaderParentStockCardId["Id"] + "");
            }
            //close Data Reader
            dataReaderParentStockCardId.Close();

            
            foreach (var itemParentStockCardId in listParentStockCardId[0])
            {
                string queryDelsparepartstockcarddetails = "delete from sparepartstockcarddetails where ParentStockCardId =" + itemParentStockCardId;
                MySqlCommand cmdDelsparepartstockcarddetails = new MySqlCommand(queryDelsparepartstockcarddetails, connection);
                cmdDelsparepartstockcarddetails.ExecuteNonQuery();
            }
            Console.WriteLine("delete sparepartstockcarddetails");

            string queryDelsparepartstockcards = "delete sc from sparepartstockcards sc JOIN spareparts s on  s.Id = sc.SparepartId where s.IsSpecialSparepart = 0";
            MySqlCommand cmdDelsparepartstockcards = new MySqlCommand(queryDelsparepartstockcards, connection);
            cmdDelsparepartstockcards.ExecuteNonQuery();
            Console.WriteLine("delete sparepartstockcards");


            string querySpManualId = "SELECT sm.Id from sparepartmanualtransactions sm JOIN spareparts s on  s.Id = sm.SparepartId where s.IsSpecialSparepart = 0";

            //Create a list to store the result
            List<string>[] listSpManualId = new List<string>[1];
            listSpManualId[0] = new List<string>();
            //Create Command
            MySqlCommand cmdSpManualId = new MySqlCommand(querySpManualId, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReaderSpManualId = cmdSpManualId.ExecuteReader();

            //Read the data and store them in the list
            while (dataReaderSpManualId.Read())
            {
                listSpManualId[0].Add(dataReaderSpManualId["Id"] + "");
            }
            //close Data Reader
            dataReaderSpManualId.Close();

            foreach (var itemSpManualId in listSpManualId[0])
            {
                string queryDelsparepartstockcarddetails = "delete from sparepartstockcarddetails where SparepartManualTransactionId =" + itemSpManualId;
                MySqlCommand cmdDelsparepartstockcarddetails = new MySqlCommand(queryDelsparepartstockcarddetails, connection);
                cmdDelsparepartstockcarddetails.ExecuteNonQuery();
            }
            Console.WriteLine("delete sparepartstockcarddetails");

            string queryDelsparepartmanualtransactions = "delete sm from sparepartmanualtransactions sm JOIN spareparts s on  s.Id = sm.SparepartId where s.IsSpecialSparepart = 0";
            MySqlCommand cmdDelsparepartmanualtransactions = new MySqlCommand(queryDelsparepartmanualtransactions, connection);
            cmdDelsparepartmanualtransactions.ExecuteNonQuery();
            Console.WriteLine("delete sparepartmanualtransactions");

            string queryUpdStok = "update spareparts SET StockQty = 0 where IsSpecialSparepart = 0";
            MySqlCommand cmdUpdStok = new MySqlCommand(queryUpdStok, connection);
            cmdUpdStok.ExecuteNonQuery();
            Console.WriteLine("update spareparts");

            connection.Close();
        }

        public void DeleteSparepartSpecial()
        {
            connection.Open();

            string querySMId = @"SELECT sm.Id FROM sparepartmanualtransactions sm 
JOIN specialsparepartdetails ssd on  ssd.SparepartManualTransactionId = sm.Id
JOIN sparepartstockcarddetails sscd on  sscd.SparepartManualTransactionId = sm.Id
JOIN sparepartstockcards ssc on  ssc.Id = sscd.ParentStockCardId
JOIN spareparts s on  s.Id = ssd.SparepartId
where ssd.status = 1 and s.IsSpecialSparepart = 1";

            //Create a list to store the result
            List<string>[] listSMId = new List<string>[1];
            listSMId[0] = new List<string>();
            //Create a list to store the result
            List<string>[] listParentStockCardId = new List<string>[1];
            listParentStockCardId[0] = new List<string>();
            //Create Command
            MySqlCommand cmdSMId = new MySqlCommand(querySMId, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReaderSMId = cmdSMId.ExecuteReader();

            //Read the data and store them in the list
            while (dataReaderSMId.Read())
            {
                listSMId[0].Add(dataReaderSMId["Id"] + "");
            }
            //close Data Reader
            dataReaderSMId.Close();

            foreach (var itemSMId in listSMId[0])
            {
                string queryDelsparepartstockcarddetails = "delete from sparepartstockcarddetails where SparepartManualTransactionId=" + itemSMId;
                MySqlCommand cmdDelsparepartstockcarddetails = new MySqlCommand(queryDelsparepartstockcarddetails, connection);
                cmdDelsparepartstockcarddetails.ExecuteNonQuery();
            
            }
            Console.WriteLine("delete sparepartstockcarddetails");

            string queryDelsparepartstockcards = "delete sc from sparepartstockcards sc  LEFT JOIN sparepartstockcarddetails scd ON sc.Id=scd.ParentStockCardId where scd.Id IS NULL";
            MySqlCommand cmdDelsparepartstockcards = new MySqlCommand(queryDelsparepartstockcards, connection);
            cmdDelsparepartstockcards.ExecuteNonQuery();
            Console.WriteLine("delete sparepartstockcards");

            foreach (var itemSMId in listSMId[0])
            {
                string queryDelspecialsparepartdetails = "delete from specialsparepartdetails where SparepartManualTransactionId=" + itemSMId;
                MySqlCommand cmdDelspecialsparepartdetails = new MySqlCommand(queryDelspecialsparepartdetails, connection);
                cmdDelspecialsparepartdetails.ExecuteNonQuery();
            }
            Console.WriteLine("delete specialsparepartdetails");

            foreach (var itemSMId in listSMId[0])
            {
                string queryDelsparepartmanualtransactions = "delete from sparepartmanualtransactions where Id=" + itemSMId;
                MySqlCommand cmdDelsparepartmanualtransactions = new MySqlCommand(queryDelsparepartmanualtransactions, connection);
                cmdDelsparepartmanualtransactions.ExecuteNonQuery();
            }
            Console.WriteLine("delete sparepartmanualtransactions");

            string queryUpdStok = "update spareparts SET StockQty = 0 where IsSpecialSparepart = 1";
            MySqlCommand cmdUpdStok = new MySqlCommand(queryUpdStok, connection);
            cmdUpdStok.ExecuteNonQuery();
            Console.WriteLine("update spareparts");

            connection.Close();
        }
    }
}
