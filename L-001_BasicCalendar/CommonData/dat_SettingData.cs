using System;
using System.Collections.Generic;

namespace BasicCalendar
{
    public class Dat_SettingData
    {
        public const int USE_WEEKDAY_JA_ST = 0;
        public const int USE_WEEKDAY_JA_LG = 1;
        public const int USE_WEEKDAY_EG = 2;

        public static List<string> lis_WeekDay_JA_ST = new List<string> { "日", "月", "火", "水", "木", "金", "土" };
        public static List<string> lis_WeekDay_JA_LG = new List<string> { "日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日" };
        public static List<string> lis_WeekDay_EG = new List<string> { "SUN", "MON", "THU", "WED", "THR", "FRI", "SAT" };

        public struct strc_CalendarDay
        {
            private int _day;
            private int _dayOfWeek;

            public int Day { get => _day; set => _day = value; }
            public int DayOfWeek { get => _dayOfWeek; set => _dayOfWeek = value; }

            public strc_CalendarDay(int day, int dayOfWeek) : this()
            {
                Day = day;
                DayOfWeek = dayOfWeek;
            }
        }

        public const int CNT_WEEK_DAY = 7;
        public const int CNT_WEEK_ROW = 5;
        public const int CNT_LASTROW_DAY = 2;
        public const int MAX_CALENDAR_DAY = (CNT_WEEK_DAY * CNT_WEEK_ROW) + CNT_LASTROW_DAY;

    }
}
