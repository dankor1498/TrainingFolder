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
        class Dream
        {
            public string Goal { get; } 
            
            public Dream(string goal)
            {
                this.Goal = goal;
            }

            public Dream NextDream;
        }
        class QueueDream
        {
            public int Year { get; set; }//тут визначимо рік для цілей

            Dream newDream;
            Dream frontDream;
            Dream prevDream = new Dream("");
            public void AddDream(string dream)//мрію можна лише додати, забирати мрію - не правильно
            {
                newDream = new Dream(dream);
                if(frontDream == null)
                {
                    frontDream = newDream;
                }
                prevDream.NextDream = newDream;
                prevDream = newDream;
            }

            public void PrintDreams()
            {
                Console.WriteLine("Рiк - " + Year);
                Dream iterator = frontDream;
                while (iterator != null)
                {
                    Console.WriteLine(iterator.Goal);
                    iterator = iterator.NextDream;
                }
            }
        }
        static void Main()
        {
            QueueDream queueDream = new QueueDream() { Year = 2020 };            

            queueDream.AddDream("Потрапити на роботу в AMC Bridge.");
            queueDream.AddDream("Покращити свiй фiзичний стан.");
            queueDream.AddDream("Прочитати бiльше книг.");
            queueDream.AddDream("Купити гiтару.");

            queueDream.PrintDreams();
        }
    }
}
 