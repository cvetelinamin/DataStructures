using BinarySearchTreeProject;

BinarySearchTree tree = new BinarySearchTree();
tree.Insert(9);
tree.Insert(4);
tree.Insert(6);
tree.Insert(20);
tree.Insert(170);
tree.Insert(15);
tree.Insert(1);


var result = tree.BreathFirstSearch(tree.GetRoot());
foreach (var item in result)
{
    Console.Write(item.ToString() + " ");
}
Console.WriteLine();

//Recurcive call
List<int> list = new List<int>();
Queue<Node> queue = new Queue<Node>();
queue.Enqueue(tree.GetRoot());
var result2 = tree.BreathFirstSearchR(queue, list);
foreach (var item in result2)
{
    Console.Write(item.ToString() + " ");
}
Console.WriteLine();

