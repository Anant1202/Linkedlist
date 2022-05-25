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
        //Deleting the first element
        public void DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("Linked boxes is already empty"); 
            }
            head = head.next;
        }
        //Deleting the Last element
        public void DeleteLast()
        {
            if (head==null)
            {
                Console.WriteLine("Linked boxes is already empty");
                return;
            }
            Node prevNode = head;
            Node lastNode = head.next;
            while(lastNode.next != null)
            {
                prevNode = lastNode;
                lastNode = lastNode.next;
            }
            prevNode.next = null;
        }
        //Searching a particular element 
        public Node Search(int value)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Element found.. " + value);
                    return temp;
                }
                temp = temp.next;
            }
            Console.WriteLine("Element not found");
            return null;
        }
        //>If element is found in Search method,then after that insert the element
        public int SearchAndInsert(int searchdata, int data)
        {
            Node temp = Search(searchdata);
            Node newNode = new Node(data);
            newNode.next = temp.next;
            temp.next = newNode;
            return (newNode.data);
        }
        //Method for displaying the values
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
