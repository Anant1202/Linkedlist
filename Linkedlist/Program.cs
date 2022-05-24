using System;

namespace Linkedlist
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked list Program");
            LinkedlistOperations obj = new LinkedlistOperations();
            //obj.AddLast(56);
            //obj.AddLast(30);
            //obj.AddLast(70);
            //obj.Print();
            //obj.AddFirst(70);
            //obj.AddFirst(30);
            //obj.AddFirst(56);
            //obj.Print();
            obj.Append(56);
            obj.Append(30);
            obj.Append(70);
            obj.Print();

        }
    }
}

