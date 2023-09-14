using QueueArray;

Queue fila = new Queue();

fila.Enqueue(5);
fila.Enqueue(3);
fila.Enqueue(77);
fila.Enqueue(25);

fila.Peek();
fila.PrintQueue();

int first = fila.Dequeue();
Console.WriteLine($"primeiro da fila + 2: {first+2}");

fila.Peek();
fila.PrintQueue();

first = fila.Dequeue();
Console.WriteLine($"primeiro da fila + 2: {first+2}");