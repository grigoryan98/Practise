using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Garage
    {
        public  int NumberOfCars { get; set; }
        public Car MyCar { get; set; }

        public Garage()
        {
            MyCar = new Car();
            NumberOfCars = 1;
        }

        public Garage(Car car, int num)
        {
            MyCar = car;
            NumberOfCars = num;
        }
    }
}
