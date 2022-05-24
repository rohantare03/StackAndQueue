using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    internal class Queue
    {
        LinkedList linked = new LinkedList();
        public void Enqueue(int data)
        {
            linked.Append(data);
        }
        public void DisplayQueue()
        {
            Console.WriteLine("\nQueue: ");
            linked.Display();
        }
    }
}
