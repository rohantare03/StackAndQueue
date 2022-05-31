// See https://aka.ms/new-console-template for more information
namespace StackAndQueues
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue!!");
            Node node1 = new Node(70);
            Node node2 = new Node(30);
            Node node3 = new Node(56);

            //UC1 : create stack
            Stack stack = new Stack();
            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);
            stack.DisplayStack();

            //UC2 : Pop stack
            stack.Pop(node1);
            stack.Pop(node2);
            stack.Pop(node3);
            stack.DisplayStack();

            //UC3 : create queue
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.DisplayQueue();
            
            //UC4 : Dequeue
            queue.Dequeue();
            queue.DisplayQueue();
        }
    }
}
