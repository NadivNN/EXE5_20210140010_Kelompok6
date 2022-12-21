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
            if(nadiv == null)
            {
                Console.WriteLine("\nList is Empty");
                return;
            }
            nadiv = nadiv.next;
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
            Queue qe = new Queue();
            char ch;
            while(true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Menambahkan Data ke dalam list");
                    Console.WriteLine("2. Menghapus Data dari Dalam List");
                    Console.WriteLine("3. Melihat semua Data di dalam List");
                    Console.WriteLine("4. Exit");
                    Console.Write("Masukkan pilihan anda (1 - 4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            qe.insert();
                            break;
                        case '2':
                            qe.Delete();
                            break;
                        case '3':
                            qe.Display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Wrong option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nCheck for the value entered ");
                }
            }
        }
    }
        

}
