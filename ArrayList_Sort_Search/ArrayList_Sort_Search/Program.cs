using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Sort_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Number of elements ");
            Console.WriteLine("Count="+al.Count);

            al.Add(456);
            al.Add(4);
            al.Add(7);
            al.Add(6);
            al.Add(56);
            al.Add(45);
            al.Add(16);

            Console.WriteLine("Number of elements after Adding");
            Console.Write("Count="+al.Count+"\n");

            // Display contents
            foreach(int i in al)
                Console.Write(i+" ");

            // Sort ArrayList
            al.Sort();
            Console.WriteLine("display contents after sorting");
            foreach(int i in al)
                Console.Write(i+" ");

            //Search intdex of 7 in ArrayList
            Console.WriteLine("Index of 7 is "+ al.BinarySearch(7));


        }
    }
}
