using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingStack
{
    public class Queue
    {
        private Stack<int> stack = new Stack<int>();
        private Stack<int> auxiliaryStack = new Stack<int>();

        public int Peek()
        {
            fillAuxiliaryStackWithStack();
            int value = auxiliaryStack.Peek();
            fillStackWithAuxiliaryStack();
            return value;
        }

        public void Enqueue(int value)
        {
            this.stack.Push(value);
        }

        public int Dequeue()
        {
            fillAuxiliaryStackWithStack();
            int value = auxiliaryStack.Pop();
            fillStackWithAuxiliaryStack();
            return value;
        }

        private void fillAuxiliaryStackWithStack()
        {
            while (stack.Count > 0)
            { //Making the "auxiliaryStack" stack as queue of "Stack"
                auxiliaryStack.Push(stack.Pop());
            }
        }

        public void PrintQueue()
        {
            if (stack.Count == 0)
            {
                return;
            }

            fillAuxiliaryStackWithStack();
            foreach (var item in auxiliaryStack)
            {
                Console.Write("->" + item);
            }
            Console.WriteLine();
            fillStackWithAuxiliaryStack();
        }

        private void fillStackWithAuxiliaryStack()
        {
            while (auxiliaryStack.Count > 0)
            { //Return stack to the original state
                stack.Push(auxiliaryStack.Pop());
            }
        }
    }
}
