using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Regions
{
    class Program
    {
        static void Main(string[] args)
        {
            RegionInfo region = RegionInfo.CurrentRegion;
            Console.WriteLine("curren region is:\t{0} ", region.EnglishName);
            Console.WriteLine("Native name of region is:\t{0} ", region.NativeName);

            Console.WriteLine(new string('-',40));

            Console.WriteLine("CurrencySymbol of region:\t{0}", region.CurrencySymbol);
            Console.WriteLine("CurrencyEnglishName:\t{0}", region.CurrencyEnglishName);
            Console.WriteLine("CurrencyNativeName:\t{0}", region.CurrencyNativeName);

            Console.WriteLine(new string('*',40));

            // days of week
            string[] days = CultureInfo.CurrentCulture.DateTimeFormat.DayNames;
            foreach(string day in days)
                Console.WriteLine(day);


                ;
        }
    }
}
