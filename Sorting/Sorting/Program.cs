using Sorting;

BubbleSort bs = new BubbleSort();

int[] array = { 8, 1, 56, 4, 7, 1, 87, 0 };

int[] sortedArray = bs.Sort(array);

foreach (int item in sortedArray)
{
    Console.WriteLine(item);
}

Console.WriteLine();

 int[] insArray = { 8, 1, 56, 4, 7, 1, 87, 0 };
InsertionSort ins = new InsertionSort();

int[] sortedArrayIns = ins.Sort(insArray);

foreach (int item in sortedArrayIns)
{
    Console.WriteLine(item);
}

Console.WriteLine();

 int[] mergeArray = { 8, 1, 56, 4, 7, 1, 87, 0 };
MergeSort ms = new MergeSort();

int[] sortedArrayMerge = ms.Sort(mergeArray);

foreach (int item in sortedArrayIns)
{
    Console.WriteLine(item);
}

Console.WriteLine();

int[] selArray = { 8, 1, 56, 4, 7, 1, 87, 0 };
SelectionSort ss = new SelectionSort();
int[] sortedArraySelection = ss.Sort(selArray);

foreach (int item in sortedArraySelection)
{
    Console.WriteLine(item);
}