using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    public class LinkedlistOperations
    {
        Node head;
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
        public void Print()
        {
            Node lastNode=head;
            Console.Write("Simple Linked list :");
            while (lastNode!= null)
            {
                Console.Write(lastNode.data + "->"); 
                lastNode = lastNode.next;
            }
            Console.Write("null\n");
        }
    }
}
