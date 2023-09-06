// Arrays
// Array Insertion 


using DataStructures;

SingleDimensionArray arr = new SingleDimensionArray(10);
arr.insert(0, 0);
arr.insert(1, 10);
arr.insert(2, 20);
arr.insert(1, 30);
arr.insert(12, 120);

// Accessing elements

int firstElement = arr.accessElement(0);
Console.WriteLine(firstElement);

int secondElement = arr.accessElement(11);
Console.WriteLine(secondElement);

// Traversing array

arr.traverseArray();

// Searching in array

arr.searchInArray(10);
arr.searchInArray(100);

// Deleting value

arr.deleteValue(0);
arr.traverseArray();