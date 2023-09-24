using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingArray
{
    public class Stack
    {
        private ArrayList array;

        public Stack()
        {
            this.array = new ArrayList();
        }

        public int Peek()
        {
            if (this.array.Count > 0)
            {
                return (int)this.array[this.array.Count - 1];
            }

            return int.MinValue;
        }

        public void Push(int value)
        {
            this.array.Add(value);
        }

        public int Pop()
        {
            if (this.array.Count == 0)
            {
                return int.MinValue;
            }
            int lastItem = (int)this.array[this.array.Count - 1];
            this.array.RemoveAt(this.array.Count - 1);
            return lastItem;
        }

        public void PrintStack()
        {
            for(int i = 0; i < this.array.Count; i++)
            {
                Console.WriteLine(this.array[i]);
            }
        }
    }
}
