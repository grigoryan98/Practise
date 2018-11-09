using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Car
    {
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public void DisplaySets()
        {
            Console.WriteLine($"PateName is {PetName}");
            Console.WriteLine($"Spessd is {Speed}");
            Console.WriteLine($"Color is {Color}");
        }
    }
}
