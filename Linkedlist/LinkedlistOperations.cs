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
