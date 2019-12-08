using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    struct Value
    {
        public int t;
        public int id;
        public Value(int t, int id)
        {
            this.t = t;
            this.id = id;
        }

    }
    class Taxi
    {
        enum Tariff { OneRide = 1, RegularCustomer = 2, Subscription = 3 };
        int[] id;
        int[] km;

        public int Profit { get; private set; }
        public Taxi(Value[] cInf, Value[] rInf)
        {
            var tariffId = from c in cInf
                              group c by c.t;

            var customerKm = from c in rInf
                         group c by c.t;

            //for(int i = 0; i < tariffId.Count(); i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(customerKm.GetType().ToString());

            foreach (var g in tariffId)
            {
                Console.WriteLine("Тариф - " + (Tariff)(g.Key));
                Value[] values;
                foreach (var t in g)
                {
                    Console.WriteLine(t.id);
                    switch ((Tariff)g.Key)
                    {
                        case Tariff.OneRide:
                            values = customerKm.First(k => k.Key == t.id).ToArray();
                            Console.WriteLine(CalculateOneRide(values));
                            break;
                        case Tariff.RegularCustomer:
                            values = customerKm.First(k => k.Key == t.id).ToArray();
                            Console.WriteLine(CalculateRegularCustomer(values));
                            break;
                        case Tariff.Subscription:
                            values = customerKm.First(k => k.Key == t.id).ToArray();
                            Console.WriteLine(CalculateSubscription(values));
                            break;
                    }
                }                
            }
            Console.WriteLine();

            //foreach (var g in customerKm)
            //{
            //    Console.WriteLine("ID - " + (g.Key));
            //    foreach (var t in g)
            //    {
            //        Console.WriteLine(t.id);
            //    }
            //}
        }

        int CalculateOneRide(Value[] k)
        {
            var kk = from i in k
                       select i.id;
            return kk.ToArray().Sum() * 8;
        }
        int CalculateRegularCustomer(Value[] kK)
        {
            var v = from i in kK
                     select i.id;
            int[] k = v.ToArray();
            int sale = 0;
            int sum = 0;
            for(int i = 0; i < k.Length; i++)
            {
                sum += (k[i] * 6 - sale) < 0 ? 0 : (k[i] * 6 - sale);
                sale = (k[i] * 6 - sale) / 2 < 0 ? 0 : (k[i] * 6 - sale) / 2;
            }
            return sum;
        }

        int CalculateSubscription(Value[] kK)
        {
            var v = from i in kK
                    select i.id;
            int[] k = v.ToArray();
            if (k.Sum() < 100)
            {
                return k.Sum() * 6;
            }
            return 600 + ((k.Sum() - 100) * 4);
        }
    }

    class Program
    {
        static void ReadString(string input, List<Value> v1, List<Value> v2)
        {
            string[] arrayInput = input.Split();
            int i = 0;
            for(; arrayInput[i] != "-1"; i++)
            {
                v1.Add(new Value(int.Parse(arrayInput[i++]), int.Parse(arrayInput[i])));
            }
            i++;
            for (; arrayInput[i] != "-1"; i++)
            {
                v2.Add(new Value(int.Parse(arrayInput[i++]), int.Parse(arrayInput[i])));
            }
        }
        static void Main(string[] args)
        {
            //Value[] value = new Value[4]{new Value(1, 0),
            //    new Value(2, 1),
            //    new Value(2, 2),
            //    new Value(3, 3) };
            string input = "1 0 2 1 2 2 3 3 -1 0 30 1 50 0 15 1 20 2 30 2 50 3 70 3 50 2 100 3 10 -1";
            List<Value> v1 = new List<Value>();
            List<Value> v2 = new List<Value>();
            ReadString(input, v1, v2);
            Taxi taxi = new Taxi(v1.ToArray(), v2.ToArray());
            
            
            //int[] list = { 11, 4, 3, 7, 12 };

            //var indexes = list.Select((item, index) => new { Item = item, Index = index })
            //         //.Where(n => n.Index % 2 == 0)
            //         .Select(n => n);


            //Console.WriteLine("Even numbers:");
            //foreach (var index in indexes)
            //{
            //    Console.WriteLine(index);
            //}
        }
    }
}
