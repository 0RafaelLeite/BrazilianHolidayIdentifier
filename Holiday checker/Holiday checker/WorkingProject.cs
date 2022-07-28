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

        //Below you can see all holidays those are under code's sight 


        //var date = new HolidayChecker(new DateTime(2022, 01, 1)); //new year
        //var date1 = new HolidayChecker(new DateTime(2022, 03, 1)); //2022 carnival
        //var date2 = new HolidayChecker(new DateTime(2022, 05, 1)); //labor day
        //var date3 = new HolidayChecker(new DateTime(2022, 04, 21)); //tira dentes
        //var date4 = new HolidayChecker(new DateTime(2022, 9, 7)); //Brazil's independence day
        //var date5 = new HolidayChecker(new DateTime(2022, 12, 25)); //Christmas 
        //var date6 = new HolidayChecker(new DateTime(2022, 11, 15)); //Brazil's Proclamation of the republic
        //var date7 = new HolidayChecker(new DateTime(2022, 11, 2)); //day of the dead
        //var date8 = new HolidayChecker(new DateTime(2022, 4, 17)); //2022 Easter day
        //var date9 = new HolidayChecker(new DateTime(2022, 06, 16)); //2022 Corpus Christ
        //var date10 = new HolidayChecker(new DateTime(2022, 04, 15)); //2022 Good Friday
        //var date11 = new HolidayChecker(new DateTime(2022, 03, 2)); //2022 ash wednesday
        //var date12 = new HolidayChecker(new DateTime(2022, 12, 14)); //Not Holiday

        //Console.WriteLine(date.IsHoliday());
        //Console.WriteLine("-----------------------------------------------------");

        //Console.WriteLine(date1.IsHoliday());
        //Console.WriteLine("-----------------------------------------------------");

        //Console.WriteLine(date2.IsHoliday());
        //Console.WriteLine("-----------------------------------------------------");

        //Console.WriteLine(date3.IsHoliday());
        //Console.WriteLine("-----------------------------------------------------");

        //Console.WriteLine(date4.IsHoliday());
        //Console.WriteLine("-----------------------------------------------------");

        //Console.WriteLine(date5.IsHoliday());
        //Console.WriteLine("-----------------------------------------------------");

        //Console.WriteLine(date6.IsHoliday());
        //Console.WriteLine("-----------------------------------------------------");

        //Console.WriteLine(date7.IsHoliday());
        //Console.WriteLine("-----------------------------------------------------");

        //Console.WriteLine(date8.IsHoliday());
        //Console.WriteLine("-----------------------------------------------------");

        //Console.WriteLine(date9.IsHoliday());
        //Console.WriteLine("-----------------------------------------------------");

        //Console.WriteLine(date10.IsHoliday());
        //Console.WriteLine("-----------------------------------------------------");

        //Console.WriteLine(date11.IsHoliday());
        //Console.WriteLine("-----------------------------------------------------");

        //Console.WriteLine(date12.IsHoliday());
        //Console.ReadLine();
    }
}