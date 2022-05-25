using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    public class LinkedlistOperations
    {
        //Creating a head node that will point to the first element
        Node head;
        //Adding element at the end
        public void AddLast(int data)
        {
            Node new_node = new Node(data);
            if (head == null)
            {
                head = new_node;
                return;
            }
            Node lastNode = head;
            while (lastNode.next != null)
            {
                lastNode = lastNode.next;
            }
            lastNode.next = new_node;
        }
        //Adding element at the front
        public void AddFirst(int data)
        {
            Node firstNode=new Node(data);
            if(head == null)
            {
                head=firstNode;
                return;
            }
            firstNode.next = head;
            head = firstNode;
        }
        //Appending element 
        public void Append(int new_data)
        {
            Node new_node = new Node(new_data);
            if (head == null)
            {
                head = new_node;
                return;
            }
            Node temp;
            temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = new_node;

        }
        //Inserting element in between
        public void InsertBetween(int pos, int new_data)
        {
            Node newNode = new Node(new_data);
            if (pos == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else if (pos <= 0)
            {
                Console.WriteLine("Invalid Position!!!");
            }
            else if (pos > 0)
            {
                Node temp = head;

                while (pos != 0)
                {
                    if (pos == 2)
                    {
                        Console.WriteLine(" insertion performed between two nodes");
                        newNode.next = temp.next;
                        temp.next = newNode;
                        break;
                    }
                    temp = temp.next;
                    Console.WriteLine(pos);
                    pos--;
                }

            }
        }
        public void Print()
        {
            Node lastNode=head;
            Console.Write("\nLinked list elements are:");
            while (lastNode!= null)
            {
                Console.Write(lastNode.data + "->"); 
                lastNode = lastNode.next;
            }
            Console.Write("null\n");
        }
    }
}
