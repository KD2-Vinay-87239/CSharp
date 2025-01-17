using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Date
    {
        private int _day { get; set; }

        private int _month { get; set; }

        private int _year { get; set; }

        //default ctor
        public Date()
        {
            _day = 1;
            _month = 1;
            _year = 2000;
        }

        //paramterized ctor
        public Date(int _day,int _month,int _year)
        {
            this._day = _day;
            this._month = _month;
            this._year = _year;
        }

        //AcceptDate() 
        public void AcceptDate()
        {
            Console.WriteLine("Enter day : ");
            int d=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter month : ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter year : ");
            int y = Convert.ToInt32(Console.ReadLine());

        }

        //PrintDate()
        public void PrintDate()
        {
            Console.WriteLine("Date ----> " + _day +
                                "/" + _month + 
                                "/" + _year);
            Console.ReadLine();
        }

        //ToString() override
        public override string ToString()
        {
            return "Date ["+_day+" - "+_month + " - "+_year+ "]";
        }

        //IsValid()
        public bool IsValid()
        {
            if (_day >= 0 && _day <= 30)
                return true;
            else if (_month >= 0 && _month <= 12)
                return true;
            else if (_year >= 0 && _year <= 3000)
                return true;

            Console.WriteLine("IsVslid() invoked..");
            return false;
        }

        // Static method to calculate the difference in years between two dates
        public static int DifferenceInYears(Date date1, Date date2)
        {
            return Math.Abs(date1._year - date2._year);
        }

        // Overloaded '-' operator for the same functionality
        public static int operator -(Date date1, Date date2)
        {
            return DifferenceInYears(date1, date2);
        }
        static void Main(string[] args)
        {
            Date date = new Date();
            Date date1 = new Date(1,2,2025);

            date.AcceptDate();
            date.PrintDate();

            Console.WriteLine("Is the date valid ? "+ date.IsValid());
            Console.WriteLine("ToString() called "+ date.ToString());

            int diff = date - date1;
            Console.WriteLine($"Difference in years :{diff}");
            
            

        }
    }
}
