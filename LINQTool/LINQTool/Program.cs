using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTool
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name1 = new List<string> { "Armen", "Karen", "Ashot", "Ani", "Anna" };
            List<string> name2 = new List<string> { "Karlen", "Karen", "Arman", "Anna" };
            double[] doubleNumbers = { 20.1, 1.2, 8.7, 7.9, -4.8, -7.9 };

            var nameExcept = (from n1 in name1 select n1).Except(from n2 in name2 select n2);
            Console.WriteLine("You dont have  this items , I do");
            foreach (var items in nameExcept)
            {
                Console.WriteLine(items);
            }

            var nameIntersect = (from n1 in name1 select n1).Intersect(from n2 in name2 select n2);
            Console.WriteLine("Here is what  we have in common");
                foreach(var items in nameIntersect)
                Console.WriteLine(items);

            var nameUnion = (from n1 in name1 select n1).Union(from n2 in name2 select n2);
            Console.WriteLine("Here is what we have together");
            foreach(var items in nameUnion)
                Console.WriteLine(items);

            Console.WriteLine("Max value of doubleNumbers");
            Console.WriteLine((from d in doubleNumbers select d).Max());
            Console.WriteLine("Min value of doubleNumbers");
            Console.WriteLine((from d in doubleNumbers select d).Min());
            Console.WriteLine("Average of doubleNumbers");
            Console.WriteLine((from d in doubleNumbers select d).Average());
            Console.WriteLine("Sum of all numbers");
            Console.WriteLine((from d in doubleNumbers select d).Sum());

        }
    }
}
