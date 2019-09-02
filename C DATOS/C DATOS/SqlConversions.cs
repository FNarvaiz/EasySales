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
       
        static public string toSql(this decimal obj)
        {
            return (obj.ToString()).Replace(",", ".");
        }
        public static string ToSql(this DateTime value)
        {
            string month = "";
            string day = "";
            if (value.Month < 10)
                month = "0";
            month += value.Month;
            if (value.Day < 10)
                day = "0";
            day += value.Day;
            return "'" + value.Year + month + day + " " + value.ToLongTimeString() + "'";
        }
        public static string ToSqlDate(this DateTime value) {
            string month = "";
            string day = "";
            if (value.Month < 10)
                month = "0";
            month += value.Month;
            if (value.Day < 10)
                day = "0";
            day += value.Day;
            return "'" + value.Year + month + day + "'";
        }
    }
}
