using System;

namespace QueueArray
{
    public class Queue
    {
        static readonly int MAX = 100;
        int[] queue = new int[MAX];
        int arrayLength = -1;

        public bool Enqueue(int num)
        {
            if(arrayLength > MAX)
            {
                Console.WriteLine("Queue overflow");
                return false;
            }

            if(arrayLength < 0)
            {
                arrayLength++;
                queue[0] = num;
                return true;
            }

            else
            {
            for(int i = arrayLength; i >= 0; i--)
            {
                queue[i+1] = queue[i];
            }

            arrayLength++;
            queue[arrayLength] = num;
            return true;
            }
        }

        public int Dequeue()
        {
            if(arrayLength < 0)
            {
                Console.WriteLine("Queue underflow");
                return 0;
            }

            int value = queue[0];

            for(int i = 0; i <= arrayLength; i++)
            {
                queue[i] = queue[i+1];
            }

            arrayLength--;
            return value;
        }

        public void Peek()
        {
            if(arrayLength < 0)
            {
                Console.WriteLine("Queue underflow");
                return;
            }

            Console.WriteLine($"Primeiro da fila: [{queue[0]}]");
        }

        public void PrintQueue()
        {
            if(arrayLength < 0)
                Console.WriteLine("Queue underflow");

            Console.WriteLine("Fila: ");
            for(int i = 0; i <= arrayLength; i++)
            {
                Console.WriteLine($"{queue[i]}");
            }
        }
    }
}