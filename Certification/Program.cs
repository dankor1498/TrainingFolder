using System;
using System.Collections.Generic;

namespace Certification
{
    class Program
    {
        static void Main(string[] args)
        {
            //First task
            Console.WriteLine(new FirstTask("abcd", "dcba").IsReverse());
            Console.WriteLine(new FirstTask("abcd", "aaaa").IsReverse());
            Console.WriteLine();

            //Second task
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
        }
    }
}
