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

        public Node GetRoot()
        {
            return this.root;
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

        int COUNT = 5;
        public void printTree(Node node)
        {
            print2DUtil(root, 0);
        }

        private void print2DUtil(Node root, int space)
        {
            // Base case  
            if (root == null)
                return;

            // Increase distance between levels  
            space += COUNT;

            // Process right child first  
            print2DUtil(root.Right, space);

            // Print current node after space  
            // count  
            Console.Write("\n");
            for (int i = COUNT; i < space; i++)
            {
                Console.Write(" ");
            }
            Console.Write(root.Value + "\n");

            // Process left child  
            print2DUtil(root.Left, space);
        }

        // Iterative
        public List<int> BreathFirstSearch(Node currentNode)
        {
            List<int> list = new List<int>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(currentNode);

            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                list.Add(currentNode.Value);
                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }

            return list;
        }

        // Recurcive
        public List<int> BreathFirstSearchR(Queue<Node> queue, List<int> list)
        {
            if (queue.Count == 0)
            {
                return list;
            }

            var currentNode = queue.Dequeue();
            list.Add(currentNode.Value);

            if (currentNode.Left != null)
            {
                queue.Enqueue(currentNode.Left);
            }

            if (currentNode.Right != null)
            {
                queue.Enqueue(currentNode.Right);
            }

            return BreathFirstSearchR(queue, list);
        }

        public List<int> DFSInOrder()
        {
            List<int> result = new List<int>();
            TraverseInOrder(this.root, result);
            return result;
        }

        public List<int> DFSPreOrder()
        {
            List<int> result = new List<int>();
            TraversePreOrder(this.root, result);
            return result;
        }

        public List<int> DFSPostOrder()
        {
            List<int> result = new List<int>();
            TraversePostOrder(this.root, result);
            return result;
        }

        public List<int> TraverseInOrder(Node node, List<int> list)
        {
            if (node.Left !=null)
            {
                TraverseInOrder(node.Left, list);
            }
            list.Add(node.Value);
            if (node.Right != null)
            {
                TraverseInOrder(node.Right, list);
            }

            return list;
        }

        public List<int> TraversePreOrder(Node node, List<int> list)
        {
            list.Add(node.Value);
            if (node.Left != null)
            {
                TraversePreOrder(node.Left, list);
            }
            
            if (node.Right != null)
            {
                TraversePreOrder(node.Right, list);
            }

            return list;
        }

        public List<int> TraversePostOrder(Node node, List<int> list)
        {
            
            if (node.Left != null)
            {
                TraversePostOrder(node.Left, list);
            }

            if (node.Right != null)
            {
                TraversePostOrder(node.Right, list);
            }
            list.Add(node.Value);
            return list;
        }


    }
}
