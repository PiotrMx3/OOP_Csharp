using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Csharp
{
    internal class DateTimeOefeningen
    {

        public static void CurrentTime()
        {
            DateTime currentTime = DateTime.Now;

            Console.WriteLine($"Current time {currentTime.ToString("D")}");
        }

        public static void CreateTime()
        {
            DateTime currentTime = new DateTime(1990, 12, 22);

            Console.WriteLine($"Birthdate {currentTime.ToString("D")}");
        }



        public static void AddTime()
        {
            DateTime currentTime = DateTime.Now;
            DateTime futherDate = currentTime.AddDays(10);

            Console.WriteLine($"Current Time is : {currentTime.ToString("D")}\n" +
                $"Date after 10 days : {futherDate.ToString("D")}");
        }


        public static void ReadTime()
        {
            DateTime createdTime = new DateTime(2020, 1, 5, 14, 45, 30);

            int year = createdTime.Year;
            int month = createdTime.Month;
            int day = createdTime.Day;
            int hour = createdTime.Hour;
            int minute = createdTime.Minute;
            int seconde = createdTime.Second;




            Console.WriteLine($"Created Year is : {year}\n" +
                $"Created month is : {month}\n" +
                $"Created day is : {day}\n" +
                $"Created hour is : {hour}\n" +
                $"Created minute is : {minute}\n" +
                $"Created seconde is : {seconde}\n");
        }


        public static void FormattedTime()
        {
            DateTime currentTime = DateTime.Now;


            Console.WriteLine($"Short Time Format is : {currentTime.ToString("d")}");
            Console.WriteLine($"Full Time Format is : {currentTime.ToString("F")}");
            Console.WriteLine($"Month and Day Time Format is : {currentTime.ToString("M")}");

        }


        public static void ParsedTime()
        {
            string timeToParse = "12/03/2024";
            DateTime formatted = DateTime.Parse(timeToParse);



            Console.WriteLine($"Parsed Time is : {formatted}");


        }

        public static void DiffTime()
        {

            DateTime timeInPast = new DateTime(1939, 9, 1);
            TimeSpan daysFromPastTillNow = DateTime.Now - timeInPast;


            Console.WriteLine($"From {timeInPast} are {daysFromPastTillNow.Days} days passed till today");


        }

    }
}
