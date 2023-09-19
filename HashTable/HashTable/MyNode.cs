using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProject
{
    public class MyNode
    {
        public string key { get; set; }
        public int value { get; set; }

        public MyNode(string key, int value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
