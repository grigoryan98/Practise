using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stacks
{
    public class StackDemo
    {
        public static void StackPush(Stack st, int a)
        {
            st.Push(a);
            Console.WriteLine($"Push {a}");

            Console.WriteLine("Stack ");
            foreach (int c in st)
                Console.Write(c + " ");
            Console.WriteLine();
        }
        public  void StackPop(Stack st)
        {
            Console.WriteLine("Stack Pop");
            int a = (int)st.Pop();
            Console.WriteLine(a);

            Console.WriteLine("Stack");
            foreach (int c in st)
                Console.Write(c + " ");
            Console.WriteLine();

        }
    }
}
