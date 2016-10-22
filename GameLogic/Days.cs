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
            Console.WriteLine(CurrentDay.ToString());
        }
    }
}
