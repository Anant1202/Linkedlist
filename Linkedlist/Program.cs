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
            obj.AddLast(40);

            //obj.AddFirst(70);
            //obj.AddFirst(30);
            //obj.AddFirst(56);
            //obj.Print();
            //obj.Append(56);
            //obj.Append(30);
            //obj.Append(70);
            //obj.Print();
            //obj.InsertBetween(1,56);
            //obj.InsertBetween(2,30);
            //obj.InsertBetween(3,70);
            //obj.Print();
            //obj.DeleteFirst();
            //obj.Print();
            //obj.DeleteLast();
            //obj.Print();


            //obj.SearchAndInsert(30, 40);
            //obj.Print();
            obj.AddLast(70);
            obj.SearchAndDelete(40);
            obj.Print();
        }
    }
}

