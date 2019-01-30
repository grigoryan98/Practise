using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueDemo qd = new QueueDemo();
            Queue q = new Queue();

            foreach (int i in q)
                Console.Write(i + " ");

            qd.QueueEnqueue(q, 7);
            qd.QueueEnqueue(q, 10);
            qd.QueueEnqueue(q, 78);
            qd.QueueDequeue(q);
            qd.QueueDequeue(q);
            qd.QueueDequeue(q);

            try
            {
                qd.QueueDequeue(q);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Queue empty.");
            }

        }
    }
}
