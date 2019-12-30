using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace Test
{
    class Program
    {
        delegate int MyDelegate(int a, int b);

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }

        static int Mult(int a, int b)
        {
            return a * b;
        }
        static void Main()
        {
            MyDelegate myDelegate = new MyDelegate(Sum);
            myDelegate += Minus;
            myDelegate += Mult;

            Delegate[] delegates = myDelegate.GetInvocationList();
            for (int i = 0; i < delegates.Length; i++)
            {
                Console.WriteLine("№" + (i + 1) + " returned: " + 
                    ((MyDelegate)delegates[i])(6, 5));
            }
        }
    }
}
 