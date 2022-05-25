using System;

namespace Linkedlist
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Welcome to Linked list Program");
            do
            {
                Console.WriteLine("1.Adding Element at Last");
                Console.WriteLine("2.Adding Element at First");
                Console.WriteLine("3.Appending Elements");
                Console.WriteLine("4.Inserting Element in Between");
                Console.WriteLine("5.Deleting Element from first");
                Console.WriteLine("6.Deleting Element from Last");
                Console.WriteLine("7.Searching an Element");
                Console.WriteLine("8.Searching and Inserting");
                Console.WriteLine("9.Searching and Deleting");
                Console.WriteLine("10.Sorting the Linked list");
                Console.WriteLine("11.Exit");
                Console.WriteLine("Enter your choice\n");
                choice = Convert.ToInt32(Console.ReadLine());
                LinkedlistOperations obj = new LinkedlistOperations();
                switch (choice)
                {
                    case 1:
                        obj.AddLast(56);
                        obj.AddLast(30);
                        obj.AddLast(70);
                        obj.Print();
                        break;
                    case 2:
                        obj.AddFirst(70);
                        obj.AddFirst(30);
                        obj.AddFirst(56);
                        obj.Print();
                        break;
                    case 3:
                        obj.Append(56);
                        obj.Append(30);
                        obj.Append(70);
                        obj.Print();
                        break;
                    case 4:
                        obj.InsertBetween(1, 56);
                        obj.InsertBetween(2, 30);
                        obj.InsertBetween(3, 70);
                        obj.Print();
                        break;
                    case 5:
                        obj.AddLast(56);
                        obj.AddLast(30);
                        obj.AddLast(70);
                        obj.DeleteFirst();
                        obj.Print();
                        break;
                    case 6:
                        obj.AddLast(56);
                        obj.AddLast(30);
                        obj.AddLast(70);
                        obj.DeleteLast();
                        obj.Print();
                        break;
                    case 7:
                        obj.AddLast(56);
                        obj.AddLast(30);
                        obj.AddLast(70);
                        obj.Search(30);
                        break;
                    case 8:
                        obj.AddLast(56);
                        obj.AddLast(30);
                        obj.AddLast(70);
                        obj.SearchAndInsert(30, 40);
                        obj.Print();
                        break;
                    case 9:
                        obj.AddLast(56);
                        obj.AddLast(30);
                        obj.AddLast(40);
                        obj.AddLast(70);
                        obj.SearchAndDelete(40);
                        obj.Print();
                        break;
                    case 10:
                        obj.AddLast(56);
                        obj.AddLast(30);
                        obj.AddLast(40);
                        obj.AddLast(70);
                        obj.Sort();
                        obj.Print();
                        break;
                    case 11:
                        Console.WriteLine("Exit");
                        return;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            } while (choice != 11);
        }
    }
}

