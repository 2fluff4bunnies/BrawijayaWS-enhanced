using System;
using System.Globalization;

namespace BrawijayaWorkshop.Utils
{
    public static class ConvertExtensionUtils
    {
        static string[] satuan = new string[10] { "Nol", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", "Delapan", "Sembilan" };
        static string[] belasan = new string[10] { "Sepuluh", "Sebelas", "Dua Belas", "Tiga Belas", "Empat Belas", "Lima Belas", "Enam Belas", "Tujuh Belas", "Delapan Belas", "sembilan belas" };
        static string[] puluhan = new string[10] { "", "", "Dua Puluh", "Tiga Puluh", "Empat Puluh", "Lima Puluh", "Enam Puluh", "Tujuh Puluh", "Delapan Puluh", "Sembilan Puluh" };
        static string[] ribuan = new string[5] { "", "Ribu", "Juta", "Milyar", "Triliyun" };

        public static string NumberToWordID(this decimal sender)
        {
            return GetWordsFromNumber(sender);
        }

        private static string GetWordsFromNumber(decimal angka)
        {
            string strHasil = "";
            Decimal frac = angka - Decimal.Truncate(angka);

            if (Decimal.Compare(frac, 0.0m) != 0)
                strHasil = GetWordsFromNumber(Decimal.Round(frac * 100)) + " Sen";
            else
                strHasil = "Rupiah";
            int xDigit = 0;
            int xPosisi = 0;

            string strTemp = Decimal.Truncate(angka).ToString();
            for (int i = strTemp.Length; i > 0; i--)
            {
                string tmpx = "";
                xDigit = Convert.ToInt32(strTemp.Substring(i - 1, 1));
                xPosisi = (strTemp.Length - i) + 1;
                switch (xPosisi % 3)
                {
                    case 1:
                        bool allNull = false;
                        if (i == 1)
                            tmpx = satuan[xDigit] + " ";
                        else if (strTemp.Substring(i - 2, 1) == "1")
                            tmpx = belasan[xDigit] + " ";
                        else if (xDigit > 0)
                            tmpx = satuan[xDigit] + " ";
                        else
                        {
                            allNull = true;
                            if (i > 1)
                                if (strTemp.Substring(i - 2, 1) != "0")
                                    allNull = false;
                            if (i > 2)
                                if (strTemp.Substring(i - 3, 1) != "0")
                                    allNull = false;
                            tmpx = "";
                        }

                        if ((!allNull) && (xPosisi > 1))
                            if ((strTemp.Length == 4) && (strTemp.Substring(0, 1) == "1"))
                                tmpx = "Se" + ribuan[(int)Decimal.Round(xPosisi / 3m)] + " ";
                            else
                                tmpx = tmpx + ribuan[(int)Decimal.Round(xPosisi / 3)] + " ";
                        strHasil = tmpx + strHasil;
                        break;
                    case 2:
                        if (xDigit > 0)
                            strHasil = puluhan[xDigit] + " " + strHasil;
                        break;
                    case 0:
                        if (xDigit > 0)
                            if (xDigit == 1)
                                strHasil = "Seratus " + strHasil;
                            else
                                strHasil = satuan[xDigit] + " Ratus " + strHasil;
                        break;
                }
            }
            strHasil = strHasil.Trim().ToLower();
            if (strHasil.Length > 0)
            {
                strHasil = strHasil.Substring(0, 1).ToUpper() + strHasil.Substring(1, strHasil.Length - 1);
            }
            return strHasil;
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
                if (string.IsNullOrEmpty(sender.ToString()))
                {
                    return false;
                }

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
                if (string.IsNullOrEmpty(sender.ToString()))
                {
                    return 0;
                }

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
                if(string.IsNullOrEmpty(sender.ToString()))
                {
                    return 0;
                }

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
                if(string.IsNullOrEmpty(sender.ToString()))
                {
                    return 0M;
                }

                throw new ConvertExtentionUtilsException("An error occured while trying to convert: " + sender +
                   " into Decimal", ex);
            }
        }
    }

    public class ConvertExtentionUtilsException : Exception
    {
        public ConvertExtentionUtilsException(string errorMessage, Exception innerException)
            : base(errorMessage, innerException) { }
    }
}
