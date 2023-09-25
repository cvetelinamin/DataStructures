using QueueUsingLinkedlist;

Queue q = new Queue();
q.Enqueue(10);
q.Enqueue(7);
q.Enqueue(26);
q.PrintQueue();
Console.WriteLine(q.Dequeue());
q.PrintQueue();