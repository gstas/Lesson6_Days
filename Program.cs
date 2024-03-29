﻿using System;

namespace Lesson6_Days
{
    class Program
    {
        /*
        Напишите программу, в которой есть структура, предназначенная для описания дня в году. 
        В частности, там должны быть поля для "запоминания" текущего года, месяца, числа и дня недели. 
        День недели и месяц реализуются с помощью перечисления. 

        Описать операторный метод, позволяющий прибавлять к экземпляру структуры 
        целое число (количество дней) и получать в результате новый экземпляр структуры. 
        Для удобства считать, что в каждом месяце 30 дней, а в году 12 месяцев.
        */

        static void Main(string[] args)
        {
            DayOfYear dow = new DayOfYear (2019, DayDictionary.Month.Jun, 14, DayDictionary.DayOfTheWeek.Fri);
            Console.WriteLine(dow);
            
            // Данный "велосипед" решается с помощью
            // DateTime d = DateTime.Now;
            // Console.WriteLine(d.AddDays(30));

            Console.WriteLine(dow + 30);

            
        }
    }
}

