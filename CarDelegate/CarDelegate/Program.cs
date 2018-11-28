using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //create class instance 
            Car c1 = new Car(10, 100, "BMW");

            c1.RegistreWithCarEngine(OnCarEngineHandler);

            Console.WriteLine("-----Speeding up---------");
            for(int i=0;i<6;i++)
            {
                c1.Accelerate(20);
            }

        }
        public static void OnCarEngineHandler(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine(msg);
            Console.WriteLine("----------------\n");
        }
    }
}
