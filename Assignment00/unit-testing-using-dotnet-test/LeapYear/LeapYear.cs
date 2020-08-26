using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Check if a year is a leap year!");
            Console.WriteLine("Enter a year:");

            string yearAsString = Console.ReadLine();
            Console.WriteLine(IsLeapYear_With_Strings(yearAsString));
        }

    public static string IsLeapYear_With_Strings(string yearAsString)
    {
        bool isInt = int.TryParse(yearAsString, out int year);
        if(!isInt) return "Not a Number";
        if(year <= 1582) return "The leap year function only applies to years from 1582.";
        return IsLeapYear(year) ? "yay" : "nay";
    }

    public static bool IsLeapYear(int year)
        {
            bool isLeapYear = false;
            if(year % 4 == 0) isLeapYear = true;
            if(year % 100 == 0) isLeapYear = false;
            if(year % 400 == 0) isLeapYear = true;
            return isLeapYear;
        }
    }
}
