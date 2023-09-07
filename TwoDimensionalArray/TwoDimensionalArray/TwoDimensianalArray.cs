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

    }
}
