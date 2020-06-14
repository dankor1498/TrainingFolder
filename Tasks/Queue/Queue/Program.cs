using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < 15; i++)
            {
                queue.Enqueue(i);
            }
            queue.Dequeue();

            foreach (var item in queue.PrintQueue())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            BankQueue<int> bankQueue = new BankQueue<int>(2, 5, new int[] { 1, 3 }, new int[] { 2, 7 });
        }
    }
}
