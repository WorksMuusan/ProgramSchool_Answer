using System;
using System.Collections.Generic;

namespace BasicCalendar
{

    public class Mco_CreateCalender
    {
        private static int Cur_DrawYear;
        private static int Cur_DrawMonth;

        public Mco_CreateCalender(int _catchYear, int _catchMonth)
        {
            Cur_DrawYear = _catchYear;
            Cur_DrawMonth = _catchMonth;
        }

        public List<Dat_SettingData.strc_CalendarDay> Create_CalendarList()
        {
            List<Dat_SettingData.strc_CalendarDay> _retList = new List<Dat_SettingData.strc_CalendarDay>();

            int _cntSetDay = 1;

            DateTime _trgCreateFirstDay = new DateTime(Cur_DrawYear, Cur_DrawMonth, _cntSetDay);
            int _firstDay_dayOfWeek = (int)_trgCreateFirstDay.DayOfWeek;

            int _endDay_ofMonth = DateTime.DaysInMonth(Cur_DrawYear, Cur_DrawMonth);

            for (int _cntCreateDay = 0; _cntCreateDay < Dat_SettingData.MAX_CALENDAR_DAY; _cntCreateDay++)
            {
                int _setDay = 0;
                int _setDayOfWeek = 0;

                if (_cntCreateDay >= _firstDay_dayOfWeek && _cntSetDay <= _endDay_ofMonth)
                {
                    _setDay = _cntSetDay;

                    DateTime _tempDay = new DateTime(Cur_DrawYear, Cur_DrawMonth, _cntSetDay);
                    _setDayOfWeek = (int)_tempDay.DayOfWeek;

                    _cntSetDay++;
                }

                Dat_SettingData.strc_CalendarDay _addCalendarDay = new Dat_SettingData.strc_CalendarDay(_setDay, _setDayOfWeek);
                _retList.Add(_addCalendarDay);
            }

            return _retList;
        }

    }

}
