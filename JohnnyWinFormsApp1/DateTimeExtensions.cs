using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnnyWinFormsApp1
{
    static internal class DateTimeExtensions
    {
        public static string ToTaiwan(this DateTime dateTime)
        {
            int taiwanYear = dateTime.Year - 1911;
            string taiwanDayOfWeek = "";
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    taiwanDayOfWeek = "日";
                    break;
                case DayOfWeek.Monday:
                    taiwanDayOfWeek = "一";
                    break;
                case DayOfWeek.Tuesday:
                    taiwanDayOfWeek = "二";
                    break;
                case DayOfWeek.Wednesday:
                    taiwanDayOfWeek = "三";
                    break;
                case DayOfWeek.Thursday:
                    taiwanDayOfWeek = "四";
                    break;
                case DayOfWeek.Friday:
                    taiwanDayOfWeek = "五";
                    break;
                case DayOfWeek.Saturday:
                    taiwanDayOfWeek = "六";
                    break;
            }
            return $"民國{taiwanYear}年{dateTime.Month}月{dateTime.Day}日 星期{taiwanDayOfWeek}";
        }
    }
}
