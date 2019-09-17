using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(30);
            linkedList.Add(25);
            linkedList.Add(35);
            linkedList.Add(53);
            linkedList.Add(58);
            linkedList.Add(15);
            linkedList.Add(32);
            linkedList.Add(61);
            linkedList.Add(99);

            Console.WriteLine($"Root {linkedList.root.id}");
            Console.ReadLine();
            Console.WriteLine($"Root > {linkedList.root.right.id}");
            Console.ReadLine();
            Console.WriteLine($"< Root {linkedList.root.left.id}");
            Console.ReadLine();
            Console.WriteLine($"< < Root {linkedList.root.left.left.id}");
            Console.ReadLine();
            Console.WriteLine($"Root > > {linkedList.root.right.right.id}");
            Console.ReadLine();


        }
    }
}
