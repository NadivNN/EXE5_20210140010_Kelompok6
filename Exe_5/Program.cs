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
            if(nugraha == null)
            {
                Console.WriteLine("\nQueue is empty");
                return ;
            }
        }
    }
        

}
