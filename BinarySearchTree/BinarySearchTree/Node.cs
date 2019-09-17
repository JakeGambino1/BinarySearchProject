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
        public Node rightLink;
        public Node leftLink;

        // constructor
        public Node(int id)
        {
            this.id = id;
            rightLink = null;
            leftLink = null;
        }

        // member methods
    }
}
