using Sorting;

BubbleSort bs = new BubbleSort();

int[] array = { 8, 1, 56, 4, 7, 1, 87, 0 };

int[] sortedArray = bs.Sort(array);

foreach (int item in sortedArray)
{
    Console.WriteLine(item);
}

Console.WriteLine();

InsertionSort ins = new InsertionSort();

int[] sortedArrayIns = ins.Sort(array);

foreach (int item in sortedArrayIns)
{
    Console.WriteLine(item);
}

Console.WriteLine();

MergeSort ms = new MergeSort();

int[] sortedArrayMerge = ms.Sort(array);

foreach (int item in sortedArrayIns)
{
    Console.WriteLine(item);
}