using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    public class BinarySearchTree
    {
        private Node root;
        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Insert(int value)
        {
            Node newNode = new Node(value);
            if (this.root == null)
            {
                this.root = newNode;
                return;
            }

            Node currentNode = this.root;
            while (true)
            {
                if (currentNode.Value > value)
                {
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = new Node(value);
                        return;
                    }
                    currentNode = currentNode.Left;
                }
                else
                {
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = new Node(value);
                        return ;
                    }
                    currentNode = currentNode.Right;
                }
            }
        }

        public Node Lookup(int value)
        {
            if (this.root == null)
            {
                return null;
            }

            Node currentNode = this.root;
            while (currentNode != null)
            {
                if (value < currentNode.Value)
                {
                    currentNode = currentNode.Left;
                }
                else if(value > currentNode.Value)
                {
                    currentNode=currentNode.Right;
                }
                else
                {
                    return currentNode;
                }
            }

            return null;
        }

         public void Remove(int value)
        {
            if (this.root == null)
            {
                return;
            }

            Node nodeToRemove = this.root;
            Node parentNode = null;
            while (nodeToRemove.Value != value)
            {
                //Searching for the node to remove and it's parent
                parentNode = nodeToRemove;
                if (value < nodeToRemove.Value)
                {
                    nodeToRemove = nodeToRemove.Left;
                } 
                else if(value > nodeToRemove.Value)
                {
                    nodeToRemove = nodeToRemove.Right;
                }
            }

            Node replacementNode = null;
            if (nodeToRemove.Right != null)
            { //We have a right node
                replacementNode = nodeToRemove.Right;
                if (replacementNode.Left == null)
                { //We don't have a left node
                    replacementNode.Left = nodeToRemove.Left;
                }
                else
                { //We have a have a left node, lets find the leftmost
                    Node replacementParentNode = nodeToRemove;
                    while (replacementNode.Left != null)
                    {
                        replacementParentNode = replacementNode;
                        replacementNode = replacementNode.Left;
                    }
                    replacementParentNode.Left = null;
                    replacementNode.Left = nodeToRemove.Left;
                    replacementNode.Right = nodeToRemove.Right;
                }
            }
            else if (nodeToRemove.Left != null)
            {//We only have a left node
                replacementNode = nodeToRemove.Left;
            }

            if (parentNode == null)
            {
                root = replacementNode;
            }
            else if (parentNode.Left == nodeToRemove)
            { //We are a left child
                parentNode.Left = replacementNode;
            }
            else
            { //We are a right child
                parentNode.Right = replacementNode;
            }
        }
    }
}
