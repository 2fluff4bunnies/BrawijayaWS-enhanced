using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace BrawijayaWorkshop.Utils
{
    public static class DataExportImportUtils
    {
        public static void ExportDataTableToCsv(this DataTable source, string path, string columnDelimiter = "\t")
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                IEnumerable<string> columnNames = source.Columns.Cast<DataColumn>().
                                                  Select(column => column.ColumnName);
                sb.AppendLine(string.Join(columnDelimiter, columnNames));
                foreach (DataRow csvRow in source.Rows)
                {
                    IEnumerable<string> fields = csvRow.ItemArray.Select(field => field.ToString());
                    sb.AppendLine(string.Join(columnDelimiter, fields));
                }
                File.WriteAllText(path, sb.ToString());
            }
            catch (Exception ex)
            {
                throw new DataExportImportUtilsException("An error occured while trying to export data table to csv", ex);
            }
        }

        public static DataSet CreateDataSetFromExcel(string path, bool isFirstRowHeader)
        {
            try
            {
                DataSet result = new DataSet();

                XSSFWorkbook workbook;
                using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    workbook = new XSSFWorkbook(file);
                }

                for (int iSheetIndex = 0; iSheetIndex < workbook.Count; iSheetIndex++)
                {
                    int rowIndex = 0;
                    DataTable dataTable = new DataTable();
                    ISheet sheet = workbook.GetSheetAt(iSheetIndex);
                    if (isFirstRowHeader)
                    {
                        IRow row = sheet.GetRow(rowIndex);
                        if (row != null)
                        {
                            int colIndex = 0;
                            while (colIndex < row.Cells.Count)
                            {
                                ICell cell = row.GetCell(colIndex);
                                dataTable.Columns.Add(cell.StringCellValue);
                                colIndex++;
                            }
                            rowIndex++;
                        }
                    }
                    for (int row = rowIndex; row < sheet.LastRowNum; row++)
                    {
                        IRow iRow = sheet.GetRow(row);
                        if (iRow != null)
                        {
                            DataRow newRow = dataTable.NewRow();
                            int colIndex = 0;
                            while (colIndex < iRow.Cells.Count)
                            {
                                ICell cell = iRow.GetCell(colIndex);
                                switch (cell.CellType)
                                {
                                    case CellType.Numeric:
                                        newRow[colIndex] = cell.NumericCellValue;
                                        break;
                                    default:
                                        newRow[colIndex] = cell.StringCellValue;
                                        break;
                                }

                                colIndex++;
                            }
                            dataTable.Rows.Add(newRow);
                        }
                    }

                    result.Tables.Add(dataTable);
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new DataExportImportUtilsException("An error occured while trying to create DataSet from excel data: " + path, ex);
            }
        }

        public static DataTable CreateDataTableFromExcel(string path, bool isFirstRowHeader)
        {
            try
            {
                XSSFWorkbook workbook;
                using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    workbook = new XSSFWorkbook(file);
                }

                int rowIndex = 0;
                DataTable result = new DataTable();
                ISheet sheet = workbook.GetSheetAt(0);
                if (isFirstRowHeader)
                {
                    IRow row = sheet.GetRow(rowIndex);
                    if (row != null)
                    {
                        int colIndex = 0;
                        while (colIndex < row.Cells.Count)
                        {
                            ICell cell = row.GetCell(colIndex);
                            result.Columns.Add(cell.StringCellValue);
                            colIndex++;
                        }
                        rowIndex++;
                    }
                }
                for (int row = rowIndex; row < sheet.LastRowNum; row++)
                {
                    IRow iRow = sheet.GetRow(row);
                    if (iRow != null)
                    {
                        DataRow newRow = result.NewRow();
                        int colIndex = 0;
                        while (colIndex < iRow.Cells.Count)
                        {
                            ICell cell = iRow.GetCell(colIndex);
                            switch(cell.CellType)
                            {
                                case CellType.Numeric:
                                    newRow[colIndex] = cell.NumericCellValue;
                                    break;
                                default:
                                    newRow[colIndex] = cell.StringCellValue;
                                    break;
                            }
                            
                            colIndex++;
                        }
                        result.Rows.Add(newRow);
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new DataExportImportUtilsException("An error occured while trying to create DataTable from excel data: " + path, ex);
            }
        }
    }

    public class DataExportImportUtilsException : Exception
    {
        public DataExportImportUtilsException(string errorMessage, Exception innerException)
            : base(errorMessage, innerException) { }
    }
}
