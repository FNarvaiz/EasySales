using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_DATOS
{
    public static class SqlConversions
    {
        public const string Null = "NULL";
        static public string toSql(this bool obj)
        {
            if (obj)
                return "1";
            return "0";
        }
        static public string MonthTwoDigit(this DateTime obj)
        {
            if (obj.Month < 10)
                    return "0"+obj.Month;
            return obj.Month.ToString();
        }
        static public string DayTwoDigit(this DateTime obj)
        {
            if (obj.Day < 10)
                return "0" + obj.Day;
            return obj.Day.ToString();
        }

        static public string toSql(this decimal obj)
        {
            return (obj.ToString()).Replace(",", ".");
        }
        public static string ToSql(this DateTime value)
        {
            return "'" + value.Year + value.MonthTwoDigit() + value.DayTwoDigit() + " " + value.ToLongTimeString() + "'";
        }
        public static string ToSqlDate(this DateTime value) {
            return "'" + value.MonthTwoDigit() + value.DayTwoDigit() + "'";
        }
    }
}
