using BrawijayaWorkshop.Database;
using BrawijayaWorkshop.Database.Entities;
using BrawijayaWorkshop.Database.Repositories;
using BrawijayaWorkshop.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;

namespace BrawijayaWorkshop.DataInitializerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //DataInitializer();
            DataImporter();
        }


        public static void DataImporter()
        {
            BrawijayaWorkshopDbContext contextTemp = new BrawijayaWorkshopDbContext(
                new MySqlConnection(ConfigurationManager.ConnectionStrings["TempConn"].ConnectionString), true);

            BrawijayaWorkshopDbContext contextDest = new BrawijayaWorkshopDbContext(
                new MySqlConnection(ConfigurationManager.ConnectionStrings["DestConn"].ConnectionString), true);
            contextDest.Database.CreateIfNotExists();

            //get all data from temp db
            List<ApplicationModul> ApplicationModulList = contextTemp.ApplicationModuls.ToList();
            List<Role> RoleList = contextTemp.Roles.ToList();
            List<Setting> SettingList = contextTemp.Settings.ToList();
            List<Reference> ReferenceList = contextTemp.References.ToList();
            List<User> UserList = contextTemp.Users.ToList();
            List<JournalMaster> JournalMasterList = contextTemp.JournalMasters.ToList();
            List<Brand> BrandList = contextTemp.Brands.ToList();
            List<BrawijayaWorkshop.Database.Entities.Type> TypeList = contextTemp.Types.ToList();
            List<City> CityList = contextTemp.Cities.ToList();

            List<RoleAccess> RoleAccessList = contextTemp.RoleAccesses.ToList();
            List<UserRole> UserRoleList = contextTemp.UserRoles.ToList();

            List<Customer> CustomerList = contextTemp.Customers.ToList();
            List<VehicleGroup> VehicleGroupList = contextTemp.VehicleGroups.ToList();
            List<Vehicle> VehicleList = contextTemp.Vehicles.ToList();
            List<VehicleDetail> VehicleDetailList = contextTemp.VehicleDetails.ToList();

            List<Mechanic> MechanicList = contextTemp.Mechanics.ToList();

            List<Supplier> SupplierList = contextTemp.Suppliers.ToList();
            List<Sparepart> SparepartList = contextTemp.Spareparts.ToList();
            List<SpecialSparepart> SpecialSparepartList = contextTemp.Wheels.ToList();

            List<SparepartManualTransaction> SparepartManualTransactionList = contextTemp.SparepartManualTransactions.ToList();
            List<Purchasing> PurchasingTransactionList = contextTemp.Purchasings.ToList();
            List<PurchasingDetail> PurchasingDetailList = contextTemp.PurchasingDetails.ToList();
            List<PurchaseReturn> PurchaseReturnList = contextTemp.PurchaseReturns.ToList();
            List<PurchaseReturnDetail> PurchaseReturnDetailList = contextTemp.PurchaseReturnDetails.ToList();
            
            List<SparepartDetail> SparepartDetailList = contextTemp.SparepartDetails.ToList();
            List<SpecialSparepartDetail> SpecialSparepartDetailList = contextTemp.WheelDetails.ToList();
            List<VehicleWheel> VehicleWheelList = contextTemp.VehicleWheels.ToList();

            List<UsedGood> UsedGoodList = contextTemp.UsedGoods.ToList();
            List<UsedGoodTransaction> UsedGoodTransactionList = contextTemp.UsedGoodsTransactions.ToList();

            List<GuestBook> GuestBookList = contextTemp.GuestBooks.ToList();

            List<SPK> SPKList = contextTemp.SPKs.ToList();
            List<SPKDetailSparepart> SPKDetailSparepartList = contextTemp.SPKDetailSpareparts.ToList();
            List<SPKDetailSparepartDetail> SPKDetailSparepartDetailList = contextTemp.SPKDetailSparepartDetails.ToList();
            List<SPKSchedule> SPKScheduleList = contextTemp.SPKSchedules.ToList();
            List<WheelExchangeHistory> WheelExchangeHistoryList = contextTemp.WheelExchangeHistories.ToList();

            List<Invoice> InvoiceList = contextTemp.Invoices.ToList();
            List<InvoiceDetail> InvoiceDetailList = contextTemp.InvoiceDetails.ToList();
            List<SalesReturn> SalesReturnList = contextTemp.SalesReturns.ToList();
            List<SalesReturnDetail> SalesReturnDetailList = contextTemp.SalesReturnDetails.ToList();

            List<Transaction> TransactionList = contextTemp.Transactions.ToList();
            List<TransactionDetail> TransactionDetailList = contextTemp.TransactionDetails.ToList();

            List<BalanceJournal> BalanceJournalList = contextTemp.BalanceJournals.ToList();
            List<BalanceJournalDetail> BalanceJournalDetailList = contextTemp.BalanceJournalDetails.ToList();

            Dictionary<int, Role> dictRole = new Dictionary<int, Role>();
            Dictionary<int, User> dictUser = new Dictionary<int, User>();
            Dictionary<int, City> dictCity = new Dictionary<int, City>();

            //applicationmodul
            foreach (var item in ApplicationModulList)
            {
                item.Id = -1;
                contextDest.ApplicationModuls.Add(item);
            }

            //role
            foreach (var item in RoleList)
            {
                int itemOldId = item.Id;
                item.Id = -1;
                Role newItem =  contextDest.Roles.Add(item);
                dictRole.Add(itemOldId, newItem);
            }

            //setting
            foreach (var item in SettingList)
            {
                contextDest.Settings.Add(item);
            }

            //reference
            foreach (var item in ReferenceList)
            {
                item.Id = -1;
                contextDest.References.Add(item);
            }

            //user
            foreach (var item in UserList)
            {
                int itemOldId = item.Id;
                item.Id = -1;
                User newItem = contextDest.Users.Add(item);
                dictUser.Add(itemOldId, newItem);
            }

            //journalMaster
            foreach (var item in JournalMasterList)
            {
                item.Id = -1;
                contextDest.JournalMasters.Add(item);
            }

            //brand
            foreach (var item in BrandList)
            {
                item.Id = -1;
                contextDest.Brands.Add(item);
            }

            //type
            foreach (var item in TypeList)
            {
                item.Id = -1;
                contextDest.Types.Add(item);
            }

            //city
            foreach (var item in CityList)
            {
                int itemOldId = item.Id;
                item.Id = -1;
                City newItem = contextDest.Cities.Add(item);
                dictCity.Add(itemOldId, newItem);
            }

            //role access
            foreach (var item in RoleAccessList)
            {
                Role role = dictRole[item.RoleId];
                item.Id = -1;
                item.Role = role;
                contextDest.RoleAccesses.Add(item);
            }

            //user role
            foreach (var item in UserRoleList)
            {
                Role role = dictRole[item.RoleId];
                User user = dictUser[item.UserId];
                item.Id = -1;
                item.Role = role;
                item.User = user;
                contextDest.UserRoles.Add(item);
            }

            //customer
            foreach (var item in CustomerList)
            {
                City city = dictCity[item.CityId];
                item.Id = -1;
                item.City = city;
                contextDest.Customers.Add(item);
            }
            contextDest.SaveChanges();

            Console.Write("Done");
            Console.Read();
        }



        public static void DataInitializer()
        {
            string dirPath = "D:/Documents/Bengkel App/Data/";
            string accFile = "Account Jurnal.xlsx";
            string invFile = "Inv.xlsx";
            string citFile = "City.xlsx";
            string balJournal = "BalanceJournal.xlsx";

            try
            {
                // todo: read excel inventory and acc and insert into temporary table
                DataTable resultInv = DataExportImportUtils.CreateDataTableFromExcel(dirPath + invFile, true);
                DataTable resultAcc = DataExportImportUtils.CreateDataTableFromExcel(dirPath + accFile, true);
                DataTable resultCit = DataExportImportUtils.CreateDataTableFromExcel(dirPath + citFile, true);
                DataTable resultCatJournal = DataExportImportUtils.CreateDataTableFromExcel(dirPath + balJournal, true);

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"CREATE TABLE `temp_catjournal` (
                                          `Code` varchar(100) DEFAULT NULL,
                                          `Name` varchar(100) DEFAULT NULL,
                                          `Description` varchar(100) DEFAULT NULL,
                                          `Value` varchar(100) DEFAULT NULL,
                                          `Parent` varchar(100) DEFAULT NULL
                                        ) ENGINE=InnoDB DEFAULT CHARSET=utf8;";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                }
                catch (Exception ex)
                {
                    if (ex != null) { }
                    // do nothing
                }

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"CREATE TABLE `temp_cit` (
                                          `Id` varchar(100) DEFAULT NULL,
                                          `Code` varchar(100) DEFAULT NULL,
                                          `Name` varchar(100) DEFAULT NULL
                                        ) ENGINE=InnoDB DEFAULT CHARSET=utf8;";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                }
                catch (Exception ex)
                {
                    if (ex != null) { }
                    // do nothing
                }

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"CREATE TABLE `temp_inv` (
                                          `Kode` varchar(100) DEFAULT NULL,
                                          `Nama` varchar(100) DEFAULT NULL,
                                          `Qmin` double DEFAULT NULL,
                                          `Unit` varchar(10) DEFAULT NULL,
                                          `Chusr` int(11) DEFAULT NULL,
                                          `Chtime` varchar(100) DEFAULT NULL,
                                          `Jenis` varchar(100) DEFAULT NULL,
                                          `Price` double DEFAULT NULL,
                                          `ACC` varchar(45) DEFAULT NULL,
                                          `LAMA` int(11) DEFAULT NULL
                                        ) ENGINE=InnoDB DEFAULT CHARSET=utf8;";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                }
                catch (Exception ex)
                {
                    if (ex != null) { }
                    // do nothing
                }

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"CREATE TABLE `temp_acc` (
                                          `Kode` varchar(100) DEFAULT NULL,
                                          `Nama` varchar(100) DEFAULT NULL,
                                          `Induk` varchar(100) DEFAULT NULL
                                        ) ENGINE=InnoDB DEFAULT CHARSET=utf8;";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                }
                catch (Exception ex)
                {
                    if (ex != null) { }
                    // do nothing
                }

                if (resultCatJournal != null)
                {
                    resultCatJournal.ExportDataTableToCsv(dirPath + "catjournal.csv");

                    // insert into database
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        conn.Open();

                        MySqlBulkLoader loader = new MySqlBulkLoader(conn);
                        loader.TableName = "temp_catjournal";
                        loader.FieldTerminator = "\t";
                        loader.LineTerminator = "\n";
                        loader.FileName = dirPath + "catjournal.csv";
                        loader.NumberOfLinesToSkip = 1;
                        int inserted = loader.Load();
                        Console.WriteLine("Total rows: " + inserted);

                        conn.Close();
                    }

                    // insert into database main ref
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"INSERT INTO `references` (`Code`, `Name`, `Description`, `Value`, `ParentId`)
                                            SELECT REPLACE(REPLACE(`code`, '\r', ''), '\n', ''), `Name`, `Description`, `Value`,
                                            (SELECT `Id` FROM `references` WHERE `Code`=REPLACE(REPLACE(`parent`, '\r', ''), '\n', ''))
                                            FROM temp_catjournal";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                    //                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    //                    {
                    //                        MySqlCommand cmd = conn.CreateCommand();
                    //                        cmd.CommandText = @"UPDATE `references` a
                    //                                            SET a.ParentId = (SELECT z.Id FROM (SELECT x.*, y.Code `Kode` FROM `references` x, temp_catjournal y WHERE x.Code=y.Parent) z WHERE z.Kode=a.Code)";
                    //                        cmd.CommandType = CommandType.Text;
                    //                        conn.Open();
                    //                        cmd.ExecuteNonQuery();
                    //                        conn.Clone();
                    //                    }
                }

                if (resultCit != null)
                {
                    resultCit.ExportDataTableToCsv(dirPath + "city.csv");

                    // insert into database
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        conn.Open();

                        MySqlBulkLoader loader = new MySqlBulkLoader(conn);
                        loader.TableName = "temp_cit";
                        loader.FieldTerminator = "\t";
                        loader.LineTerminator = "\n";
                        loader.FileName = dirPath + "city.csv";
                        loader.NumberOfLinesToSkip = 1;
                        int inserted = loader.Load();
                        Console.WriteLine("Total rows: " + inserted);

                        conn.Close();
                    }

                    // insert into database city
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"INSERT INTO cities (`Code`, `Name`)
                                            SELECT `Code`, `Name`
                                            FROM temp_cit";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                }

                if (resultInv != null)
                {
                    // fix typing error
                    foreach (DataRow iRow in resultInv.Rows)
                    {
                        if (iRow["Kode"].ToString().Contains("["))
                        {
                            iRow["Kode"] = iRow["Kode"].ToString().Replace("[", "");
                        }
                        if (iRow["Unit"].ToString().Contains("PV"))
                        {
                            iRow["Unit"] = "PC";
                        }
                    }

                    // convert to csv
                    resultInv.ExportDataTableToCsv(dirPath + "inv.csv");

                    // insert into database
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        conn.Open();

                        MySqlBulkLoader loader = new MySqlBulkLoader(conn);
                        loader.TableName = "temp_inv";
                        loader.FieldTerminator = "\t";
                        loader.LineTerminator = "\n";
                        loader.FileName = dirPath + "inv.csv";
                        loader.NumberOfLinesToSkip = 1;
                        int inserted = loader.Load();
                        Console.WriteLine("Total rows: " + inserted);

                        conn.Close();
                    }

                    // generate main sparepart data
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"INSERT INTO spareparts (`Code`, `Name`, `StockQty`, `UnitReferenceId`, `CategoryReferenceId`, `CreateDate`, `CreateUserId`, `ModifyDate`, `ModifyUserId`, `Status`)
                                            SELECT Kode, Nama, 0,
                                            IFNULL((SELECT a.`Id` FROM `references` a WHERE a.`ParentId`=(SELECT Id FROM `references` WHERE Code='REF_SPAREPARTUNIT') AND a.`Code`=Unit),
                                            (SELECT a.`Id` FROM `references` a WHERE a.`ParentId`=(SELECT Id FROM `references` WHERE Code='REF_SPAREPARTUNIT') AND a.`Code`='-')),
                                            IFNULL((SELECT a.`Id` FROM `references` a WHERE a.`ParentId`=(SELECT Id FROM `references` WHERE Code='REF_SPAREPARTCATEGORY') AND a.`Code`=SUBSTR(Kode, 1, LENGTH(a.`Code`))),
                                            (SELECT a.`Id` FROM `references` a WHERE a.`ParentId`=(SELECT Id FROM `references` WHERE Code='REF_SPAREPARTCATEGORY') AND a.`Code`='-')),
                                            current_date(), (SELECT Id FROM users WHERE UserName='superadmin'),
                                            current_date(), (SELECT Id FROM users WHERE UserName='superadmin'), 1
                                            FROM temp_inv";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }

                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "DELETE FROM temp_inv";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                }

                if (resultAcc != null)
                {
                    foreach (DataRow row in resultAcc.Rows)
                    {
                        row["Kode"] = row["Kode"].ToString().Trim();
                        try
                        {
                            row["Induk"] = row["Induk"].ToString();
                        }
                        catch { }
                    }

                    // convert to csv
                    resultAcc.ExportDataTableToCsv(dirPath + "acc.csv");

                    // insert into database
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        conn.Open();

                        MySqlBulkLoader loader = new MySqlBulkLoader(conn);
                        loader.TableName = "temp_acc";
                        loader.FieldTerminator = "\t";
                        loader.LineTerminator = "\n";
                        loader.FileName = dirPath + "acc.csv";
                        loader.NumberOfLinesToSkip = 1;
                        int inserted = loader.Load();
                        Console.WriteLine("Total rows: " + inserted);

                        conn.Close();
                    }

                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"UPDATE temp_acc SET Induk=REPLACE(REPLACE(Induk, '\r', ''), '\n', '')";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }

                    // generate main account data
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"INSERT INTO journalmasters (`Code`, `Name`, `ParentId`)
                                            SELECT `Kode`, `Nama`,
                                            (SELECT a.Id FROM journalmasters a, temp_acc b WHERE a.Code=b.Induk)
                                            FROM temp_acc";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"UPDATE journalmasters a
                                            SET a.ParentId = (SELECT z.Id FROM (SELECT x.*, y.Kode FROM journalmasters x, temp_acc y WHERE x.Code=y.Induk) z WHERE z.Kode=a.Code)";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }
                }

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = @"DROP TABLE temp_catjournal";
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Clone();
                }

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = @"DROP TABLE temp_cit";
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Clone();
                }

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = @"DROP TABLE temp_inv";
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Clone();
                }

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = @"DROP TABLE temp_acc";
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Clone();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
