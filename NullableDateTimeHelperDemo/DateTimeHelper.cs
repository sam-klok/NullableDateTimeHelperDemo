using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableDateTimeHelperDemo
{
    public static class DateTimeHelper
    {
        public static DateTime DateOnly(this DateTime date)
        {
            return date.Date;
        }

        public static DateTime? NullableDateOnly(this DateTime? date)
        {
            if (date == null)
                return null;

            return date.Value.Date;
        }

    }
}
