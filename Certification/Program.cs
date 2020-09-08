using System;
using System.Collections.Generic;
using System.Linq;

namespace Certification
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
            Dictionary<Person, string> dict = new Dictionary<Person, string>();
            dict.Add(new Person("Anna", 20), "Lviv" );
            dict.Add(new Person("Oleg", 21), "Dnipro");

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
                .Select(item => item.Remove(0,1))
                .ToList();
        }
    }
}
