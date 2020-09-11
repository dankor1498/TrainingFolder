using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // First task
            Console.WriteLine(new FirstTask("abcd", "dcba").IsReverse());
            Console.WriteLine(new FirstTask("abcd", "aaaa").IsReverse());
            Console.WriteLine();

            // Second task
            Dictionary<Person, string> dict = new Dictionary<Person, string>
            {
                {new Person("Anna", 20), "Lviv"}, {new Person("Oleg", 21), "Dnipro"}
            };

            // This code will generate an error because this is the same Key as the first value.
            // StackOverflow: Yes, it is possible, but you should override Equals and GetHashCode of your Person class.
            // Otherwise keys (i.e. persons) will be compared by reference.
            // And every new instance will be considered different, even if all fields have same values.
            // dict.Add(new Person("Anna", 20), "Odessa");

            foreach (var item in dict)
            {
                Console.WriteLine($"Key: {item.Key.Name}, {item.Key.Age} Value: {item.Value}");
            }

            Console.WriteLine();

            // Third task
            foreach (var word in WordsStartsWithA("aaa ABBB AbbB SHY Asa AWER"))
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();

            // Fourth task
            foreach (var word in WordsWithoutFirst("aaa ABBB AbbB SHY Asa AWER"))
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();

            // Fifth task
            foreach (var word in WordsStartsWithUpper("aaa ABBB AbbB SHY Asa AWER"))
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();

            // Sixth task
            Console.WriteLine(IsReverse(new[] {"a", "b", "c", "d"}, new[] {"d", "c", "b", "a"}));
            Console.WriteLine(IsReverse(new[] {"a", "b", "c", "d"}, new[] {"a", "b", "c", "d"}));
            Console.WriteLine();

            // Seventh task
            Console.WriteLine(SkippedNumber(new[] {0, 1, 2, 4, 5}));
            Console.WriteLine();

            // Eighth task
            Console.WriteLine(CountEmail(new List<string>
            {
                "email_1@gmail.com",
                "email_1@gmail.com",
                "email_2@gmail.com",
                "email_3@gmail.com",
                "email_3@gmail.com"
            }));
            Console.WriteLine();

            // Ninth task
            foreach (var item in RebuildFunc(new[] {1, 2, 3, 4}, new[] {7, 7, 7}, 3))
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            // Tenth task
            foreach (var item in SplitNumber(13345))
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            // Eleventh task
            Console.WriteLine(FindNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9}, 5));
            Console.WriteLine(FindNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9}, 0));
            Console.WriteLine();

            // Twelfth task
            Console.WriteLine(FindWordsCount("Start, hello I am here, start. Start new game!", "Start"));
            Console.WriteLine();

            // Thirteenth task
            Console.WriteLine(DeleteWords("Start, hello I am here, start.Start new game!"));

            // Fourteenth task
            foreach (var item in DeleteNegativeNumbers(new[] {1, -5, 5, 7, -4, 10}))
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            // Fifteenth task
            foreach (var item in NextFiveNumbers(new List<int>() {1, 2, 3, 4, 5, 6, 7, 8}))
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            // Sixteenth task
            foreach (var item in JoinArrays(new[] {1, 2, 3}, new[] {4, 5, 6}))
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        public static int[] JoinArrays(int[] arr1, int[] arr2)
        {
            int[] array = new int[arr1.Length + arr2.Length];
            for (int i = 0, j = 0; i < array.Length; i++, j++)
            {
                array[i++] = arr1[j];
                array[i] = arr2[j];
            }

            return array;
        }

        public static List<int> NextFiveNumbers(List<int> list)
        {
            List<int> listRes = new List<int>();
            int count = list.Count >= 10 ? 10 : list.Count;
            for (int i = 5; i < count; i++)
            {
                listRes.Add(list[i]);
            }

            return listRes;
        }

        public static int[] DeleteNegativeNumbers(int[] array)
        {
            if (array == null)
                return null;
            List<int> list = new List<int>();
            foreach (var num in array)
            {
                if (num >= 0)
                {
                    list.Add(num);
                }
            }

            list.Reverse();

            return list.ToArray();
        }

        public static string DeleteWords(string str)
        {
            return string.Join(" ",
                str.Split(new char[] {' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries).Distinct());
        }

        public static int FindWordsCount(string str, string word)
        {
            int i = 0;
            int x = -1;
            int count = -1;
            while (i != -1)
            {
                i = str.IndexOf(word, x + 1, StringComparison.Ordinal);
                x = i;
                count++;
            }

            return count;
            // OR
            // return str.Split(new string[] { word }, StringSplitOptions.None).Count() - 1;
        }

        public static int FindNumber(int[] arr, int num)
        {
            return arr.Contains(num) ? num : -1;
        }

        public static int[] SplitNumber(int i)
        {
            Stack<int> numbers = new Stack<int>();
            while (i != 0)
            {
                numbers.Push(i % 10);
                i /= 10;
            }

            return numbers.ToArray();
        }

        public static int[] RebuildFunc(int[] arr1, int[] arr2, int position)
        {
            int[] arr = new int[arr1.Length + arr2.Length];
            int i = 0;
            for (; i < position; i++)
                arr[i] = arr1[i];
            for (int j = 0; j < arr2.Length; j++, i++)
                arr[i] = arr2[j];
            for (int j = position; j < arr1.Length; j++, i++)
                arr[i] = arr1[j];
            return arr;
        }

        static int CountEmail(List<string> emails)
        {
            var res = from email in emails
                group email by email;
            int count = 0;
            foreach (var r in res)
            {
                if (r.Count() > 1)
                    count += r.Count();
            }

            return count;
        }

        static int SkippedNumber(int[] arr)
        {
            // return (arr[^1] + 1) * arr[^1] / 2 -  arr.Sum();
            // OR
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 != arr[i + 1])
                    return arr[i] + 1;
            }

            return 0;
        }

        static bool IsReverse(string[] arr1, string[] arr2)
        {
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0, j = arr1.Length - 1; i < arr1.Length; i++, j--)
                {
                    if (arr1[i] != arr2[j])
                        return false;
                }

                return true;
            }

            return false;
        }

        static List<string> WordsStartsWithA(string sentence)
        {
            return sentence
                .Split()
                .Where(el => el.All(Char.IsUpper))
                .Where(el => el.StartsWith('A'))
                .ToList();
        }

        static List<string> WordsStartsWithUpper(string sentence)
        {
            return sentence
                .Split()
                .Where(el => Char.IsUpper(el.First()))
                .ToList();
        }

        static List<string> WordsWithoutFirst(string sentence)
        {
            return sentence
                .Split()
                .Select(item => item.Remove(0, 1))
                .ToList();
        }
    }
}
