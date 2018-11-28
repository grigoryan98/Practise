using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Car
    {
        public  int CurrSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        private bool carIsDead;

        public Car()
        {

        }

        public Car(int cs, int max, string name)
        {
            CurrSpeed = cs;
            MaxSpeed = max;
            PetName = name;
        }

        public delegate void CarEngineHandler(string msgForCaller);
        private CarEngineHandler listOfHandlers;
        public void RegistreWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers = methodToCall;
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (listOfHandlers != null)
                    listOfHandlers("Sorry: this car is dead...");
            }
            else
            {
                CurrSpeed += delta;

                //is this car almost dead
                if (10 == MaxSpeed - CurrSpeed && listOfHandlers != null)
                {
                    listOfHandlers("Careful boddy gonna below");
                }
                if (CurrSpeed > MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrSpeed);
            }
        }
    }

}
