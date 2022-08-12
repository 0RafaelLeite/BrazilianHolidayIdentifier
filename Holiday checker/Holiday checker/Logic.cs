using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayIdentifier
{
    public abstract class CheckHoliday
    {
        public DateTime DateProvided { get; set; }

        public string Greetings;

        public abstract void SetGreetings();
        public string GetGreetings()
        {
            return Greetings;
        }


        public string Loading;

        public abstract void SetLoading();
        public string GetLoading()
        {
            return Loading;
        }

        public string Holiday;
        public abstract void SetHoliday();
        public string GetHoliday()
        {
            return Holiday;
        }

        public int HolidayId;

        public abstract DateTime GetDate();
    
        public CheckHoliday()
        {
            SetGreetings();
            SetLoading();
            Console.Write(GetGreetings());

            int today = Int32.Parse(Console.ReadLine());

            if (today == 1)
            {
                Console.WriteLine(GetLoading());
                Thread.Sleep(1500);
                this.DateProvided = DateTime.Today;
            }
            else
            {
                this.GetDate();
            }
           
        }

        public DateTime GetEasterDate(int year)
        {
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

            //where did all of this math come from https://stackoverflow.com/questions/2510383/how-can-i-calculate-what-date-good-friday-falls-on-given-a-year

            return new DateTime(year, month, day);
        }

        public int IsHoliday()
        {

           var easter = GetEasterDate(this.DateProvided.Year);

            if (easter == this.DateProvided)
            {
                HolidayId = 1;
            }
            else if (easter.AddDays(60) == this.DateProvided)
            {
                HolidayId = 2;
            }
            else if (this.DateProvided == easter.AddDays(-48) || this.DateProvided == easter.AddDays(-47))
            {
                HolidayId = 3;
            }
            else if (easter.AddDays(-2) == this.DateProvided)
            {
                HolidayId = 4;
            }
            else if (easter.AddDays(-46) == this.DateProvided)
            {
                HolidayId = 5;
            }
            else if (this.DateProvided.Day == 25 && this.DateProvided.Month == 12)
            {
                HolidayId = 6;
            }
            else if (this.DateProvided.Day == 1 && this.DateProvided.Month == 1)
            {
                HolidayId = 7;
            }
            else if (this.DateProvided.Day == 21 && this.DateProvided.Month == 4)
            {
                HolidayId = 8;
            }
            else if (this.DateProvided.Day == 1 && this.DateProvided.Month == 5)
            {
                HolidayId = 9;
            }
            else if (this.DateProvided.Day == 7 && this.DateProvided.Month == 9)
            {
                HolidayId = 10;
            }
            else if (this.DateProvided.Day == 12 && this.DateProvided.Month == 10)
            {
                HolidayId = 11;
            }
            else if (this.DateProvided.Day == 2 && this.DateProvided.Month == 11)
            {
                HolidayId = 12;
            }
            else if (this.DateProvided.Day == 15 && this.DateProvided.Month == 11)
            {
                HolidayId = 13;
            }
            else
            {
                HolidayId = 0;
            }

            return HolidayId;
        }
}
}
