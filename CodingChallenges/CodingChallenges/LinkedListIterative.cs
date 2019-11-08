using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    // Iterative C# program to search an element 
    // in linked list 
    public class LinkedListIterative
    {
        // Node class 
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        // Linked list class 
        public class LinkedList
        {
            Node head; // Head of list 

            // Inserts a new node at the front of the list 
            public void push(int new_data)
            {
                // Allocate new node and putting data 
                Node new_node = new Node(new_data);

                // Make next of new node as head 
                new_node.next = head;

                // Move the head to point to new Node 
                head = new_node;
            }

            // Checks whether the value x is present in linked list 
            public bool search(Node head, int x)
            {
                Node current = head; // Initialize current 
                while (current != null)
                {
                    if (current.data == x)
                        return true; // data found 
                    current = current.next;
                }
                return false; // data not found 
            }

            // Driver code 
            //public static void Main(String[] args)
            //{

            //    // Start with the empty list 
            //    LinkedList llist = new LinkedList();

            //    /*Use push() to construct below list 
            //    14->21->11->30->10 */
            //    llist.push(10);
            //    llist.push(30);
            //    llist.push(11);
            //    llist.push(21);
            //    llist.push(14);

            //    if (llist.search(llist.head, 14))
            //        Console.WriteLine("Yes");
            //    else
            //        Console.WriteLine("No");

            //    Console.ReadKey();
            //}
        }
    }
}
