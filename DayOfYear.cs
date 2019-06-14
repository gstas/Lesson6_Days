using System;

namespace Lesson6_Days
{
    class DayOfYear
    {
        ushort year;
        DayDictionary.Month month;
        sbyte day;
        DayDictionary.DayOfTheWeek dayOfTheWeek;

        public ushort Year { get => year; set => year = value; }
        public sbyte Day { get => day; set => day = value; }
        internal DayDictionary.Month Month {
            get => month;
            set => month = value;
        }
        internal DayDictionary.DayOfTheWeek DayOfTheWeek { get => dayOfTheWeek; set => dayOfTheWeek = value; }

        public DayOfYear(ushort year, DayDictionary.Month month, sbyte day, DayDictionary.DayOfTheWeek dayOfTheWeek)
        {
            Year = year;
            Day = day;
            Month = month;
            DayOfTheWeek = dayOfTheWeek;
            
        }

        public override string ToString()
        {
            return $"{Day} {Month} {Year}, {DayOfTheWeek}";
        }
    }
}
