﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayIdentifier
{
    public class EnglishView : CheckHoliday
    {
        private string dayPosition;

        public override void SetGreetings()
        {
            Greetings = "~~~~~~~~~~~~~~~~ Brazilian Holidays identifier ~~~~~~~~~~~~~~~~\n  Enter a date to know whether or not it is a holiday!\n\n  First, do you wanna check if today's date is a holiday? enter [1] to YES and [2] to NO \n Response: ";
        }
        
        public override void SetLoading()
        {
            Loading = "\n  Checking...\n";
        }


        public override DateTime GetDate()
        {

            Console.WriteLine(" ");
            Console.Write("  Type a day: ");
            int day = 0;

            while (day == 0)
            {
                var dayProvided = Int32.Parse(Console.ReadLine());
                if (dayProvided < 32 && dayProvided > 0)
                {
                    day = dayProvided;
                }
                else
                {
                    Console.Write("  Type a valid day: ");
                }
            }

            Console.WriteLine(" ");
            Console.Write("  Type a month: ");
            int month = 0;

            while (month == 0)
            {
                string monthName = Console.ReadLine().ToUpper().Trim();
                var teste = Int32.TryParse(monthName, out month);

                if (teste)
                {
                    break;
                }

                if (monthName == "JANUARY")
                {
                    month = 1;
                }
                else if (monthName == "FEBRUARY")
                {
                    month = 2;
                }
                else if (monthName == "MARCH")
                {
                    month = 3;
                }
                else if (monthName == "APRIL")
                {
                    month = 4;
                }
                else if (monthName == "MAY")
                {
                    month = 5;
                }
                else if (monthName == "JUNE")
                {
                    month = 6;
                }
                else if (monthName == "JULY")
                {
                    month = 7;
                }
                else if (monthName == "AUGUST")
                {
                    month = 8;
                }
                else if (monthName == "SEPTEMBER")
                {
                    month = 9;
                }
                else if (monthName == "OCTOBER")
                {
                    month = 10;
                }
                else if (monthName == "NOVEMBER")
                {
                    month = 11;
                }
                else if (monthName == "DECEMBER")
                {
                    month = 12;
                }
                else
                {
                    Console.Write("  Type a valid month: ");
                }
            }

            Console.WriteLine(" ");
            Console.Write("  Type an year: ");

            int year = 0;

            while (year == 0)
            {
                int yearProvided = Int32.Parse(Console.ReadLine());

                if (yearProvided < 1583)
                {
                    Console.WriteLine("  Type a valid year: ");
                }
                else
                {
                    year = yearProvided;
                }
            }

            Console.WriteLine("\n  Checking...\n");
            Thread.Sleep(1500);

            return DateProvided = new DateTime(year, month, day);
        }


        public void SetDayPosition() {

            if (this.DateProvided.Day == 1 || this.DateProvided.Day == 21 || this.DateProvided.Day == 31)
            {
            dayPosition = "st";
            }
            else if (this.DateProvided.Day == 2 || this.DateProvided.Day == 22)
            {
            dayPosition = "nd";
            }
            else if (this.DateProvided.Day == 3 || this.DateProvided.Day == 23)
            {
            dayPosition = "rd";
            }
            else
            {
            dayPosition = "th";
            }
         }

        public string GetDayPosition()
        {
            return dayPosition;
        }

        public override void SetHoliday()
        {

            switch (IsHoliday())
            {
                case 1:
                    Holiday = "easter";
                    break;
                case 2:
                    Holiday = "corpus Christ";
                    break;
                case 3:
                    Holiday = "carnival";
                    break;
                case 4:
                    Holiday = "good friday";
                    break;
                case 5:
                    Holiday = "ash wednesday";
                    break;
                case 6:
                    Holiday = "Christmas";
                    break;
                case 7:
                    Holiday = "new year";
                    break;
                case 8:
                    Holiday = "Tira Dente's";
                    break;
                case 9:
                    Holiday = "International labor";
                    break;
                case 10:
                    Holiday = "Brazil's independence";
                    break;
                case 11:
                    Holiday = "our Lady";
                    break;
                case 12:
                    Holiday = "All soul's";
                    break;
                case 13:
                    Holiday = "Brazil's proclamation of the republic";
                    break;
            }


        }


        public EnglishView()
        {
            SetHoliday();
            SetDayPosition();

            if (Holiday == null)
            {
                Console.WriteLine($"  Unfortunately {this.DateProvided.Month}/{this.DateProvided.Day}{GetDayPosition()} It's not a holiday :´(, you got to work...");
            }
            else
            {
                Console.WriteLine($"  It's a holiday! {this.DateProvided.Month}/{this.DateProvided.Day}{GetDayPosition()} is {GetHoliday()} day");
            }
        }

    }

}
