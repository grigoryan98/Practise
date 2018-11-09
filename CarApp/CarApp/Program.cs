using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Car c1=new Car();
            c.PetName = "Frank";
            c.Speed = 45;
            c.Color = "black";

            Console.WriteLine($"Your car  name  is {c.PetName}");
            c.DisplaySets();

            Garage g = new Garage();

            //Ayspisi ban chenq karogh anel qani  vor MyCar-@ null e  ev  kberi nullreferance exeption
            // da kareli klini  ayn depqum erb stxcvi obyekt;
            // Console.WriteLine(g.MyCar.PetName);
            g.MyCar = c;
            g.MyCar = c1;
            Console.WriteLine($"Number if cars in garage {g.NumberOfCars}");
            Console.WriteLine($"your car  name is {g.MyCar.PetName}");


        }
    }
}
