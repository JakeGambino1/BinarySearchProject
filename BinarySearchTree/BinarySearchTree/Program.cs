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
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(30);
            binarySearchTree.Add(25);
            binarySearchTree.Add(35);
            binarySearchTree.Add(53);
            binarySearchTree.Add(58);
            binarySearchTree.Add(15);
            binarySearchTree.Add(32);
            binarySearchTree.Add(61);
            binarySearchTree.Add(99);

            Console.WriteLine($"Root {binarySearchTree.root.id}");
            Console.WriteLine($"Root > {binarySearchTree.root.right.id}");
            Console.WriteLine($"Root > > {binarySearchTree.root.right.right.id}");
            Console.ReadLine();
            Console.WriteLine($"< Root {binarySearchTree.root.left.id}");
            Console.WriteLine($"< < Root {binarySearchTree.root.left.left.id}");
            Console.ReadLine();

            Node searchResultNode = binarySearchTree.Search(35);
            Console.ReadLine();
        }
    }
}
