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
        static void Main(string[] args)
        {
            //Дан массив целых чисел. Нужно найти все пары чисел, которые в сумме дают 100.

            int[] array = { 40, 60, 25, 75, 90, 10, 70, 25, 30, 50, 12, 50 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(100 - array[i] == array[j])
                    {
                        Console.WriteLine($"{array[i]} + {array[j]} = 100");
                    }
                }
            }

            // In an array with integers between 1 and 1,000,000 one value is in the array twice. 
            // How do you determine which one?
            int[] ar = { 1, 2, 3, 4, 5, 6, 7 };
            int suma = (8 * ar.Length) / 2;
            Console.WriteLine(suma);
            int[] ar2 = { 1, 2, 3, 4, 4, 5, 6, 7 };
            Console.WriteLine(ar2.Sum() - suma);

            //How would you write a function to reverse a string? And can you do that without a temporary string?
            StringBuilder str = new StringBuilder("MyStrings");
            char c;
            for (int i = 0; i < str.Length / 2; i++)
            {
                c = str[i];
                str[i] = str[str.Length - 1 - i];
                str[str.Length - 1 - i] = c;
            }
            Console.WriteLine(str);

            // Задача: есть нули и единицы в массиве. Надо для каждого нуля посчитать  
            // сколько единиц правее него и вывести сумму таких чисел. Сделать за один проход.

            int[] array1 = { 1, 1, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1 };
            int sumaArray1 = array1.Sum();
            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if(array1[i] == 0)
                {
                    Console.Write((sumaArray1 - sum) + " ");                    
                    continue;
                }
                sum += 1;
            }
            Console.WriteLine();

            int sum2 = 0;
            for (int i = array1.Length - 1; i >= 0; i--)
            {
                if (array1[i] == 0)
                {
                    Console.Write(sum2 + " ");
                    continue;
                }
                sum2 += 1;
            }
            Console.WriteLine();
        }
    }
}


