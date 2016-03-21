using BrawijayaWorkshop.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace BrawijayaWorkshop.DataInitializerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = "D:/Documents/Bengkel App/Data/";
            string accFile = "Account Jurnal.xlsx";
            string invFile = "Inv.xlsx";
            string citFile = "City.xlsx";
            try
            {
                try
                {
                    using(MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
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

                // todo: read excel inventory and acc and insert into temporary table
                DataTable resultInv = DataExportImportUtils.CreateDataTableFromExcel(dirPath + invFile, true);
                DataTable resultAcc = DataExportImportUtils.CreateDataTableFromExcel(dirPath + accFile, true);
                DataTable resultCit = DataExportImportUtils.CreateDataTableFromExcel(dirPath + citFile, true);
                if (resultCit != null)
                {
                    resultCit.ExportDataTableToCsv(dirPath + "city.csv");
                    // insert into database
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        conn.Open();

                        MySqlBulkLoader loader = new MySqlBulkLoader(conn);
                        loader.TableName = "cities";
                        loader.FieldTerminator = "\t";
                        loader.LineTerminator = "\n";
                        loader.FileName = dirPath + "city.csv";
                        loader.NumberOfLinesToSkip = 1;
                        int inserted = loader.Load();
                        Console.WriteLine("Total rows: " + inserted);

                        conn.Close();
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
                        cmd.CommandText = @"INSERT INTO journalmasters (`Code`, `Name`, `ParentId`, `IsProfitLoss`)
                                            SELECT `Kode`, `Nama`,
                                            (SELECT a.Id FROM journalmasters a, temp_acc b WHERE a.Code=b.Induk), ProfitLoss
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
