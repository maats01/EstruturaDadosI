using StackClass;

Stack pilha = new Stack();

pilha.Push("A");
pilha.Push("B");
pilha.Push("C");
pilha.Push("D");

pilha.PrintStack();

string topo = pilha.Pop();

Console.WriteLine(topo);
pilha.PrintStack();