using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY03_Geometry
{
    internal class Date
    {

        public int _year;
        public int Year {
            get => _year; 
            set
            {
                if (value > 0 && _year < 10000) _year = value;
                else throw new ArgumentOutOfRangeException();
            }
        }


        public int Month { get; set; }
        public int Day { get; set; }

        public Date() : this (DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) { }

        public Date(int year, int month, int day)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }


        public void Print() => Console.WriteLine($"{Year}.{Month}.{Day}");

    }
}
