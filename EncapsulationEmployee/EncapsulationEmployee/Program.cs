using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Ashot", 10, 4500);
            emp.GiveBonus(1000);
            Console.WriteLine($"emp curpay  is {emp.CurPay}");

            emp.EmpName = "Karen";
            Console.WriteLine($"emp name is {emp.EmpName}");
        }
    }
}
