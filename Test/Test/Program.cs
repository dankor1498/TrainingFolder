using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Collections;

namespace Test
{
    class Program
    {
        static int ReturnCubes(int N)
        {
            if (N == 1) return 1;
            return ((N * (N + 1)) / 2) + ReturnCubes(N - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReturnCubes(3));
        }

    }
}


