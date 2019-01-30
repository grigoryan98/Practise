using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {

        static void Main(string[] args)
        {
            StackDemo sd = new StackDemo();
            Stack st = new Stack();

            foreach (int c in st)
                Console.WriteLine(c + " ");

            StackDemo.StackPush(st, 17);
            StackDemo.StackPush(st, 78);
            StackDemo.StackPush(st, 24);
            sd.StackPop(st);
            sd.StackPop(st);
            sd.StackPop(st);

        }
    }
}
