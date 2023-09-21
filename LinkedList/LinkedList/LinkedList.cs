using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
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
            this.tail= newNode;
            this.length++;
        }

        public void Prepend(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = this.head;
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
            Node leader = TraverseToIndex(index);
            Node holdingPointer = leader.Next;

            leader.Next = newNode;
            newNode.Next = holdingPointer;
            this.length++;

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
            }
            return currentNode;
        }

    }
}
