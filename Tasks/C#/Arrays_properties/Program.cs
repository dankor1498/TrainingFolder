using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Print(Array ar)
        {
            Console.WriteLine($"Size - {ar.SIZE}");
            Console.Write("Array - ");
            foreach (var i in ar.ARR)
            {
                Console.Write(i);
                Console.Write(' ');
            }
            Console.Write('\n');
        }

        static void doWork()
        {
            Array ar = new Array();
            Print(ar);

            int[] mas = { 4, 7, 8, 3, 9, 1 };
            ar.ARR = mas;
            Print(ar);

            ar.SIZE = 10;
            Print(ar);

            ar.ARR = mas;
            Print(ar);

            ar.SIZE = 3;
            Print(ar);

            int[] mas_1 = { 3, 1 };
            ar.ARR = mas_1;
            Print(ar);
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }

            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Bye.");
            }
        }
    }
}
