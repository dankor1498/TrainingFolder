using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate void MyDelegate(object o);

        static void Main(string[] args)
        {
            MyString[] str = new MyString[4] { new MyString(), new MyString(), new MyString(), new MyString() };
            
            MyDelegate myDelegate = null;

            for (int i = 0; i<4; i++)
            {
                myDelegate += str[i].SetString;
            }

            myDelegate("Hi!!!");

            foreach (var i in str)
            {
                Console.WriteLine(i.Str);
            }
        }
    }
}
