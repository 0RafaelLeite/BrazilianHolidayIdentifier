using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holidayidentifier
{
    public class HolidayChecker
    {
        public DateTime DateProvided { get; set; }

        public HolidayChecker(DateTime dateProvided)
        {
            this.DateProvided = dateProvided;
        }

        public HolidayChecker()
        {
            Console.WriteLine("  First, do you wanna check if today's date is a holiday? enter [1] to YES and [2] to NO");
            Console.Write(" Response: ");

            int today = Int32.Parse(Console.ReadLine());

            if (today == 1)
            {
                Console.WriteLine(" ");
                Console.WriteLine("  Checking...");
                Console.WriteLine(" ");
                Thread.Sleep(2000);
                this.DateProvided = DateTime.Today;
            }
            else
            {
                Console.WriteLine(" ");
                Console.Write("  Type a day: ");
                int day = 0;

                while (day == 0)
                {
                    var dayProvided = Int32.Parse(Console.ReadLine());
                    if(dayProvided < 32 && dayProvided > 0)
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


                    if (monthName == "1" || monthName == "01" || monthName == "JANUARY")
                    {
                        month = 1;
                    }
                    else if (monthName == "2" || monthName == "02" || monthName == "FEBRUARY")
                    {
                        month = 2;
                    }
                    else if (monthName == "3" || monthName == "03" || monthName == "MARCH")
                    {
                        month = 3;
                    }
                    else if (monthName == "4" || monthName == "04" || monthName == "APRIL")
                    {
                        month = 4;
                    }
                    else if (monthName == "5" || monthName == "05" || monthName == "MAY")
                    {
                        month = 5;
                    }
                    else if (monthName == "6" || monthName == "06" || monthName == "JUNE")
                    {
                        month = 6;
                    }
                    else if (monthName == "7" || monthName == "07" || monthName == "JULY")
                    {
                        month = 7;
                    }
                    else if (monthName == "8" || monthName == "08" || monthName == "AUGUST")
                    {
                        month = 8;
                    }
                    else if (monthName == "9" || monthName == "09" || monthName == "SETEMBER")
                    {
                        month = 9;
                    }
                    else if (monthName == "10" || monthName == "OCTOBER")
                    {
                        month = 10;
                    }
                    else if (monthName == "11" || monthName == "NOVEMBER")
                    {
                        month = 11;
                    }
                    else if (monthName == "12" || monthName == "DECEMBER")
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
                var year = Int32.Parse(Console.ReadLine());

                this.DateProvided = new DateTime(year, month, day);

                Console.WriteLine(" ");
                Console.WriteLine("  Checking...");
                Console.WriteLine(" ");
                Thread.Sleep(2000);
            }
           
        }

        public string IsHoliday()
        {
            int year = this.DateProvided.Year;
            int day;
            int month;

            int lunarCyclePosition = year % 19;
            int century = year / 100;
            int daysFromEquinoxToNextFullMoon = (century - (int)(century / 4) - (int)((8 * century + 13) / 25) + 19 * lunarCyclePosition + 15) % 30;
            int daysFromFullMoonToFirstSunday = daysFromEquinoxToNextFullMoon - (int)(daysFromEquinoxToNextFullMoon / 28) * (1 - (int)(daysFromEquinoxToNextFullMoon / 28) * (int)(29 / (daysFromEquinoxToNextFullMoon + 1)) * (int)((21 - lunarCyclePosition) / 11));

            day = daysFromFullMoonToFirstSunday - ((year + (int)(year / 4) + daysFromFullMoonToFirstSunday + 2 - century + (int)(century / 4)) % 7) + 28;
            month = 3;

            if (day > 31)
            {
                month++;
                day -= 31;
            }

            DateTime easter = new DateTime(year, month, day);
            string Holiday;
            string dayPosition;

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

            if (easter == this.DateProvided)
            {
                Holiday = "Easter";
            }
            else if (easter.AddDays(60) == this.DateProvided)
            {
                Holiday = "Corpus Christ";
            }
            else if (this.DateProvided == easter.AddDays(-48) || this.DateProvided == easter.AddDays(-47))
            {
                Holiday = "Carnival";
            }
            else if (easter.AddDays(-2) == this.DateProvided)
            {
                Holiday = "Good Friday";
            }
            else if (easter.AddDays(-46) == this.DateProvided)
            {
                Holiday = "Ash Wednesday";
            }
            else if (this.DateProvided.Day == 25 && this.DateProvided.Month == 12)
            {
                Holiday = "Christmas";
            }
            else if (this.DateProvided.Day == 1 && this.DateProvided.Month == 1)
            {
                Holiday = "New Year";
            }
            else if (this.DateProvided.Day == 21 && this.DateProvided.Month == 4)
            {
                Holiday = "Brazil's Tira Dentes";
            }
            else if (this.DateProvided.Day == 1 && this.DateProvided.Month == 5)
            {
                Holiday = "International Labor";
            }
            else if (this.DateProvided.Day == 7 && this.DateProvided.Month == 9)
            {
                Holiday = "Brazil's Independence";
            }
            else if (this.DateProvided.Day == 12 && this.DateProvided.Month == 10)
            {
                Holiday = "Our Lady";
            }
            else if (this.DateProvided.Day == 2 && this.DateProvided.Month == 11)
            {
                Holiday = "day of the Dead";
            }
            else if (this.DateProvided.Day == 15 && this.DateProvided.Month == 11)
            {
                Holiday = "Brazil's proclamation of the Republic";
            }
            else
            {
                return $"  Unfortunately {this.DateProvided.Month}/{this.DateProvided.Day}{dayPosition} It's not a holiday :´(, you got to work...";
            }


            return $"  It's a holiday! {this.DateProvided.Month}/{this.DateProvided.Day}{dayPosition} is {Holiday} day";
        }
}
}