using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    class MyColection<T> : IEnumerable<T>
    {
        private T[] array;

        public MyColection()
        {
            array = new T[0];
        }

        public void AddItem(T item)
        {
            T[] copyArray = (T[])array.Clone();
            array = new T[array.Length + 1];
            Array.Copy(copyArray, array, copyArray.Length);
            array[array.Length - 1] = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }
    }

    class Item<T>
    {
        public T Value { get; set; }
        public Item<T> PItem;
    }

    class MyColection2<T> : IEnumerable<T>
    {
        Item<T> value;
        Item<T> front;
        Item<T> pointer = new Item<T>();

        public MyColection2()
        {
            value = null;
            front = null;
            pointer = new Item<T>();
        }

        public MyColection2(int l)
        {
            Lenght = l;
            for (int i = 0; i < l; i++)
            {
                value = new Item<T>() { Value = default(T) };
                if (front == null)
                {
                    front = value;
                }
                pointer.PItem = value;
                pointer = value;
            }         
        }

        public int Lenght { get; private set; } = 0;

        public void AddValue(T item)
        {
            value = new Item<T>() { Value = item };
            if(front == null)
            {
                front = value;
            }
            pointer.PItem = value;
            pointer = value;
            Lenght++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Item<T> iterator = front;
            while (iterator != null)
            {
                yield return iterator.Value;
                iterator = iterator.PItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get
            {
                if (index > Lenght - 1)
                {
                    Console.WriteLine("Error of index.");
                    throw new IndexOutOfRangeException();
                }
                int i = 0;
                Item<T> iterator = front;
                while (i < index)
                {
                    iterator = iterator.PItem;
                    i++;
                }
                return iterator.Value;
            }
            set
            {
                if (index > Lenght - 1)
                {
                    Console.WriteLine("Error of index.");
                    throw new IndexOutOfRangeException();
                }
                int i = 0;
                Item<T> iterator = front;
                while (i < index)
                {
                    iterator = iterator.PItem;
                    i++;
                }
                iterator.Value = value;
            }
        }
    }
    
    static void Main(string[] args)
    {
        MyColection<int> m = new MyColection<int>();
        for (int i = 0; i < 15; i++)
        {
            m.AddItem(i + 1);
        }
        foreach (var item in m)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        MyColection2<int> m2 = new MyColection2<int>(10);
        for (int i = 0; i < m2.Lenght; i++)
        {
            m2[i] = i + 1;
        }        
        Console.WriteLine();

        m2.AddValue(11);

        foreach (var item in m2)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}
