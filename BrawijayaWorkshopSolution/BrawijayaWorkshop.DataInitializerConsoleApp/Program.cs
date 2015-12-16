using BrawijayaWorkshop.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace BrawijayaWorkshop.DataInitializerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = "D:/Documents/Bengkel App/";
            string accFile = "Account Jurnal.xlsx";
            string invFile = "Inv.xlsx";

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
                        if(string.IsNullOrEmpty(row["Induk"].ToString()))
                        {
                            row["Induk"] = DBNull.Value;
                        }
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

                    // generate main account data
                    using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = @"INSERT INTO journalmasters (`Code`, `Name`, `ParentId`)
                                            SELECT Kode, Nama,
                                            (SELECT a.`Id` FROM journalmasters a WHERE a.`Code`=x.`Induk`)
                                            FROM temp_acc x";
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Clone();
                    }

                    //// generate main account data
                    //using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString))
                    //{
                    //    MySqlCommand cmd = conn.CreateCommand();
                    //    cmd.CommandText = @"UPDATE journalmasters SET ParentId=(SELECT Id FROM journalmasters WHERE Code=";
                    //    cmd.CommandType = CommandType.Text;
                    //    conn.Open();
                    //    cmd.ExecuteNonQuery();
                    //    conn.Clone();
                    //}
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
