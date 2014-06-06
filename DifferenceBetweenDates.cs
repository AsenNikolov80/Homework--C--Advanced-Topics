using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            DateTime firstDay = DateTime.Parse(Console.ReadLine());
            DateTime secondDay = DateTime.Parse(Console.ReadLine());
            string firstDay1 = firstDay.Day + "." + firstDay.Month + "." + firstDay.Year;
            string secondDay1 = secondDay.Day + "." + secondDay.Month + "." + secondDay.Year;
            var result = secondDay - firstDay;
            int resultTrue = result.Days;
            Console.WriteLine("{0} day between {1} and {2}", resultTrue, firstDay1, secondDay1);
        }
    }
}
