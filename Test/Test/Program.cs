using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class IntegerCell
    {
        public int Value;
        public IntegerCell Next;

        public static void AddAtBeginning(IntegerCell top, IntegerCell new_cell)
        {
            new_cell.Next = top.Next;
            top.Next = new_cell;
        }
    } 

    class Program
    {
        static int Fact(int n)
        {
            if (n == 1)
                return n;
            return n * Fact(n - 1);
        }
        public static void Main(string[] args)
        {
            //Елементарний список
            //IntegerCell integer = new IntegerCell();
            //integer.Value = 3;
            //integer.Next = null;
            //for (int i = 1; i < 3; i++)
            //{
            //    IntegerCell.AddAtBeginning(integer, new IntegerCell() { Value = i });
            //}

            //while (integer != null)
            //{
            //    Console.Write(integer.Value + " ");
            //    integer = integer.Next;
            //}
            //Console.WriteLine();

            //задача про перестановку двох частин масиву місцями
            int[] mas = { 7, 8, 9, 10, 20, 25, 45 };
            //int m = 5;
            //int temp;
            //for (int i = m; i < mas.Length; i++) 
            //{
            //    temp = mas[mas.Length - 1];
            //    for (int j = mas.Length - 1; j > 0; j--)
            //        mas[j] = mas[j - 1];
            //    mas[0] = temp;
            //}

            //foreach (var item in mas)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //задача про "видалення" елемента з масиву
            int[] mas1 = { 1, 2, 5, 8 };
            //int n = 2;
            //if (n > 0 && n < mas1.Length)
            //{
            //    for (int i = n - 1; i < mas1.Length - 1; i++)
            //    {
            //        mas1[i] = mas1[i + 1];
            //    }
            //}

            //foreach (var item in mas1)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //Задача про об'єднання двох відсортованих масивів
            int[] mas2 = new int[mas1.Length + mas.Length];
            int ii, jj, k;
            ii = jj = k = 0;
            while (ii < mas1.Length && jj < mas.Length)
            {
                if (mas1[ii] < mas[jj])
                {
                    mas2[k++] = mas1[ii++];
                }
                else
                    mas2[k++] = mas[jj++];
            }

            while (ii < mas1.Length)
            {
                mas2[k++] = mas1[ii++];
            }

            while (jj < mas.Length)
            {
                mas2[k++] = mas[jj++];
            }
            foreach (var item in mas2)
            {
                Console.Write(item + " ");
            }
        }
    }
}
