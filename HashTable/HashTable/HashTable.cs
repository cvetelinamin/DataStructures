using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProject
{
    public class HashTable
    {
        private class MyNodes : List<MyNode> { }
        private int length;
        private MyNodes[] data;

        public HashTable(int size)
        {
            this.length = size;
            this.data = new MyNodes[size];
        }

        private int hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                int value = (int)key[i];
                hash = (hash + value * i) % this.length;
            }
            Console.WriteLine("hash " + hash + " " + key);
            return hash;
        }

        public void set(string key, int value)
        {
            int index = hash(key);
            if (this.data[index] == null) 
            {
                this.data[index] = new MyNodes();
            }
            this.data[index].Add(new MyNode (key, value));
        }

        public int get(string key)
        {
            int index = hash(key);
            if (this.data[index] == null) { }
            {
                return 0;
            }
            
            foreach (var node in this.data[index])
            {
                if (node.key.Equals(key))
                {
                    Console.WriteLine("Equals");
                    return node.value;
                }
            }

            return 0;
        }

        public List<string> keys()
        {
            List<string> result = new List<string>();

            for (int i = 0; i < this.data.Length; i++)
            {              
                if (this.data[i] != null)
                {
                    for (int j = 0; j < length; j++)
                    {
                        result.Add(this.data[i][j].key);
                    }
                }
            }
            return result;
        }
    }
}
