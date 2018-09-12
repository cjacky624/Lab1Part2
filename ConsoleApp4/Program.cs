using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any date(mm/dd/year): ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter another date(mm/dd/year): ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            Dates(firstDate, secondDate);
        }
        public static void Dates(DateTime firstDate, DateTime secondDate)
        {
            TimeSpan diff = firstDate - secondDate;

            Console.WriteLine("Days : " + Math.Abs(diff.TotalDays));
            Console.WriteLine("Hours : " + Math.Abs(diff.TotalHours));
            Console.WriteLine("Minutes : " + Math.Abs(diff.TotalMinutes));
        }
    }
}
