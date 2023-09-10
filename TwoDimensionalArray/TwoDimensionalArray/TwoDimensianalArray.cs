using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    public class TwoDimensianalArray
    {
        int[,] arr;

        public TwoDimensianalArray(int numberOfRows, int numberOfColumns)
        {
            this.arr = new int[numberOfRows, numberOfColumns];
            for (int  row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr[row, col] = int.MinValue;
                }
            }
        }

        // Inserting value - O(1) time and space complexity
        public void insertValueInTheArray(int row, int col, int value)
        {
            try
            {
                if (arr[row,col] == int.MinValue)
                {
                    arr[row, col] = value;
                    Console.WriteLine("The value is successfully inserted");
                } else
                {
                    Console.WriteLine("The cell is already occupied");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Accessing cell value - O(1) time and space complexity
        public void accessCell(int row, int col)
        {
            Console.WriteLine("\nAccessing Row#" + row + ", Col#" + col);
            try
            {
                Console.WriteLine("Cell value is: " + arr[row,col]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Invalid index for 2D array");
            }
        }

        // Traverse 2D array - O(MN) time complexity, O(1) space complexity
        public void traverse2DArray()
        {
            for (int row = 0; row < arr.GetLength(0); row++)  
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write(arr[row,col] + " ");
                }
                Console.WriteLine();
            }
        }


        // Searching a single value
        public void searchingValue(int value)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    if (arr[row,col] == value)
                    {
                        Console.WriteLine("Value is found at row: " + row + " Col: " + col);
                        return;
                    }
                }
            }

            Console.WriteLine("Value is not found");
        }

    }
}
