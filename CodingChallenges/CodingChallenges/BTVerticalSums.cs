using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class Program
    {
        public class LinkedListNode
        {
            public int data;
            public LinkedListNode prev, next;
            public LinkedListNode(int d)
            {
                data = d;
            }
        }
        
        public class TreeNode
        {
            public int data;
            public TreeNode left, right;
            public TreeNode(int d)
            {
                data = d;
            }
        }

        //public static void Main(string[] args)
        //{
        //    TreeNode root = new TreeNode(1);
        //    root.left = new TreeNode(2);
        //    root.right = new TreeNode(3);
        //    root.left.left = new TreeNode(4);
        //    root.left.right = new TreeNode(5);
        //    root.right.left = new TreeNode(6);
        //    root.right.right = new TreeNode(7);

        //    Console.WriteLine("Vertical Sums are");
        //    verticalSumDLL(root);
        //    Console.ReadKey();
        //}

        
        public static void verticalSumDLL(TreeNode root)
        {
            LinkedListNode LinkedListNode = new LinkedListNode(0);

            verticalSumDLLUtil(root, LinkedListNode);
            
            while (LinkedListNode.prev != null)
            {
                LinkedListNode = LinkedListNode.prev;
            }

            while (LinkedListNode != null)
            {
                Console.Write(LinkedListNode.data + " ");
                LinkedListNode = LinkedListNode.next;
            }
        }
        
        public static void verticalSumDLLUtil(TreeNode TreeNode, LinkedListNode LinkedListNode)
        {   
            LinkedListNode.data = LinkedListNode.data + TreeNode.data;
            
            if (TreeNode.left != null)
            {
                if (LinkedListNode.prev == null)
                {
                    LinkedListNode.prev = new LinkedListNode(0);
                    LinkedListNode.prev.next = LinkedListNode;
                }
                verticalSumDLLUtil(TreeNode.left, LinkedListNode.prev);
            }

            if (TreeNode.right != null)
            {
                if (LinkedListNode.next == null)
                {
                    LinkedListNode.next = new LinkedListNode(0);
                    LinkedListNode.next.prev = LinkedListNode;
                }
                verticalSumDLLUtil(TreeNode.right, LinkedListNode.next);
            }
        }
    }
} 

