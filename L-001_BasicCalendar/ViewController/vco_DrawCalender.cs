using System;
using System.Collections.Generic;

namespace BasicCalendar
{
    class Vco_DrawCalender
    {
        private static int Cur_DrawMode;
        private static int Cur_DrawYear;
        private static int Cur_DrawMonth;
        private static List<Dat_SettingData.strc_CalendarDay> Lis_CalenderData = new List<Dat_SettingData.strc_CalendarDay>();

        public Vco_DrawCalender(int _catchMode, int _catchYear, int _catchMonth)
        {
            Cur_DrawMode = _catchMode;
            Cur_DrawYear = _catchYear;
            Cur_DrawMonth = _catchMonth;

            Mco_CreateCalender _calendarDataCreater = new Mco_CreateCalender(Cur_DrawYear, Cur_DrawMonth);
            Lis_CalenderData = _calendarDataCreater.Create_CalendarList();

            Draw_Calender();
        }

        private static void Draw_Calender()
        {
            Draw_Title();
            Draw_DayOfWeek();
            Draw_Day();
        }

        private static void Draw_Title()
        {
            string _drawCalender = "";

            switch (Cur_DrawMode)
            {
                case Dat_SettingData.USE_WEEKDAY_JA_ST:
                    _drawCalender = Cur_DrawYear + "年" + Cur_DrawMonth + "月";
                    break;

                case Dat_SettingData.USE_WEEKDAY_JA_LG:
                    _drawCalender = "西暦" + Cur_DrawYear + "年" + Cur_DrawMonth + "月";
                    break;

                case Dat_SettingData.USE_WEEKDAY_EG:
                    _drawCalender = Cur_DrawYear + " / " + Cur_DrawMonth;
                    break;
            }

            Console.WriteLine(_drawCalender);
        }

        private static void Draw_DayOfWeek()
        {
            string _drawCalender = "";
            List<string> _useDayOfWeek = new List<string>();

            switch (Cur_DrawMode)
            {
                case Dat_SettingData.USE_WEEKDAY_JA_ST:
                    _useDayOfWeek = Dat_SettingData.lis_WeekDay_JA_ST;
                    break;

                case Dat_SettingData.USE_WEEKDAY_JA_LG:
                    _useDayOfWeek = Dat_SettingData.lis_WeekDay_JA_LG;
                    break;

                case Dat_SettingData.USE_WEEKDAY_EG:
                    _useDayOfWeek = Dat_SettingData.lis_WeekDay_EG;
                    break;
            }

            foreach (var _drawDayOfWeek in _useDayOfWeek)
            {
                _drawCalender += _drawDayOfWeek + " ";
            }

            Console.WriteLine(_drawCalender);
        }


        private static void Draw_Day()
        {
            string _drawCalender = "";

            foreach (var _trgCalenderDay in Lis_CalenderData)
            {
                string _addDay = Digiting_Day(_trgCalenderDay.Day);

                _drawCalender += _addDay + " ";

                if (_trgCalenderDay.DayOfWeek == Dat_SettingData.CNT_WEEK_DAY - 1)
                {
                    _drawCalender += "\n";
                }

            }

            Console.WriteLine(_drawCalender);
        }

        private static string Digiting_Day(int _trgIntDay)
        {
            string _retDay = "";

            if (_trgIntDay != 0)
            {
                _retDay = _trgIntDay.ToString();
            }

            int _cntBeforeDigit = 0;
            int _cntMainDigit = 0;
            int _cntAfterDigit = 0;

            switch (Cur_DrawMode)
            {
                case Dat_SettingData.USE_WEEKDAY_JA_ST:
                    _cntBeforeDigit = 0;
                    _cntMainDigit = 2 - _retDay.Length;
                    _cntAfterDigit = 0;
                    break;

                case Dat_SettingData.USE_WEEKDAY_JA_LG:
                    _cntBeforeDigit = 2;
                    _cntMainDigit = 2 - _retDay.Length;
                    _cntAfterDigit = 2;
                    break;

                case Dat_SettingData.USE_WEEKDAY_EG:
                    _cntBeforeDigit = 0;
                    _cntMainDigit = 3 - _retDay.Length;
                    _cntAfterDigit = 0;
                    break;
            }

            for (int _cntBeforeSpace = 0; _cntBeforeSpace < _cntBeforeDigit; _cntBeforeSpace++)
            {
                _retDay = " " + _retDay;
            }

            for (int _cntMainSpace = 0; _cntMainSpace < _cntMainDigit; _cntMainSpace++)
            {
                _retDay = " " + _retDay;
            }

            for (int _cntAfterSpace = 0; _cntAfterSpace < _cntAfterDigit; _cntAfterSpace++)
            {
                _retDay = _retDay + " ";
            }

            return _retDay;            
        }
    }
}
