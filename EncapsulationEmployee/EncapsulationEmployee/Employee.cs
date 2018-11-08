using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationEmployee
{
    class Employee
    {
        private string empName;
        private int empId;
        private float curPay;

        public Employee(string name,int id, float pay)
        {
            EmpName = name;
            EmpId = id;
            CurPay = pay;
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
    }
}
