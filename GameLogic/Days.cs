using System;

namespace GameLogic
{
    public enum WeekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    public class Days
    {
        public static WeekDays CurrentDay = WeekDays.Monday;

        public static int TotalDays = 1;

        public static void PassDay()
        {
            if (CurrentDay == WeekDays.Sunday)
            {
                CurrentDay = WeekDays.Monday;
            }
            else CurrentDay++;

            TotalDays++;
        }

        public static void DisplayDay()
        {
            switch (Days.CurrentDay)
            {
                case WeekDays.Monday:
                    Console.WriteLine("Monday");
                    break;

                case WeekDays.Tuesday:
                    Console.WriteLine("Tuesday");
                    break;

                case WeekDays.Wednesday:
                    Console.WriteLine("Wednesday");
                    break;

                case WeekDays.Thursday:
                    Console.WriteLine("Thursday");
                    break;

                case WeekDays.Friday:
                    Console.WriteLine("Friday");
                    break;

                case WeekDays.Saturday:
                    Console.WriteLine("Saturday");
                    break;

                case WeekDays.Sunday:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}
