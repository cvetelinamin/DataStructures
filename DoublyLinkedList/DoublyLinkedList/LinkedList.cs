using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class LinkedList
    {
        private Node head;
        private Node tail;
        private int length;

        public LinkedList(int value)
        {
            this.head = new Node(value);
            this.tail = this.head;
            this.length = 1;
        }

        public void Append(int value)
        {
            Node newNode = new Node(value);
            this.tail.Next = newNode;
            newNode.Prev = this.tail;
            this.tail = newNode;
            this.length++;
        }

        public void Prepend(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = this.head;
            this.head.Prev = newNode;
            this.head = newNode;
            this.length++;
        }

        public void Insert(int index, int value)
        {
            index = WrapIndex(index);
            if (index == 0)
            {
                Prepend(value);
                return;
            }
            if (index == length - 1)
            {
                Append(value);
            }

            Node newNode = new Node(value);
            Node leader = TraverseToIndex(index - 1);
            Node follower = leader.Next;
            
            leader.Next = newNode;
            newNode.Prev = leader;
            newNode.Next = follower;
            follower.Prev = newNode;
            this.length++;

        }

        public void Remove(int index)
        {
            index = WrapIndex(index);
            if (index == 0)
            {
                head = head.Next;
                return;
            }

            Node leader = TraverseToIndex(index - 1);
            Node nodeToDelete = leader.Next;
            leader.Next = nodeToDelete.Next;
            nodeToDelete.Next.Prev = leader;
            this.length--;
        }


        public void PrintList()
        {
            if (this.head == null)
            {
                return;
            }
            Node current = this.head;
            while (current != null)
            {
                Console.Write("-->" + current.Value);
                current = current.Next;
            }
            Console.WriteLine();
        }

        public int getLength()
        {
            return this.length;
        }

        public Node getHead()
        {
            return this.head;
        }

        public Node getTail()
        {
            return this.tail;
        }

        private int WrapIndex(int index)
        {
            return Math.Max(Math.Min(index, this.length - 1), 0);
        }

        private Node TraverseToIndex(int index)
        {
            int counter = 0;
            index = WrapIndex(index);
            Node currentNode = head;
            while (counter != index)
            {
                currentNode = currentNode.Next;
                counter++;
            }
            return currentNode;
        }

    }
}
