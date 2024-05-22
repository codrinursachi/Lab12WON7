Queue<int> intQueue = new(10);
intQueue.Enqueue(1);
intQueue.Enqueue(2);
intQueue.Enqueue(3);
intQueue.Enqueue(4);
Console.WriteLine(intQueue.Dequeue());
Console.WriteLine(intQueue.Dequeue());
Console.WriteLine(intQueue.Dequeue());
Console.WriteLine(intQueue.Dequeue());


Queue<string> stringQueue = new(10);
stringQueue.Enqueue("Hello");
stringQueue.Enqueue("world");
Console.WriteLine(stringQueue.Dequeue());
Console.WriteLine(stringQueue.Dequeue());