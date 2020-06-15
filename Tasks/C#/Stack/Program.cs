using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestStack
{
    class Program
    {
        static void Main(string[] args)
        {
            STACK.Stack<int> stack = new STACK.Stack<int> {3, 4, 8};

            stack.Push(5);
            stack.Push(9);
            stack.Push(3);

            Console.WriteLine($"Count stack = {stack.Count}");

            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

            if (stack.IsEmpty)
            {
                Console.WriteLine($"Count stack = 0");
            }
                       
            stack.Push(5);
            stack.Push(9);
            stack.Push(3);
            stack.Push(-4);
            stack.Pop();
            stack.Push(0);
            
            stack.Sort();
            Console.WriteLine($"Sorted stack:");
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
