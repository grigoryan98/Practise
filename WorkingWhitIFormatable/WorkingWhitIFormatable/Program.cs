using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WorkingWhitIFormatProvider
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature(13);
            Console.WriteLine("Temperature [default]={0}",temp);
            Console.WriteLine("Temperature [Fahrenheit]={0:F}",temp);
            Console.WriteLine("Temperature [CultureInfo]={0}",temp.ToString("F",CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("temperature [CultureInfo]={0}",temp.ToString("C",CultureInfo.CreateSpecificCulture("ru-RU")));
            Console.ReadKey();
        }
    }
}
