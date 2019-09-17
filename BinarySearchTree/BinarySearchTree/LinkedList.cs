using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class LinkedList
    {
        public Node root;
        public void Add(int id)
        {
            if (root == null)
            {
                root = new Node(id);
                return;
            }
            PositionNode(root, new Node(id));
        }

        public void PositionNode(Node root, Node tempNode)
        {
            if (tempNode.id > root.id)
            {
                if(tempNode.right == null)
                {
                    root.right = tempNode;
                }
                else
                {
                    PositionNode(root.right, tempNode);
                }
            }

            if (tempNode.id < root.id)
            {
                if (tempNode.left == null)
                { 
                    root.left = tempNode;
                }
                else
                {
                    PositionNode(root.left, tempNode);
                }
            }
        }

        public Node Search(Node node, int id)
        {
            if (node.id == id)
            {
                return node;
            }

            else if (id > node.id)
            {
                if (node.right != null)
                {
                    return Search(node.right, id);
                }
                return null;
            }

            else if (id < node.id)
            {
                if (node.left != null)
                {
                    return Search(node.left, id);
                }
                return null;
            }
            return null;
        }
    }
}
