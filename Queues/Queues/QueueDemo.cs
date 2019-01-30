using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class QueueDemo
    {
        public void QueueEnqueue(Queue q, int a)
        {
            q.Enqueue(a);
            Console.WriteLine($"Enque {a}");
            // Contain
            foreach(int c in q)
                Console.Write(c+" ");
            Console.WriteLine();
        }
        public void QueueDequeue(Queue q)
        {
            Console.WriteLine("Queue Dequeue");
            int a = (int)q.Dequeue();
            Console.WriteLine(q);

            Console.WriteLine(q);
            foreach(int c in q)
                Console.Write(q);
            Console.WriteLine();
        }
    }
}
