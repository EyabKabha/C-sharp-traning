using System;
using System.Collections.Generic;
using System.Text;

namespace AppTask
{
    class Date
    {
        private int day;

        public int Day
        {
            get { return day; }
            set {
                if (value > 0 && value <= 31)
                {
                    day = value;
                }
                
            }
        }
        private int month;

        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 && value <= 12)
                {
                    month = value;
                }
            }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Date(int day,int month,int year ) {

            Day = day;
            Month = month;
            Year = year;
        }
        public Date() {}

        public override string ToString()
        {
            return string.Format ($"{Day}/{Month}/{Year}");
        }
    }
}
