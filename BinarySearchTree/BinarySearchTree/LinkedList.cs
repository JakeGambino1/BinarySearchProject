using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class LinkedList
    {
        // member variables
        Node root;

        // constructor

        // member methods
        public void Add(int id)
        {
            Node node = new Node(id);
            if (root == null)
            {
                root = node;
                return;
            }
            Node temporaryRightNode = root;

            while (temporaryRightNode.rightLink != null)
            {
                temporaryRightNode = temporaryRightNode.rightLink;
            }
            temporaryRightNode.rightLink = node;

            Node temporaryLeftNode = root;
            while (temporaryLeftNode.leftLink != null)
            {
                temporaryLeftNode = temporaryLeftNode.leftLink;
            }
            temporaryLeftNode.leftLink = node;
        }
        public Node Search(Node node, int id)
        {
            if (node.id == id)
            {
                return node;
            }

            else if (id > node.id)
            {
                if (node.rightLink != null) {
                    return Search(node.rightLink, id);
                }
                return null;
            }

            else if (id < node.id)
            {
                if (node.leftLink != null)
                {
                    return Search(node.leftLink, id);
                }
                return null;
            }
            return null;
        }
    }
}
