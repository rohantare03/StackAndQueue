﻿// See https://aka.ms/new-console-template for more information
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

            Stack stack = new Stack();
            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);
            stack.DisplayStack();

            stack.Pop(node1);
            stack.DisplayStack();
            stack.Pop(node2);
            stack.DisplayStack();
            stack.Pop(node3);
            stack.DisplayStack();
        }
    }
}
