using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WorkingWhitIFormatProvider
{
    class Temperature : IFormattable
    {
        public decimal temperature;

        public Temperature(int temperature)
        {
            if (temperature < -273.15m)
                throw new ArgumentOutOfRangeException("temperature can't be smaler than -273.15");
            this.temperature = temperature;
        }

        public decimal Celsius
        {
            get { return temperature; }
        }

        public decimal Fahrenheit
        {
            get { return temperature * 9 / 2 + 32; }
        }



        public decimal Kelvin
        {
            get { return temperature + 273.15m; }
        }

        //public override string ToString()
        //{
        //    return this.ToString("G", CultureInfo.CurrentCulture);
        //}

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (String.IsNullOrEmpty(format))
                format = "G";
            if (formatProvider == null)
                formatProvider = CultureInfo.CurrentCulture;
            switch (format.ToUpperInvariant())
            {
                case "G":
                case "C":
                    return temperature.ToString("F2", formatProvider) + "C";
                case "F":
                    return Fahrenheit.ToString("F2", formatProvider) + "F";
                case "K":
                    return Kelvin.ToString("F2", formatProvider) + "K";
                default:
                    throw
                         new FormatException(
                             String.Format("The {0} format  string is  nor suported", formatProvider));
            }
        }
    }
}
