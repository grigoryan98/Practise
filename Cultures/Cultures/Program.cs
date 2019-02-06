using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cultures
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo currentCulture =  CultureInfo.CurrentCulture;
            Console.WriteLine(currentCulture);

            //Console.ReadKey();

            // information about all culltures
            CultureInfo[] cultureinfo = CultureInfo.GetCultures(CultureTypes.AllCultures);
            Console.WriteLine("Lengt of all cultures",cultureinfo.Length);

            foreach(CultureInfo c in cultureinfo)
                Console.WriteLine(c.EnglishName+"|"+c.ToString());

            //All cultures made by  user
            cultureinfo = CultureInfo.GetCultures(CultureTypes.UserCustomCulture);

            if (cultureinfo.Length<1)
            {
                Console.WriteLine("user didn't made any culture");
            }
            else
            {
                foreach (CultureInfo c in cultureinfo)
                    Console.WriteLine(c.EnglishName+"|"+c.ToString());
            }

            Console.ReadKey();
        }
    }
}
