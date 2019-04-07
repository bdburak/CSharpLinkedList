using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Burak DOGUCU
//07/04/2019  (dd/mm/yyyy)
//A simple linked list algorithm
//I didn't write the whole algorithm but I added all the delete functions
namespace LinkedList
{
    public class Node
    {
        public Node next;
        public object data;
    }
    public class LinkedList
    {
        private Node head;

        public void PrintAllNodes()
        {
            Node current = head;

            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine();
        }

        public void AddFirst(object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        public void AddLast(object data)
        {
            if (head == null)
            {
                head = new Node();
                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;

                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = toAdd;
            }
        }
        public void DeleteLast()
        {
            Node beforeDeleted = new Node();


            Node toBeDeleted = head;

            while (toBeDeleted.next != null)
            {
                beforeDeleted = toBeDeleted;
                toBeDeleted = toBeDeleted.next;
            }

            beforeDeleted.next = null;

            PrintAllNodes();
        }
        public void DeleteFirst()
        {
            head = head.next;
            PrintAllNodes();
        }
        public void DeleteNode(object data)
        {
            Node beforeDeleted = new Node();
            Node toBeDeleted = head;

            while (toBeDeleted.data != data)
            {
                beforeDeleted = toBeDeleted;
                toBeDeleted = toBeDeleted.next;
            }
            beforeDeleted.next = toBeDeleted.next;


            PrintAllNodes();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("add last:");
            LinkedList list = new LinkedList();

            list.AddLast("bob");
            list.AddLast("tom");
            list.PrintAllNodes();
            Console.WriteLine("\nAfter Delete First:\n");
            list.DeleteFirst();


            Console.WriteLine("\n\nadd first:");
            LinkedList list2 = new LinkedList();

            list2.AddFirst("bob");
            list2.AddFirst("tom");
            list2.PrintAllNodes();
            Console.WriteLine("\nAfter Delete Last:\n");
            list2.DeleteLast();

            Console.WriteLine("\n\nDelete Node Example:");
            LinkedList list3 = new LinkedList();
            list3.AddLast("bob");
            list3.AddLast("tom");
            list3.AddLast("rick");
            list3.AddLast("james");
            list3.AddLast("mike");
            list3.AddLast("suzie");
            list3.PrintAllNodes();
            Console.WriteLine("\nAfter Delete Node With Data of 'mike':\n");
            list3.DeleteNode("mike");
            Console.ReadKey();
        }
    }
}

