using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        // member variables
        public int id;
        public Node left;
        public Node right;

        // constructor
        public Node(int id)
        {
            this.id = id;
            left = null;
            right = null;
        }

        // member methods
    }
}
