using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationEmployee
{
    class Employee
    {
        private int empAge;
        private string empName;
        private int empId;
        private float curPay;

        public Employee(string name , int id, float pay):this(name,0,id,pay)
        {

        }


        public Employee(string name, int age, int id, float pay)
        {
            EmpName = name;
            Age = age;
            EmpId = id;
            CurPay = pay;
        }




        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string EmpName
        {
            get { return empName; }
            set
            {
                if(value.Length>15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                empName = value;
            }

        }

        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        public float CurPay
        {
            get { return curPay; }
            set { curPay = value; }
        }

        public void GiveBonus(int amount)
        {
            CurPay += amount;
        }

        public void DisplayNotes()
        {
            Console.WriteLine($"Employee name is {EmpName}");
            Console.WriteLine($"Employee age is {Age }");
            Console.WriteLine($"Employee id is {EmpId}");
            Console.WriteLine($"Employee CurrPay is {CurPay}");
        }
    }
}
