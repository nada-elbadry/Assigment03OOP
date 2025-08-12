using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03OOP
{
    class HiringDate : IComparable<HiringDate>
    {
        #region Properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        #endregion
        #region Constructor
        public HiringDate(int day, int month, int year)
        {
            if (month < 1 || month > 12) throw new ArgumentOutOfRangeException("Month must be 1-12");
            if (day < 1 || day > DateTime.DaysInMonth(year, month)) throw new ArgumentOutOfRangeException("Invalid day for month/year");

            Day = day;
            Month = month;
            Year = year;
        }
        #endregion

        #region Methods
        public int CompareTo(HiringDate other)
        {
            if (Year != other.Year) return Year.CompareTo(other.Year);
            if (Month != other.Month) return Month.CompareTo(other.Month);
            return Day.CompareTo(other.Day);
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        } 
        #endregion
    }
}
