using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample
{
    class Program
    {
        enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
        static void Main(string[] args)
        {

            if (Days.IsDefined(typeof(Days), "Friday"))
                Console.WriteLine("Friday available");
            else
                Console.WriteLine("Friday not available");

            Console.WriteLine("---");

            //sıra numarası ile
            if (Days.IsDefined(typeof(Days), 5))
                Console.WriteLine("Friday available");
            else
                Console.WriteLine("Friday not available");

            Console.WriteLine("---");

            Days days;
            days = (Days)5;
            Console.WriteLine(days);

            Console.WriteLine("---");

            string _day = Enum.GetName(typeof(Days), 5);
            Console.WriteLine(_day);

            var allDayNames = Enum.GetNames(typeof(Days));

            var allDaysValues = Enum.GetValues(typeof(Days));

            Days test = (Days)Enum.Parse(typeof(Days), "Friday");

            Console.ReadLine();
        }
    }
}
