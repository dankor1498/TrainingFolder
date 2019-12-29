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
        static int Sum(int a, int b)
        {
            if (b - a == 1)
                return b + a;
            return b + Sum(a, b - 1);
        }

        static int Rang(int number, int k)
        {
            if (k == 1)
                return number;
            return number * Rang(number, k - 1);
        }

        static int Fibonachi(int number)
        {
            if (number == 0)
                return 1;
            if (number == 1)
                return 2;
            return Fibonachi(number - 1) + Fibonachi(number - 2);
        }

        static int Factorial(int k)
        {
            if (k == 1)
                return k;
            return k * Factorial(k - 1);
        }

        [Flags]
        enum Color : byte
        {
            Red = 1,
            Green = 2,
            Blue = 4
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Sum(4, 6));
            Console.WriteLine(Rang(2, 1));
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Fibonachi(i) + " ");
            }
            Console.WriteLine();
            Console.WriteLine(Factorial(5));
            Color color = Color.Red | Color.Green | Color.Blue;
            Console.WriteLine(color);
        }
    }
}
 