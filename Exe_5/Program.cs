using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_5
{
    class Node
    {
        public string name;
        public Node next;
    }
    class Queue
    {
        public Node nadiv, nugraha;
        public Queue()
        {
            nadiv = null;
            nugraha = null;
        }
        public void insert()
        {
            string add;
            Node newnode = new Node();
            Console.WriteLine("Masukkan Element : ");
            add = Console.ReadLine();
            newnode.name = add;
            newnode.next = null;
            if(nadiv == null)
            {
                nadiv = newnode;
                nugraha = newnode;
                return;
            }
            nugraha.next = newnode;
            nugraha = newnode;
        }
        public void Delete()
        {
            if(nugraha == null)
            {
                Console.WriteLine("\nList is Empty");
                return;
            }
            nugraha = nugraha.next;
            if (nadiv == null)
                nugraha = null;
        }
        public void Display()
        { 
            if(nadiv == null)
            {
                Console.WriteLine("\nQueue is empty");
                return ;
            }
            Node display;
            for(display = nadiv; display != null; display = display.next)
                Console.WriteLine(display.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
        

}
