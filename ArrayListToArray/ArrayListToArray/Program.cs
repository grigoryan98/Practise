using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            // Add Items
            al.Add(4);
            al.Add(7);
            al.Add(8);
            al.Add(9);
            al.Add(14);
            al.Add(5);
            al.Add(24);

            Console.WriteLine(" contents");
            foreach(int i in al)
                Console.WriteLine(i+" ");

            //get an array
            int[] arr = (int[])al.ToArray(typeof(int));

            // sum items 
            int Sum = 0;
            for (int i = 0; i < arr.Length; i++)
                Sum += arr[i];
            Console.WriteLine("Sum is " + Sum);
            
            
        }
    }
}
