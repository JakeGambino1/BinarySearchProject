﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
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
        public void PositionNode(Node root, Node newNode)
        {
            if (newNode.id > root.id)
            {
                if(root.right == null)
                {
                    root.right = newNode;
                }
                else
                {
                    PositionNode(root.right, newNode);
                }
            }
            if (newNode.id < root.id)
            {
                if (root.left == null)
                { 
                    root.left = newNode;
                }
                else
                {
                    PositionNode(root.left, newNode);
                }
            }
        }
        public Node Search(int id)
        {
            Node searchNode;
            searchNode = root;
            if (id == searchNode.id)
            {
                Console.WriteLine($"{searchNode.id} was found");
                return searchNode;
            }
            else if (id > searchNode.id)
            {
                if (searchNode.right == null)
                {
                    return null;
                }
                searchNode = searchNode.right;
                return Search(id);
            }
            else if (id < searchNode.id)
            {
                if (searchNode.left == null)
                {
                    return null;
                }
                searchNode = searchNode.left;
                return Search(id);
            }
            return null;
        }
    }
}
