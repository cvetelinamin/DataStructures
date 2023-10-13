using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort
    {
        public int[] Sort(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                int min = i;
                int temp = array[i];
                for (int j = i+1; j < length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                array[i] = array[min];
                array[min] = temp;
            }

            return array;

        }
    }
}
