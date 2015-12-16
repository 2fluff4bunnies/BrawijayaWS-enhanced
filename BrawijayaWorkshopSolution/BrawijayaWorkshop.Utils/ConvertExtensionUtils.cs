using System;
using System.Globalization;

namespace BrawijayaWorkshop.Utils
{
    public static class ConvertExtensionUtils
    {
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
