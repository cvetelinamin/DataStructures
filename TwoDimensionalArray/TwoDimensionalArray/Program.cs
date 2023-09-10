
using TwoDimensionalArray;

TwoDimensianalArray arr = new TwoDimensianalArray(3, 3);

arr.insertValueInTheArray(0, 0, 10);
arr.insertValueInTheArray(0, 1, 20);
arr.insertValueInTheArray(1, 0, 30);
arr.insertValueInTheArray(2, 0, 40);

arr.accessCell(0, 0);
arr.accessCell(1, 10);

arr.traverse2DArray();

arr.searchingValue(10);
arr.searchingValue(50);