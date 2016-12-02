using System;

namespace BrawijayaWorkshop.Utils
{
    public static class DateTimeHelperExtensionUtils
    {
        public static DateTime GetRangeFormDate(this DateTime sender)
        {
            return new DateTime(sender.Year, sender.Month, sender.Day, 0, 0, 0);
        }

        public static DateTime GetRangeToDate(this DateTime sender)
        {
            return new DateTime(sender.Year, sender.Month, sender.Day, 23, 59, 59);
        }
    }
}
