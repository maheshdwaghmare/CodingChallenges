using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class CircularLinkedList
    {
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
        Node head;

        // Constructor  
        CircularLinkedList()
        {
            head = null;
        }

        /* function to insert a new_node  
      in a list in sorted way. Note that  
      this function expects a pointer 
      to head node as this can modify 
      the head of the input linked list */
        void sortedInsert(Node new_node)
        {
            Node current = head;

            // Case 1 of the above algo  
            if (current == null)
            {
                new_node.next = new_node;
                head = new_node;

            }
            else if (current.data >= new_node.data)
            {

                /* If value is smaller than head's value then we need to change next of last node */
                while (current.next != head)
                    current = current.next;

                current.next = new_node;
                new_node.next = head;
                head = new_node;
            }
            else
            {

                /* Locate the node before the point of insertion */
                while (current.next != head &&
                    current.next.data < new_node.data)
                    current = current.next;

                new_node.next = current.next;
                current.next = new_node;
            }
        }

        // Utility method to print a linked list  
        void printList()
        {
            if (head != null)
            {
                Node temp = head;
                do
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                while (temp != head);
            }
        }

        // Driver code   
        //public static void Main(String[] args)
        //{
        //    CircularLinkedList list = new CircularLinkedList();

        //    // Creating the linkedlist  
        //    int[] arr = { 12, 56, 2, 11, 1, 90 };

        //    /* start with empty linked list */
        //    Node temp = null;

        //    /* Create linked list from the  
        //      array arr[]. Created linked list 
        //      will be 1->2->11->12->56->90*/
        //    for (int i = 0; i < 6; i++)
        //    {
        //        temp = new Node(arr[i]);
        //        list.sortedInsert(temp);
        //    }
        //    list.printList();
        //}
    }
}

