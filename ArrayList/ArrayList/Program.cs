using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            Console.WriteLine("number of elements");
            Console.WriteLine("Count=" + al.Count);
            Console.WriteLine("Add elements");

            al.Add('A');
            al.Add('B');
            al.Add('C');
            al.Add('D');
            al.Add('E');

            Console.WriteLine("Number of elements after Adding");
            Console.WriteLine("Count =" + al.Count);

            Console.WriteLine("Display contents");
            for(int i=0;i<=al.Count-1;i++)
                Console.Write(al[i]+" ");

            Console.WriteLine("Remove 2  elements");
            al.Remove('A');
            al.Remove('D');

            Console.WriteLine("Number of elements after removing");
            Console.WriteLine("Count ="+al.Count);

            Console.WriteLine("Add new 20 elements ");
            for (int i = 0; i < 230; i++)
                al.Add((char)('a' + i));
            Console.WriteLine("Current capacity");
            Console.WriteLine("Capacity="+al.Capacity);

            Console.WriteLine("Contents");
            foreach(char c in al)
                Console.Write(c+" ");

        }
    }
}
