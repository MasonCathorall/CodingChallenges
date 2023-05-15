using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LinkedLists
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

        public Node(int d, Node n)
        {
            data = d;
            next = n;
        }

        public Node() { next = null; }
    }

    public class Intersect
    {
        public void FindIntersect()
        {
            // list 1
            Node n1 = new Node(1);
            n1.next = new Node(2);
            n1.next.next = new Node(3);
            n1.next.next.next = new Node(4);
            n1.next.next.next.next = new Node(5);
            n1.next.next.next.next.next = new Node(6);

            // list 2
            Node n2 = new Node(10);
            n2.next = new Node(9);
            n2.next.next = new Node(8);
            n2.next.next.next = n1.next.next.next;

            Console.WriteLine("Intersected at: " + HashNode(n1, n2).data);
        }

        public Node HashNode(Node n1, Node n2)
        {
            HashSet<Node> visited = new HashSet<Node>();

            while(n1 != null)
            {
                visited.Add(n1);
                n1 = n1.next;
            }
            while(n2 != null)
            {
                if (visited.Contains(n2))
                {
                    return n2;
                }
                n2 = n2.next;
            }
            return null;
        }
    }

    public class DetectCycle
    {
        public Node n;
        public DetectCycle()
        {
            Node n = new Node(1);
            n.next = new Node(2);
            n.next.next = new Node(3);
            n.next.next.next = new Node(4);
            n.next.next.next.next = new Node(5);

            //Make loop to detect
            //n.next.next.next.next.next.next.next = new Node( n.next.next.next.data, n.next.next.next.next);
            n.next.next.next.next.next = n.next.next;
        }
        public Node CycleStart()
        {
            HashSet<Node> visited = new HashSet<Node>();
            //Node temp = new Node();

            while (n != null)
            {
                if (visited.Contains(n))
                {
                    return n;
                }
                n = n.next;
            }
            return null;

            //while (n != null)
            //{
            //    if (n.next == null)
            //    {
            //        return null;
            //    }
            //    if (n.next == temp)
            //    {
            //        break;
            //    }
            //    Node nex = n.next;
            //    n.next = temp;
            //    n = nex;
            //}
            //return n;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Intersect i = new Intersect();
            i.FindIntersect();

            DetectCycle d = new DetectCycle();
            Node res = d.CycleStart();
            if(res == null)
            {
                Console.WriteLine("No loop");
            } else
            {
                Console.WriteLine("Loop at - " +  res);
            }

        }
    }
}