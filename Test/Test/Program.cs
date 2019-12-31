using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace Test
{
    class Program
    {
        class MyClass
        {
            public delegate void MyDelegate();
            public event MyDelegate MyEvent;
            public char C { get; set; }

            public void Write()
            {
                while((C = Console.ReadKey().KeyChar) != 'q')
                {
                    if(C == 'd')
                    {
                        MyEvent?.Invoke();
                    }
                }
            }
        }
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.MyEvent += Sound;
            myClass.MyEvent += Sound2;
            myClass.Write();
        }

        public static void Sound()
        {
            SystemSounds.Exclamation.Play();
        }

        public static void Sound2()
        {
            SystemSounds.Hand.Play();
        }
    }
}
 