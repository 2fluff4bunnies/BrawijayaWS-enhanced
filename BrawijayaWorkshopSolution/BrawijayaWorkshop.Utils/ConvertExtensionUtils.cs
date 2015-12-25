using System;
using System.Globalization;

namespace BrawijayaWorkshop.Utils
{
    public static class ConvertExtensionUtils
    {
        public static string NumberToWordID(this decimal sender)
        {
            string strterbilang = string.Empty;

            // membuat array untuk mengubah 1 - 11 menjadi terbilang
            string[] a = { "", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas" };

            if (sender < 12)
            {
                strterbilang = " " + a[sender.AsInteger()];
            }
            else if (sender < 20)
            {
                strterbilang = NumberToWordID(sender - 10) + " belas";
            }
            else if (sender < 100)
            {
                strterbilang = NumberToWordID(sender / 10) + " puluh" + NumberToWordID(sender % 10);
            }
            else if (sender < 200)
            {
                strterbilang = " seratus" + NumberToWordID(sender - 100);
            }
            else if (sender < 1000)
            {
                strterbilang = NumberToWordID(sender / 100) + " ratus" + NumberToWordID(sender % 100);
            }
            else if (sender < 2000)
            {
                strterbilang = " seribu" + NumberToWordID(sender - 1000);
            }
            else if (sender < 1000000)
            {
                strterbilang = NumberToWordID(sender / 1000) + " ribu" + NumberToWordID(sender % 1000);
            }
            else if (sender < 1000000000)
            {
                strterbilang = NumberToWordID(sender / 1000000) + " juta" + NumberToWordID(sender % 1000000);
            }

            // menghilangkan multiple space
            strterbilang = System.Text.RegularExpressions.Regex.Replace(strterbilang, @"^\s+|\s+$", " ");

            // mengembalikan hasil terbilang
            return strterbilang;
        }

        public static byte[] StringToBytesArray(this string sender)
        {
            byte[] bytes = new byte[sender.Length * sizeof(char)];
            System.Buffer.BlockCopy(sender.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static string BytesArrayToString(this byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        public static bool AsBoolean(this object sender)
        {
            try
            {
                return Convert.ToBoolean(sender);
            }
            catch (Exception ex)
            {
                throw new ConvertExtentionUtilsException("An error occured while trying to convert: " + sender +
                    " into Boolean", ex);
            }
        }

        public static DateTime AsDateTime(this object sender, DateTimeFormatInfo dateTimeFormatInfo = null)
        {
            try
            {
                if (dateTimeFormatInfo != null)
                {
                    return Convert.ToDateTime(sender, dateTimeFormatInfo);
                }

                return Convert.ToDateTime(sender);
            }
            catch (Exception ex)
            {
                throw new ConvertExtentionUtilsException("An error occured while trying to convert: " + sender +
                    " into DateTime", ex);
            }
        }

        public static int AsInteger(this object sender)
        {
            try
            {
                return Convert.ToInt32(sender);
            }
            catch (Exception ex)
            {
                throw new ConvertExtentionUtilsException("An error occured while trying to convert: " + sender +
                    " into Integer", ex);
            }
        }

        public static double AsDouble(this object sender)
        {
            try
            {
                return Convert.ToDouble(sender);
            }
            catch (Exception ex)
            {
                throw new ConvertExtentionUtilsException("An error occured while trying to convert: " + sender +
                    " into Double", ex);
            }
        }

        public static decimal AsDecimal(this object sender)
        {
            try
            {
                return Convert.ToDecimal(sender);
            }
            catch (Exception ex)
            {
                throw new ConvertExtentionUtilsException("An error occured while trying to convert: " + sender +
                   " into Decimal", ex);
                throw;
            }
        }
    }

    public class ConvertExtentionUtilsException : Exception
    {
        public ConvertExtentionUtilsException(string errorMessage, Exception innerException)
            : base(errorMessage, innerException) { }
    }
}
