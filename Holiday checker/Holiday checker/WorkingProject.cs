using System;
using Holidayidentifier;
class workingProject
{
    static void Main(string[] args)
    {
       Console.WriteLine("~~~~~~~~~~~~~~~~ Brazilian Holidays identifier ~~~~~~~~~~~~~~~~");
       Console.WriteLine("  Enter a date to know whether or not it is a holiday!");
       Console.WriteLine(" ");
       var dateProvided = new HolidayChecker();
       Console.WriteLine(dateProvided.IsHoliday());
       Console.ReadLine();

        //Below you can see all 2022 holidays those are under code's sight
        //Uncomment and test it!


    //    HolidayChecker[] dates = {new HolidayChecker(new DateTime(2022, 01, 1)),
    //   new HolidayChecker(new DateTime(2022, 03, 1)),
    //    new HolidayChecker(new DateTime(2022, 05, 1)),
    //    new HolidayChecker(new DateTime(2022, 04, 21)),
    //    new HolidayChecker(new DateTime(2022, 9, 7)),
    //    new HolidayChecker(new DateTime(2022, 12, 25)),
    //    new HolidayChecker(new DateTime(2022, 11, 15)),
    //    new HolidayChecker(new DateTime(2022, 11, 2)),
    //    new HolidayChecker(new DateTime(2022, 4, 17)),
    //    new HolidayChecker(new DateTime(2022, 06, 16)),
    //    new HolidayChecker(new DateTime(2022, 04, 15)),
    //    new HolidayChecker(new DateTime(2022, 03, 2))};


    //    Console.WriteLine("All 2022 holidays test");

    //    foreach (var date in dates)
    //    {
    //        Console.WriteLine(" ");
    //        Console.WriteLine(date.IsHoliday());
    //        Console.WriteLine("-----------------------------------------------------");
    //    }
    //    Console.ReadLine();
    }
}
