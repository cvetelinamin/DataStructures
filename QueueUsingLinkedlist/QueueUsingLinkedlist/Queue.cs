using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingLinkedlist
{
    public class Queue
    {
        private Node first;
        private Node last;
        private int length;

        public Queue()
        {
            this.first = null;
            this.last = null;
            this.length = 0;
        }

        public int Peek()
        {
            if (this.length > 0)
            {
                return this.first.Value;
            }

            return int.MinValue;
        }

        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            if (this.length == 0)
            {
                this.first = newNode;
                this.last = newNode;
            }
            else
            {
                this.last.Next = newNode;
                this.last = newNode;
            }

            this.length++; 
        }

        public int Dequeue()
        {
            if (this.first == null)
            {
                return int.MinValue;
            }
            if (this.length == 0)
            {
                this.last = null;
            }
            Node holdingPointer = this.first;
            this.first = this.first.Next;
            this.length--;

            return holdingPointer.Value;
        }

        public void PrintQueue()
        {
            if (this.first == null)
            {
                return;
            }
            Node currentNode = this.first;
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
