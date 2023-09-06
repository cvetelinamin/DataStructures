using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SingleDimensionArray
    {
        int[] arr = null;

        public SingleDimensionArray(int size)
        {
            arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.MinValue;
            }
        }

        public int accessElement(int location)
        {
            int elementValue = 0;
            try
            {
                elementValue = arr[location];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
                return elementValue;
        }
        public void insert(int location, int valueToBeInserted)
        {
            try
            {
                if (arr[location] == int.MinValue)
                {
                    arr[location] = valueToBeInserted;
                    Console.WriteLine("Successfully inserted");
                }
                else
                {
                    Console.WriteLine("This cell is already occupied");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid index to access array!");
            }

        }

        // Time complexity O(N)
        public void traverseArray()
        {
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Array no longer exists!");
            }
      
        }

        //Time complexity O(N)
        public void searchInArray(int valueToSearch)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valueToSearch)
                {
                    Console.WriteLine("The value is found at index of " + i);
                    return;
                }
            }

            Console.WriteLine(valueToSearch + " in not found");
        }

        //Time complexity O(1)
        public void deleteValue(int valueToDeleteIndex)
        {
            try
            {
                arr[valueToDeleteIndex] = int.MinValue;
                Console.WriteLine("The value has been deleted successfully");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("The value that is provided is not in the range of array");
            }
        }

    }
}
