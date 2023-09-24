using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedlist
{
    public class Stack
    {
        private Node top;
        private Node bottom;
        private int length;

        public Stack()
        {
            this.top = null;
            this.bottom = null;
            this.length = 0;
        }

        public int Peek()
        {
            if(this.length > 0)
            {
                return this.top.Value;
            }
            return int.MinValue; // if lenght is = 0
        }

        public void Push(int value)
        {
            Node newNode = new Node(value);
            if (this.length == 0)
            {
                this.top = newNode;
                this.bottom = newNode;
            }
            else
            {
                Node holdingPointer = this.top;
                this.top = newNode;
                this.top.Next = holdingPointer;
            }

            this.length++;
        }

        public int Pop()
        {
            if (this.length == 0)
            {
                return int.MinValue;
            }
            Node nodeToRemove = this.top;
            this.top = this.top.Next;
            this.length--;
            return nodeToRemove.Value;
        }

        public void PrintStack()
        {
            if (this.top == null)
            {
                return;
            }
            Node currentNode = this.top;
            Console.Write(currentNode.Value);
            currentNode = currentNode.Next;
            while (currentNode != null)
            {
                Console.Write("->" + currentNode.Value);
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }
}
