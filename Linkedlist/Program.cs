using System;

namespace Linkedlist
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked list Program");
            LinkedlistOperations obj = new LinkedlistOperations();
            obj.AddLast(56);
            obj.AddLast(30);
            obj.AddLast(70);
            obj.Print();
        }
    }
}

