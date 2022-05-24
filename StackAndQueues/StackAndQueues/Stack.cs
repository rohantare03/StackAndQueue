using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    internal class Stack
    {
        LinkedList linkedList = new LinkedList();
        public void Push(Node node)
        {
            linkedList.AddNode(node);
        }

        public void DisplayStack()
        {
            linkedList.Display();
        }
    }
}
