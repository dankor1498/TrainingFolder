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
    class MyClass : IEnumerable
    {
        int[] array;

        public MyClass(int[] array)
        {
            this.array = (int[])array.Clone();
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(this.array);
        }
    }

    class MyEnumerator : IEnumerator
    {
        int[] array;
        int index;

        public MyEnumerator(int[] array)
        {
            this.array = array;
            index = this.array.Length;
        }
        public object Current => array[index];

        public bool MoveNext()
        {
            if(index > 0)
            {
                index--;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            index = this.array.Length;
        }
    }

    static void Main(string[] args)
    {
        int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        MyClass m = new MyClass(ar);
        foreach(var i in m)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        IEnumerator enumerator = new MyEnumerator(ar);
        while (enumerator.MoveNext()) 
        {
            Console.Write(enumerator.Current + " ");
        }
        enumerator.Reset();
        Console.WriteLine();
    }
}
