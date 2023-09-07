/*
Implemente um vetor com estrutura em Pilha disponibilizando 
os métodos Pop(), Push(), Peek(), IsEmpty() e PrintStack() 
embutidos em uma classe C# Stack para ser instanciada e consumida na execução do Program.cs
Esta pilha deve armazenar dados do tipo String e o programa deve carregar alguns valores e exibi-los em sequência.
*/

using System;
using System.ComponentModel.DataAnnotations;

namespace StackClass
{
    public class Stack
    {
        static readonly int MAX = 1000;
        int top = -1;
        string[] stack = new string[MAX];

        public bool IsEmpty()
        {
            return (top < 0);
        }

        public bool Push(string data)
        {
            if(top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }

            ++top;
            stack[top] = data;
            return true;
        }

        public string Pop()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return "";
            }

            return $"[{stack[top--]}]";
        }

        public void Peek()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine($"Topo da pilha: [{stack[top]}]");
        }

        public void PrintStack()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine("Itens da pilha:");
            for(int i = top; i >= 0; i--)
            {
                Console.WriteLine($"Stack[{stack[i]}]");
            }
        }
    }
}