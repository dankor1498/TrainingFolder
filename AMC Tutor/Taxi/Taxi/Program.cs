using System;
using System.Collections.Generic;
using System.Linq;

namespace Taxi
{
    struct Value
    {
        public int val_1;
        public int val_2;

        public Value(int v_1, int v_2)
        {
            this.val_1 = v_1;
            this.val_2 = v_2;
        }
    }
    class Taxi
    {
        enum Tariff { OneRide = 1, RegularCustomer = 2, Subscription = 3 };

        public int Profit { get; private set; }

        public Taxi(Value[] customersInfo, Value[] ridesInfo)
        {
            var tariffId = from t in customersInfo
                              group t by t.val_1;

            var customerKilometers = from c in ridesInfo
                         group c by c.val_1;

            Profit = 0;

            foreach (var tariff in tariffId)
            {
                //Console.WriteLine("Тариф - " + (Tariff)(g.Key));
                Value[] values;
                foreach (var t in tariff)
                {
                    //Console.WriteLine(t.id);
                    switch ((Tariff)tariff.Key)
                    {
                        case Tariff.OneRide:
                            values = customerKilometers.First(k => k.Key == t.val_2).ToArray();
                            Profit += CalculateOneRide(values);
                            break;
                        case Tariff.RegularCustomer:
                            values = customerKilometers.First(k => k.Key == t.val_2).ToArray();
                            Profit += CalculateRegularCustomer(values);
                            break;
                        case Tariff.Subscription:
                            values = customerKilometers.First(k => k.Key == t.val_2).ToArray();
                            Profit += CalculateSubscription(values);
                            break;
                    }
                }                
            }            
        }

        int CalculateOneRide(Value[] values)
        {
            var array = from i in values
                       select i.val_2;
            return array.ToArray().Sum() * 8;
        }

        int CalculateRegularCustomer(Value[] values)
        {
            var v = from i in values
                     select i.val_2;
            int[] array = v.ToArray();
            int sale = 0;
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += (array[i] * 6 - sale) < 0 ? 0 : (array[i] * 6 - sale);
                sale = (array[i] * 6 - sale) / 2 < 0 ? 0 : (array[i] * 6 - sale) / 2;
            }
            return sum;
        }

        int CalculateSubscription(Value[] values)
        {
            var v = from i in values
                    select i.val_2;
            int[] array = v.ToArray();
            if (array.Sum() < 100)
            {
                return array.Sum() * 6;
            }
            return 600 + ((array.Sum() - 100) * 4);
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
            string input = Console.ReadLine();
            List<Value> v1 = new List<Value>();
            List<Value> v2 = new List<Value>();
            ReadString(input, v1, v2);
            Taxi taxi = new Taxi(v1.ToArray(), v2.ToArray());
            Console.Write(taxi.Profit);
        }
    }
}
