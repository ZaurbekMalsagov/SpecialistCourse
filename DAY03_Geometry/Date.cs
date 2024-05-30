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
                else throw new ArgumentOutOfRangeException("invalid year");
            }
        }

        public int _month;
        public int Month { 
            get => _month;
            set 
            { 
                if (value >=1 && value <=12) _month = value;
                else throw new ArgumentOutOfRangeException("invalid month");
            } 
        }
        public int _day;
        public int Day {
            get => _day;
            set 
            {
                if (value > 0 && value <= 31) _day = value;
                else throw new ArgumentOutOfRangeException("invalid day");
            } 
        }

        public bool Validate()
        {
            if (Month == 2)
            {
                if (Year % 4 == 0 && Year % 100 != 0) return Day <= 29;
                else return Day<=28;
            }
            else
            {
                if(Month <= 7) 
                    if (Month %2 == 1) return Day <= 31;
                    else return Day <= 30; 
                else 
                    if (Month % 2 == 1) return Day <= 30;
                    else return Day <= 31;
            }
        }

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
