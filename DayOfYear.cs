using System;

namespace Lesson6_Days
{
    class DayOfYear
    {
        ushort year;
        DayDictionary.Month month;
        sbyte day;
        DayDictionary.DayOfTheWeek dayOfTheWeek;

        public ushort Year { get; set; }
        public sbyte Day { get => day; set => day = (sbyte)(value > 30 ? 30 : value); }
        internal DayDictionary.Month Month { get; set; }

        internal DayDictionary.DayOfTheWeek DayOfTheWeek { get; set; }

        public DayOfYear() { }

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

        public static DayOfYear operator + (DayOfYear d, int i) {
            // Подсчитываем общее количество дней
            uint allDays = (uint)(d.Year * 360 + (int)d.Month * 30 + d.Day);

            // Добавляем необходимое кол-во дней
            allDays = (uint)(allDays + i);
            
            // вычисляем год
            ushort year = (ushort)(allDays / 360);
            allDays %= 360;
            
            // вычисляем месяц, если месяц > 12, увеличиваем год
            uint month = allDays / 30;
            while (month > 12)
            {
                month -= 12;
                year++;
            }
            
            // вычисляем день, если дней > 30, увеличиваем месяц
            allDays %= 30;
            uint day = allDays;
            while (day > 30)
            {
                day -= 30;
                month++;
            }
            // если месяц > 12, увеличиваем год
            while (month > 12)
            {
                month -= 12;
                year++;
            }

            // Выбираем из перечисления месяцев наше значение
            Enum.TryParse<DayDictionary.Month>(""+month, out DayDictionary.Month month2);
            
            // Находим смещение по дню недели
            while(i>=7)
                i -= 7;
            
            // к текущему дню недели прибавляем смещение
            int currDow = (int)d.DayOfTheWeek;
            currDow += i;
            while (currDow > 7)
                currDow -= 7;

            // Выбираем из перечисления дней недели наше значение
            Enum.TryParse<DayDictionary.DayOfTheWeek>("" + currDow, out DayDictionary.DayOfTheWeek dow2);
            
            return new DayOfYear(year, month2, (sbyte)day, dow2);
        }
    }
}
