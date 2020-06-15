using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack;

namespace STACK
{
    public class Stack<T> : IEnumerable<T> where T : IComparable<T>
    {
        public int Count { get; private set; } = 0;
        private Node<T> head;
               
        public void Push(T item)
        {
            Node<T> node = new Node<T>(item);
            node.Next = head;
            head = node;
            Count++;
        }

        public T Pop()
        {
            T t = head.Data;
            head = head.Next;
            Count--;
            return t;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new TreeEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(T value)
        {
            this.Push(value);
        }

        public bool IsEmpty
        {
            get { return Count == 0; }
        }

        public void Sort()
        {
            int N = Count;
            T[] arr = new T[N];

            for(int i = 0; i < N; i++)
            {
                arr[i] = this.Pop();
            }
            
            Array.Sort(arr);

            for (int i = 0; i < N; i++)
            {
                this.Push(arr[i]);
            }
        }
    }
}
